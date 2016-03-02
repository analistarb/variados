
SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tbhistoricopreco`
-- ----------------------------
DROP TABLE IF EXISTS `tbhistoricopreco`;
CREATE TABLE `tbhistoricopreco` (
  `IdHistoricoPreco` int(11) NOT NULL auto_increment,
  `IdProduto` int(11) NOT NULL,
  `Data` datetime NOT NULL,
  `Valor` decimal(18,2) NOT NULL,
  PRIMARY KEY  (`IdHistoricoPreco`),
  KEY `IdProduto` (`IdProduto`),
  CONSTRAINT `tbhistoricopreco_ibfk_1` FOREIGN KEY (`IdProduto`) REFERENCES `tbproduto` (`IdProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbhistoricopreco
-- ----------------------------
INSERT INTO `tbhistoricopreco` VALUES ('1', '1', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('2', '2', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('3', '3', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('4', '4', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('5', '5', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('6', '6', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('7', '7', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('8', '8', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('9', '9', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('10', '10', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('11', '11', '2014-01-01 00:00:00', '10.00');
INSERT INTO `tbhistoricopreco` VALUES ('12', '1', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('13', '2', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('14', '3', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('15', '4', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('16', '5', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('17', '6', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('18', '7', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('19', '8', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('20', '9', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('21', '10', '2014-02-02 00:00:00', '50.00');
INSERT INTO `tbhistoricopreco` VALUES ('22', '11', '2014-02-02 00:00:00', '50.00');

-- ----------------------------
-- Table structure for `tbproduto`
-- ----------------------------
DROP TABLE IF EXISTS `tbproduto`;
CREATE TABLE `tbproduto` (
  `IdProduto` int(11) NOT NULL auto_increment,
  `Nome` varchar(45) NOT NULL,
  `Tipo` varchar(45) NOT NULL,
  PRIMARY KEY  (`IdProduto`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbproduto
-- ----------------------------
INSERT INTO `tbproduto` VALUES ('1', 'Trigo', 'Cereais');
INSERT INTO `tbproduto` VALUES ('2', 'Arroz', 'Cereais');
INSERT INTO `tbproduto` VALUES ('3', 'Aveia', 'Cereais');
INSERT INTO `tbproduto` VALUES ('4', 'Centeio', 'Cereais');
INSERT INTO `tbproduto` VALUES ('5', 'Cevada', 'Cereais');
INSERT INTO `tbproduto` VALUES ('6', 'Sorgo', 'Cereais');
INSERT INTO `tbproduto` VALUES ('7', 'Milho', 'Cereais');
INSERT INTO `tbproduto` VALUES ('8', 'Ervilha', 'Leguminosas');
INSERT INTO `tbproduto` VALUES ('9', 'Feijão', 'Leguminosas');
INSERT INTO `tbproduto` VALUES ('10', 'Lentilha', 'Leguminosas');
INSERT INTO `tbproduto` VALUES ('11', 'Soja', 'Leguminosas');
