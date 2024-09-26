namespace Lab1AdoNet
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePhones = new System.Windows.Forms.TabPage();
            this.buttonSavePhone = new System.Windows.Forms.Button();
            this.dataGridViewBuses = new System.Windows.Forms.DataGridView();
            this.routes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPagOrders = new System.Windows.Forms.TabPage();
            this.buttonSaveOrders = new System.Windows.Forms.Button();
            this.dataGridViewTrips = new System.Windows.Forms.DataGridView();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.dataGridViewReport1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGetReport1 = new System.Windows.Forms.Button();
            this.comboBoxReport1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSP = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonReport2 = new System.Windows.Forms.Button();
            this.dataGridViewReport2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePhones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuses)).BeginInit();
            this.tabPagOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).BeginInit();
            this.tabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePhones);
            this.tabControl1.Controls.Add(this.tabPagOrders);
            this.tabControl1.Controls.Add(this.tabPageQuery);
            this.tabControl1.Controls.Add(this.tabPageSP);
            this.tabControl1.Location = new System.Drawing.Point(-1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePhones
            // 
            this.tabPagePhones.Controls.Add(this.buttonSavePhone);
            this.tabPagePhones.Controls.Add(this.dataGridViewBuses);
            this.tabPagePhones.Location = new System.Drawing.Point(4, 22);
            this.tabPagePhones.Name = "tabPagePhones";
            this.tabPagePhones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhones.Size = new System.Drawing.Size(781, 418);
            this.tabPagePhones.TabIndex = 0;
            this.tabPagePhones.Text = "Автобусы";
            this.tabPagePhones.UseVisualStyleBackColor = true;
            // 
            // buttonSavePhone
            // 
            this.buttonSavePhone.Location = new System.Drawing.Point(6, 6);
            this.buttonSavePhone.Name = "buttonSavePhone";
            this.buttonSavePhone.Size = new System.Drawing.Size(163, 23);
            this.buttonSavePhone.TabIndex = 1;
            this.buttonSavePhone.Text = "Сохранить изменения";
            this.buttonSavePhone.UseVisualStyleBackColor = true;
            this.buttonSavePhone.Click += new System.EventHandler(this.buttonSavePhone_Click);
            // 
            // dataGridViewBuses
            // 
            this.dataGridViewBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routes,
            this.PhoneName,
            this.Column1,
            this.Route});
            this.dataGridViewBuses.Location = new System.Drawing.Point(0, 34);
            this.dataGridViewBuses.Name = "dataGridViewBuses";
            this.dataGridViewBuses.Size = new System.Drawing.Size(778, 381);
            this.dataGridViewBuses.TabIndex = 0;
            // 
            // routes
            // 
            this.routes.DataPropertyName = "bus_id";
            this.routes.HeaderText = "Id";
            this.routes.Name = "routes";
            this.routes.ReadOnly = true;
            // 
            // PhoneName
            // 
            this.PhoneName.DataPropertyName = "bus_model";
            this.PhoneName.HeaderText = "Модель";
            this.PhoneName.Name = "PhoneName";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "capacity";
            this.Column1.HeaderText = "Вместимость";
            this.Column1.Name = "Column1";
            // 
            // Route
            // 
            this.Route.DataPropertyName = "capacity FROM buses";
            this.Route.HeaderText = "Отправление";
            this.Route.Name = "Route";
            // 
            // tabPagOrders
            // 
            this.tabPagOrders.Controls.Add(this.buttonSaveOrders);
            this.tabPagOrders.Controls.Add(this.dataGridViewTrips);
            this.tabPagOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPagOrders.Name = "tabPagOrders";
            this.tabPagOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagOrders.Size = new System.Drawing.Size(781, 418);
            this.tabPagOrders.TabIndex = 1;
            this.tabPagOrders.Text = "Данные";
            this.tabPagOrders.UseVisualStyleBackColor = true;
            // 
            // buttonSaveOrders
            // 
            this.buttonSaveOrders.Location = new System.Drawing.Point(9, 7);
            this.buttonSaveOrders.Name = "buttonSaveOrders";
            this.buttonSaveOrders.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveOrders.TabIndex = 1;
            this.buttonSaveOrders.Text = "Сохранить";
            this.buttonSaveOrders.UseVisualStyleBackColor = true;
            this.buttonSaveOrders.Click += new System.EventHandler(this.buttonSaveOrders_Click);
            // 
            // dataGridViewTrips
            // 
            this.dataGridViewTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrips.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewTrips.Name = "dataGridViewTrips";
            this.dataGridViewTrips.Size = new System.Drawing.Size(778, 418);
            this.dataGridViewTrips.TabIndex = 0;
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.dataGridViewReport1);
            this.tabPageQuery.Controls.Add(this.groupBox1);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuery.Size = new System.Drawing.Size(781, 418);
            this.tabPageQuery.TabIndex = 2;
            this.tabPageQuery.Text = "Отчет1";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport1
            // 
            this.dataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridViewReport1.Location = new System.Drawing.Point(9, 87);
            this.dataGridViewReport1.Name = "dataGridViewReport1";
            this.dataGridViewReport1.Size = new System.Drawing.Size(649, 325);
            this.dataGridViewReport1.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "departure_time";
            this.Column2.HeaderText = "Время отправления ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "arrival_time";
            this.Column3.HeaderText = "Время прибытия ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "destination";
            this.Column5.HeaderText = "Куда";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "distance";
            this.Column4.HeaderText = "Растояние";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetReport1);
            this.groupBox1.Controls.Add(this.comboBoxReport1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonGetReport1
            // 
            this.buttonGetReport1.Location = new System.Drawing.Point(422, 20);
            this.buttonGetReport1.Name = "buttonGetReport1";
            this.buttonGetReport1.Size = new System.Drawing.Size(75, 23);
            this.buttonGetReport1.TabIndex = 2;
            this.buttonGetReport1.Text = "Найти";
            this.buttonGetReport1.UseVisualStyleBackColor = true;
            this.buttonGetReport1.Click += new System.EventHandler(this.buttonGetReport1_Click);
            // 
            // comboBoxReport1
            // 
            this.comboBoxReport1.FormattingEnabled = true;
            this.comboBoxReport1.Location = new System.Drawing.Point(112, 17);
            this.comboBoxReport1.Name = "comboBoxReport1";
            this.comboBoxReport1.Size = new System.Drawing.Size(268, 21);
            this.comboBoxReport1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место отправления";
            // 
            // tabPageSP
            // 
            this.tabPageSP.Controls.Add(this.numericUpDown2);
            this.tabPageSP.Controls.Add(this.numericUpDown1);
            this.tabPageSP.Controls.Add(this.buttonReport2);
            this.tabPageSP.Controls.Add(this.dataGridViewReport2);
            this.tabPageSP.Controls.Add(this.label3);
            this.tabPageSP.Controls.Add(this.label2);
            this.tabPageSP.Location = new System.Drawing.Point(4, 22);
            this.tabPageSP.Name = "tabPageSP";
            this.tabPageSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSP.Size = new System.Drawing.Size(781, 418);
            this.tabPageSP.TabIndex = 3;
            this.tabPageSP.Text = "Отчет2";
            this.tabPageSP.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(307, 13);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(129, 15);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonReport2
            // 
            this.buttonReport2.Location = new System.Drawing.Point(458, 10);
            this.buttonReport2.Name = "buttonReport2";
            this.buttonReport2.Size = new System.Drawing.Size(89, 23);
            this.buttonReport2.TabIndex = 4;
            this.buttonReport2.Text = "Найти";
            this.buttonReport2.UseVisualStyleBackColor = true;
            this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // dataGridViewReport2
            // 
            this.dataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport2.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewReport2.Name = "dataGridViewReport2";
            this.dataGridViewReport2.Size = new System.Drawing.Size(535, 370);
            this.dataGridViewReport2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Рейсы в месяц";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePhones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuses)).EndInit();
            this.tabPagOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).EndInit();
            this.tabPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSP.ResumeLayout(false);
            this.tabPageSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePhones;
        private System.Windows.Forms.TabPage tabPagOrders;
        private System.Windows.Forms.DataGridView dataGridViewTrips;
        private System.Windows.Forms.DataGridView dataGridViewBuses;
        private System.Windows.Forms.Button buttonSavePhone;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSP;
        private System.Windows.Forms.ComboBox comboBoxReport1;
        private System.Windows.Forms.DataGridView dataGridViewReport1;
        private System.Windows.Forms.Button buttonGetReport1;
        private System.Windows.Forms.Button buttonReport2;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonSaveOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn routes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

