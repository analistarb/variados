
-- ----------------------------
-- Table structure for "HR"."TbHistoricoPreco"
-- ----------------------------
CREATE TABLE "HR"."TbHistoricoPreco" (
"IdHistoricoPreco" NUMBER NOT NULL ,
"IdProduto" NUMBER(11) NULL ,
"Data" DATE NULL ,
"Valor" NUMBER NULL 
)
LOGGING
NOCOMPRESS
NOCACHE

;

-- ----------------------------
-- Records of TbHistoricoPreco
-- ----------------------------
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('1', '1', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('2', '2', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('3', '3', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('4', '4', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('5', '5', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('6', '6', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('7', '7', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('8', '8', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('9', '9', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('10', '10', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('11', '11', TO_DATE('2014-01-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '10');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('12', '1', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('13', '2', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('14', '3', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('15', '4', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('16', '5', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('17', '6', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('18', '7', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('19', '8', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('20', '9', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('21', '10', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');
INSERT INTO "HR"."TbHistoricoPreco" VALUES ('22', '11', TO_DATE('2014-02-02 00:00:00', 'YYYY-MM-DD HH24:MI:SS'), '50');

-- ----------------------------
-- Table structure for "HR"."TbProduto"
-- ----------------------------
CREATE TABLE "HR"."TbProduto" (
"IdProduto" NUMBER NOT NULL ,
"Nome" NVARCHAR2(45) NULL ,
"Tipo" NVARCHAR2(45) NULL 
)
LOGGING
NOCOMPRESS
NOCACHE

;

-- ----------------------------
-- Records of TbProduto
-- ----------------------------
INSERT INTO "HR"."TbProduto" VALUES ('2', 'Arroz', 'Cereais');
INSERT INTO "HR"."TbProduto" VALUES ('3', 'Aveia', 'Cereais');
INSERT INTO "HR"."TbProduto" VALUES ('1', 'Trigo', 'Cereais');
INSERT INTO "HR"."TbProduto" VALUES ('4', 'Centeio', 'Cereais');
INSERT INTO "HR"."TbProduto" VALUES ('5', 'Cevada', 'Cereais');
INSERT INTO "HR"."TbProduto" VALUES ('6', 'Sorgo', 'Cereais');
INSERT INTO "HR"."TbProduto" VALUES ('7', 'Milho', 'Cereais');
INSERT INTO "HR"."TbProduto" VALUES ('8', 'Ervilha', 'Leguminosas');
INSERT INTO "HR"."TbProduto" VALUES ('9', 'Feijão', 'Leguminosas');
INSERT INTO "HR"."TbProduto" VALUES ('10', 'Lentilha', 'Leguminosas');
INSERT INTO "HR"."TbProduto" VALUES ('11', 'Soja', 'Leguminosas');

-- ----------------------------
-- Indexes structure for table TbHistoricoPreco
-- ----------------------------

-- ----------------------------
-- Triggers structure for table "HR"."TbHistoricoPreco"
-- ----------------------------
CREATE OR REPLACE TRIGGER "HR"."TRG_BI_TBHISTORICOPRECO" BEFORE INSERT ON "HR"."TbHistoricoPreco" REFERENCING OLD AS "OLD" NEW AS "NEW" FOR EACH ROW ENABLE
begin
if :new."IdHistoricoPreco" is null then
select IdHistoricoPreco_SEQ.nextval
into :new."IdHistoricoPreco"
from dual;
end if;
end;

-- ----------------------------
-- Checks structure for table "HR"."TbHistoricoPreco"
-- ----------------------------
ALTER TABLE "HR"."TbHistoricoPreco" ADD CHECK ("IdHistoricoPreco" IS NOT NULL);

-- ----------------------------
-- Primary Key structure for table "HR"."TbHistoricoPreco"
-- ----------------------------
ALTER TABLE "HR"."TbHistoricoPreco" ADD PRIMARY KEY ("IdHistoricoPreco");

-- ----------------------------
-- Indexes structure for table TbProduto
-- ----------------------------

-- ----------------------------
-- Triggers structure for table "HR"."TbProduto"
-- ----------------------------
CREATE OR REPLACE TRIGGER "HR"."TRG_BI_TBPRODUTO" BEFORE INSERT ON "HR"."TbProduto" REFERENCING OLD AS "OLD" NEW AS "NEW" FOR EACH ROW ENABLE
begin
if :new."IdProduto" is null then
select IdProduto_SEQ.nextval
into :new."IdProduto"
from dual;
end if;
end;

-- ----------------------------
-- Checks structure for table "HR"."TbProduto"
-- ----------------------------
ALTER TABLE "HR"."TbProduto" ADD CHECK ("IdProduto" IS NOT NULL);

-- ----------------------------
-- Primary Key structure for table "HR"."TbProduto"
-- ----------------------------
ALTER TABLE "HR"."TbProduto" ADD PRIMARY KEY ("IdProduto");

-- ----------------------------
-- Foreign Key structure for table "HR"."TbHistoricoPreco"
-- ----------------------------
ALTER TABLE "HR"."TbHistoricoPreco" ADD FOREIGN KEY ("IdProduto") REFERENCES "HR"."TbProduto" ("IdProduto") ON DELETE SET NULL;
