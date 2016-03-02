--
-- PostgreSQL database dump
--

-- Dumped from database version 9.0.23
-- Dumped by pg_dump version 9.0.23
-- Started on 2016-02-18 23:14:56

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = off;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET escape_string_warning = off;

--
-- TOC entry 452 (class 2612 OID 11574)
-- Name: plpgsql; Type: PROCEDURAL LANGUAGE; Schema: -; Owner: postgres
--

CREATE OR REPLACE PROCEDURAL LANGUAGE plpgsql;


ALTER PROCEDURAL LANGUAGE plpgsql OWNER TO postgres;

SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 142 (class 1259 OID 16568)
-- Dependencies: 6
-- Name: TbHistoricoPreco; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "TbHistoricoPreco" (
    "IdHistoricoPreco" integer NOT NULL,
    "IdProduto" integer,
    "Data" date,
    "Valor" real
);


ALTER TABLE public."TbHistoricoPreco" OWNER TO postgres;

--
-- TOC entry 143 (class 1259 OID 16571)
-- Dependencies: 142 6
-- Name: TbHistoricoPreco_IdHistoricoPreco_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "TbHistoricoPreco_IdHistoricoPreco_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."TbHistoricoPreco_IdHistoricoPreco_seq" OWNER TO postgres;

--
-- TOC entry 1800 (class 0 OID 0)
-- Dependencies: 143
-- Name: TbHistoricoPreco_IdHistoricoPreco_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "TbHistoricoPreco_IdHistoricoPreco_seq" OWNED BY "TbHistoricoPreco"."IdHistoricoPreco";


--
-- TOC entry 1801 (class 0 OID 0)
-- Dependencies: 143
-- Name: TbHistoricoPreco_IdHistoricoPreco_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"TbHistoricoPreco_IdHistoricoPreco_seq"', 23, true);


--
-- TOC entry 144 (class 1259 OID 16573)
-- Dependencies: 6
-- Name: TbProduto; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "TbProduto" (
    "IdProduto" integer NOT NULL,
    "Nome" character varying(45),
    "Tipo" character varying(45)
);


ALTER TABLE public."TbProduto" OWNER TO postgres;

--
-- TOC entry 145 (class 1259 OID 16576)
-- Dependencies: 144 6
-- Name: TbProduto_IdProduto_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "TbProduto_IdProduto_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."TbProduto_IdProduto_seq" OWNER TO postgres;

--
-- TOC entry 1802 (class 0 OID 0)
-- Dependencies: 145
-- Name: TbProduto_IdProduto_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "TbProduto_IdProduto_seq" OWNED BY "TbProduto"."IdProduto";


--
-- TOC entry 1803 (class 0 OID 0)
-- Dependencies: 145
-- Name: TbProduto_IdProduto_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"TbProduto_IdProduto_seq"', 11, true);


--
-- TOC entry 1786 (class 2604 OID 16578)
-- Dependencies: 143 142
-- Name: IdHistoricoPreco; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "TbHistoricoPreco" ALTER COLUMN "IdHistoricoPreco" SET DEFAULT nextval('"TbHistoricoPreco_IdHistoricoPreco_seq"'::regclass);


--
-- TOC entry 1787 (class 2604 OID 16579)
-- Dependencies: 145 144
-- Name: IdProduto; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "TbProduto" ALTER COLUMN "IdProduto" SET DEFAULT nextval('"TbProduto_IdProduto_seq"'::regclass);


--
-- TOC entry 1793 (class 0 OID 16568)
-- Dependencies: 142
-- Data for Name: TbHistoricoPreco; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO "TbHistoricoPreco" VALUES (1, 1, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (2, 2, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (3, 3, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (4, 4, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (5, 5, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (6, 6, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (7, 7, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (8, 8, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (9, 9, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (10, 10, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (11, 11, '2014-01-01', 10);
INSERT INTO "TbHistoricoPreco" VALUES (12, 1, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (13, 2, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (14, 3, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (15, 4, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (16, 5, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (17, 6, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (18, 7, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (19, 8, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (20, 9, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (21, 10, '2014-02-02', 50);
INSERT INTO "TbHistoricoPreco" VALUES (22, 11, '2014-02-02', 50);


--
-- TOC entry 1794 (class 0 OID 16573)
-- Dependencies: 144
-- Data for Name: TbProduto; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO "TbProduto" VALUES (1, 'Trigo', 'Cereais');
INSERT INTO "TbProduto" VALUES (2, 'Arroz', 'Cereais');
INSERT INTO "TbProduto" VALUES (3, 'Aveia', 'Cereais');
INSERT INTO "TbProduto" VALUES (4, 'Centeio', 'Cereais');
INSERT INTO "TbProduto" VALUES (5, 'Cevada', 'Cereais');
INSERT INTO "TbProduto" VALUES (6, 'Sorgo', 'Cereais');
INSERT INTO "TbProduto" VALUES (7, 'Milho', 'Cereais');
INSERT INTO "TbProduto" VALUES (8, 'Ervilha', 'Leguminosas');
INSERT INTO "TbProduto" VALUES (9, 'Feijão', 'Leguminosas');
INSERT INTO "TbProduto" VALUES (10, 'Lentilha', 'Leguminosas');
INSERT INTO "TbProduto" VALUES (11, 'Soja', 'Leguminosas');


--
-- TOC entry 1789 (class 2606 OID 16581)
-- Dependencies: 142 142
-- Name: TbHistoricoPreco_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "TbHistoricoPreco"
    ADD CONSTRAINT "TbHistoricoPreco_pkey" PRIMARY KEY ("IdHistoricoPreco");


--
-- TOC entry 1791 (class 2606 OID 16583)
-- Dependencies: 144 144
-- Name: TbProduto_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "TbProduto"
    ADD CONSTRAINT "TbProduto_pkey" PRIMARY KEY ("IdProduto");


--
-- TOC entry 1792 (class 2606 OID 16584)
-- Dependencies: 1790 144 142
-- Name: tbhistoricopreco_ibfk_1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "TbHistoricoPreco"
    ADD CONSTRAINT tbhistoricopreco_ibfk_1 FOREIGN KEY ("IdProduto") REFERENCES "TbProduto"("IdProduto");


--
-- TOC entry 1799 (class 0 OID 0)
-- Dependencies: 6
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2016-02-18 23:14:57

--
-- PostgreSQL database dump complete
--

