--
-- PostgreSQL database dump
--

-- Dumped from database version 14.5
-- Dumped by pg_dump version 14.5

-- Started on 2023-09-19 21:24:42

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 3346 (class 1262 OID 16560)
-- Name: PhonesForWinApp; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "PhonesForWinApp" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';


ALTER DATABASE "PhonesForWinApp" OWNER TO postgres;

\connect "PhonesForWinApp"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 210 (class 1259 OID 16562)
-- Name: manufacturer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.manufacturer (
    id integer NOT NULL,
    name text
);


ALTER TABLE public.manufacturer OWNER TO postgres;

--
-- TOC entry 209 (class 1259 OID 16561)
-- Name: Manufacturer_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Manufacturer_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Manufacturer_Id_seq" OWNER TO postgres;

--
-- TOC entry 3347 (class 0 OID 0)
-- Dependencies: 209
-- Name: Manufacturer_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Manufacturer_Id_seq" OWNED BY public.manufacturer.id;


--
-- TOC entry 214 (class 1259 OID 16578)
-- Name: order; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."order" (
    id integer NOT NULL,
    address character varying(100),
    total numeric(18,2),
    customer character varying(100),
    date timestamp without time zone,
    "phoneNumber" character varying(50)
);


ALTER TABLE public."order" OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 16577)
-- Name: Order_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Order_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Order_Id_seq" OWNER TO postgres;

--
-- TOC entry 3348 (class 0 OID 0)
-- Dependencies: 213
-- Name: Order_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Order_Id_seq" OWNED BY public."order".id;


--
-- TOC entry 212 (class 1259 OID 16571)
-- Name: phone; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.phone (
    id integer NOT NULL,
    name character varying NOT NULL,
    cost numeric(18,2) NOT NULL,
    description character varying,
    "manufacturerId" integer NOT NULL
);


ALTER TABLE public.phone OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 16570)
-- Name: Phone_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Phone_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Phone_Id_seq" OWNER TO postgres;

--
-- TOC entry 3349 (class 0 OID 0)
-- Dependencies: 211
-- Name: Phone_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Phone_Id_seq" OWNED BY public.phone.id;


--
-- TOC entry 215 (class 1259 OID 16584)
-- Name: phoneOrder; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."phoneOrder" (
    orderid integer NOT NULL,
    phoneid integer NOT NULL
);


ALTER TABLE public."phoneOrder" OWNER TO postgres;

--
-- TOC entry 3178 (class 2604 OID 16565)
-- Name: manufacturer id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.manufacturer ALTER COLUMN id SET DEFAULT nextval('public."Manufacturer_Id_seq"'::regclass);


--
-- TOC entry 3180 (class 2604 OID 16581)
-- Name: order id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."order" ALTER COLUMN id SET DEFAULT nextval('public."Order_Id_seq"'::regclass);


--
-- TOC entry 3179 (class 2604 OID 16574)
-- Name: phone id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.phone ALTER COLUMN id SET DEFAULT nextval('public."Phone_Id_seq"'::regclass);


--
-- TOC entry 3335 (class 0 OID 16562)
-- Dependencies: 210
-- Data for Name: manufacturer; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.manufacturer VALUES (1, 'Sony');
INSERT INTO public.manufacturer VALUES (2, 'Apple');
INSERT INTO public.manufacturer VALUES (3, 'Sumsung');
INSERT INTO public.manufacturer VALUES (4, 'Huawei');


--
-- TOC entry 3339 (class 0 OID 16578)
-- Dependencies: 214
-- Data for Name: order; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."order" VALUES (1, '2121', 60000.00, 'Peter', '2023-12-12 00:00:00', '32165488');


--
-- TOC entry 3337 (class 0 OID 16571)
-- Dependencies: 212
-- Data for Name: phone; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.phone VALUES (1, 'phone1', 56000.00, 'yea', 1);
INSERT INTO public.phone VALUES (2, 'phone2', 23200.00, 'no', 3);


--
-- TOC entry 3340 (class 0 OID 16584)
-- Dependencies: 215
-- Data for Name: phoneOrder; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."phoneOrder" VALUES (1, 1);


--
-- TOC entry 3350 (class 0 OID 0)
-- Dependencies: 209
-- Name: Manufacturer_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Manufacturer_Id_seq"', 4, true);


--
-- TOC entry 3351 (class 0 OID 0)
-- Dependencies: 213
-- Name: Order_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Order_Id_seq"', 1, true);


--
-- TOC entry 3352 (class 0 OID 0)
-- Dependencies: 211
-- Name: Phone_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Phone_Id_seq"', 2, true);


--
-- TOC entry 3182 (class 2606 OID 16569)
-- Name: manufacturer PK_public.Manufacturer; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.manufacturer
    ADD CONSTRAINT "PK_public.Manufacturer" PRIMARY KEY (id);


--
-- TOC entry 3187 (class 2606 OID 16583)
-- Name: order PK_public.Order; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."order"
    ADD CONSTRAINT "PK_public.Order" PRIMARY KEY (id);


--
-- TOC entry 3184 (class 2606 OID 16576)
-- Name: phone PK_public.Phone; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.phone
    ADD CONSTRAINT "PK_public.Phone" PRIMARY KEY (id);


--
-- TOC entry 3189 (class 2606 OID 16588)
-- Name: phoneOrder PK_public.PhoneOrder; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."phoneOrder"
    ADD CONSTRAINT "PK_public.PhoneOrder" PRIMARY KEY (orderid, phoneid);


--
-- TOC entry 3190 (class 1259 OID 16590)
-- Name: PhoneOrder_IX_OrderId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "PhoneOrder_IX_OrderId" ON public."phoneOrder" USING btree (orderid);


--
-- TOC entry 3191 (class 1259 OID 16591)
-- Name: PhoneOrder_IX_PhoneId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "PhoneOrder_IX_PhoneId" ON public."phoneOrder" USING btree (phoneid);


--
-- TOC entry 3185 (class 1259 OID 16589)
-- Name: Phone_IX_ManufacturerId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "Phone_IX_ManufacturerId" ON public.phone USING btree ("manufacturerId");


--
-- TOC entry 3193 (class 2606 OID 16597)
-- Name: phoneOrder FK_public.PhoneOrder_public.Order_OrderId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."phoneOrder"
    ADD CONSTRAINT "FK_public.PhoneOrder_public.Order_OrderId" FOREIGN KEY (orderid) REFERENCES public."order"(id) ON DELETE CASCADE;


--
-- TOC entry 3194 (class 2606 OID 16602)
-- Name: phoneOrder FK_public.PhoneOrder_public.Phone_PhoneId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."phoneOrder"
    ADD CONSTRAINT "FK_public.PhoneOrder_public.Phone_PhoneId" FOREIGN KEY (phoneid) REFERENCES public.phone(id) ON DELETE CASCADE;


--
-- TOC entry 3192 (class 2606 OID 16592)
-- Name: phone FK_public.Phone_public.Manufacturer_ManufacturerId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.phone
    ADD CONSTRAINT "FK_public.Phone_public.Manufacturer_ManufacturerId" FOREIGN KEY ("manufacturerId") REFERENCES public.manufacturer(id);


-- Completed on 2023-09-19 21:24:43

--
-- PostgreSQL database dump complete
--

