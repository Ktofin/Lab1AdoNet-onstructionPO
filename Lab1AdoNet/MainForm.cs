using Npgsql;
using Npgsql.Internal;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1AdoNet
{
    public partial class MainForm : Form
    {
        #region Строка подключения к БД

        private string connectionString;

        #endregion

        #region Объекты NpgsqlDataAdapter

        private NpgsqlDataAdapter busAdapter;
        private NpgsqlDataAdapter tripAdapter;
        private NpgsqlDataAdapter routeAdapter;

        #endregion

        #region Объекты NpgsqlCommandBuilder

        private NpgsqlCommandBuilder busBuilder = new NpgsqlCommandBuilder();
        private NpgsqlCommandBuilder tripBuilder = new NpgsqlCommandBuilder();

        #endregion

        #region Объект DataSet

        private DataSet dataSet = new DataSet();

        #endregion

        public MainForm()
        {
            InitializeComponent();

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            // Создание объектов NpgsqlDataAdapter.
            busAdapter = new NpgsqlDataAdapter("SELECT bus_id, bus_model, capacity FROM buses;", connectionString);
            tripAdapter = new NpgsqlDataAdapter("SELECT trip_id, bus_id, driver_id, route_id, departure_time, arrival_time, available_seats FROM trips;", connectionString);
            routeAdapter = new NpgsqlDataAdapter("SELECT route_id, origin, destination, distance FROM routes;", connectionString);

            // Автоматическая генерация команд SQL.
            busBuilder = new NpgsqlCommandBuilder(busAdapter);
            tripBuilder = new NpgsqlCommandBuilder(tripAdapter);

            // Заполнение таблиц в DataSet.
            busAdapter.Fill(dataSet, "buses");
            tripAdapter.Fill(dataSet, "trips");
            routeAdapter.Fill(dataSet, "routes");

            // Связывание элементов управления с данными.


            dataGridViewBuses.DataSource = dataSet.Tables["buses"]; ;
            dataGridViewTrips.DataSource = dataSet.Tables["trips"];

            // Заполнение комбобокса "Производитель" в таблице "Товары".
            FillRouteCombobox();

            // Заполнение комбобокса "Производитель" для отчета1.
            FillReport1Combobox();
        }

        private void FillReport1Combobox()
        {
            using (var sqlConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlDataAdapter sqlAdapter = new NpgsqlDataAdapter("SELECT * FROM routes", sqlConnection);

                // Заполнение dataSet данными из sqlAdapter.
                DataSet dataSet = new DataSet();
                sqlAdapter.Fill(dataSet, "routes");

                // Связывание комбобокса cbSupplier с таблицей suppliers из dataSet.
                comboBoxReport1.DataSource = dataSet.Tables["routes"];
                comboBoxReport1.DisplayMember = "origin";
                comboBoxReport1.ValueMember = "route_id";
            }
        }

        /// <summary>
        /// Заполнить комбобокс "Маршрут" в таблице "Рейсы".
        /// </summary>
        private void FillRouteCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewBuses.Columns["route"]).DataSource =
                dataSet.Tables["routes"];
            ((DataGridViewComboBoxColumn)dataGridViewBuses.Columns["route"]).DisplayMember =
                "origin";
            ((DataGridViewComboBoxColumn)dataGridViewBuses.Columns["route"]).ValueMember =
                "route_id";
        }

        /// <summary>
        /// Сохранить изменения в таблице material.
        /// </summary>
        private void buttonSavePhone_Click(object sender, EventArgs e)
        {
            busAdapter.Update(dataSet, "buses");
        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                sqlConnection.Open();
                NpgsqlCommand sqlCommand =
                    new NpgsqlCommand("SELECT t.departure_time, t.arrival_time, r.distance, r.destination" +
                                      " FROM trips t JOIN routes r ON t.route_id = r.route_id" +
                                      " WHERE r.route_id = " + comboBoxReport1.SelectedValue
                                      , sqlConnection);
                NpgsqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable("report1");
                dataTable.Columns.Add("departure_time");
                dataTable.Columns.Add("arrival_time");
                dataTable.Columns.Add("distance");
                dataTable.Columns.Add("destination");
                while (sqlDataReader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["departure_time"] = sqlDataReader["departure_time"];
                    row["arrival_time"] = sqlDataReader["arrival_time"];
                    row["distance"] = sqlDataReader["distance"];
                    row["destination"] = sqlDataReader["destination"];
                    dataTable.Rows.Add(row);
                }
                sqlDataReader.Close();
                dataGridViewReport1.DataSource = dataTable;
            }
        }

        /// <summary>
        /// нажатие кнопки вызова хранимой процедуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport2_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand("SELECT * FROM get_trips_by_month($1, $2)", sqlConnection)
                {
                    Parameters =
            {
                new NpgsqlParameter(){Value = (int)numericUpDown1.Value}, // Месяц
                new NpgsqlParameter(){Value= (int)numericUpDown2.Value},  // Год
            }
                };
                sqlConnection.Open();
                sqlCommand.Prepare();
                DataTable dataTable = new DataTable("report2");
                var sqlAdapter = new NpgsqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataTable);

                dataGridViewReport2.DataSource = dataTable;
            }

        }

        private void buttonSaveOrders_Click(object sender, EventArgs e)
        {
            tripAdapter.Update(dataSet, "trips");
        }
    }
}
