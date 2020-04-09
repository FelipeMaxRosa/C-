-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.35-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema lojadalala
--

CREATE DATABASE IF NOT EXISTS lojadalala;
USE lojadalala;

--
-- Temporary table structure for view `clientespf`
--
DROP TABLE IF EXISTS `clientespf`;
DROP VIEW IF EXISTS `clientespf`;
CREATE TABLE `clientespf` (
  `id` int(11),
  `nome` varchar(50),
  `apelido` varchar(50),
  `rg` varchar(12),
  `cpf` varchar(15),
  `cep` varchar(9),
  `logradouro` varchar(45),
  `numero` varchar(10),
  `bairro` varchar(45),
  `cidade` varchar(45),
  `estado` char(2),
  `datanasc` date,
  `nomepai` varchar(50),
  `nomemae` varchar(50),
  `email` varchar(50),
  `telefone1` varchar(13),
  `ramal1` varchar(10),
  `telefone2` varchar(13),
  `ramal2` varchar(10),
  `obs` varchar(200),
  `c_status` varchar(30)
);

--
-- Temporary table structure for view `clientespj`
--
DROP TABLE IF EXISTS `clientespj`;
DROP VIEW IF EXISTS `clientespj`;
CREATE TABLE `clientespj` (
  `id` int(11),
  `razaosocial` varchar(50),
  `nomefantasia` varchar(50),
  `ie` varchar(15),
  `cnpj` varchar(18),
  `cep` varchar(9),
  `logradouro` varchar(45),
  `numero` varchar(10),
  `bairro` varchar(45),
  `cidade` varchar(45),
  `estado` char(2),
  `email` varchar(50),
  `telefone1` varchar(13),
  `ramal1` varchar(10),
  `telefone2` varchar(13),
  `ramal2` varchar(10),
  `obs` varchar(200),
  `c_status` varchar(30)
);

--
-- Definition of table `caixa`
--

DROP TABLE IF EXISTS `caixa`;
CREATE TABLE `caixa` (
  `idcaixa` int(11) NOT NULL AUTO_INCREMENT,
  `dataatual` date NOT NULL,
  `valorinicial` decimal(10,2) DEFAULT NULL,
  `valorfinal` decimal(10,2) DEFAULT NULL,
  `saldo` decimal(10,2) DEFAULT NULL,
  `estado` varchar(45) NOT NULL,
  PRIMARY KEY (`idcaixa`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `caixa`
--

/*!40000 ALTER TABLE `caixa` DISABLE KEYS */;
INSERT INTO `caixa` (`idcaixa`,`dataatual`,`valorinicial`,`valorfinal`,`saldo`,`estado`) VALUES 
 (1,'2010-08-04','6.00','46.00','40.00','FECHADO'),
 (2,'2010-08-05','26.00','26.00','0.00','FECHADO'),
 (3,'2010-08-06','42.00','42.00','0.00','ABERTO');
/*!40000 ALTER TABLE `caixa` ENABLE KEYS */;


--
-- Definition of table `caixa_entrada`
--

DROP TABLE IF EXISTS `caixa_entrada`;
CREATE TABLE `caixa_entrada` (
  `identrada` int(11) NOT NULL,
  `idcaixa` int(11) NOT NULL,
  `data` datetime NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `obs` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`identrada`,`idcaixa`),
  KEY `FK_caixa_entrada_1` (`idcaixa`),
  CONSTRAINT `FK_caixa_entrada_1` FOREIGN KEY (`idcaixa`) REFERENCES `caixa` (`idcaixa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `caixa_entrada`
--

/*!40000 ALTER TABLE `caixa_entrada` DISABLE KEYS */;
INSERT INTO `caixa_entrada` (`identrada`,`idcaixa`,`data`,`valor`,`usuario`,`obs`) VALUES 
 (1,1,'2010-08-04 15:11:51','40.00','RAIZA','LANCAMENTO MANUAL, STEFANI PAGOU');
/*!40000 ALTER TABLE `caixa_entrada` ENABLE KEYS */;


--
-- Definition of trigger `trg_saldo_caixa`
--

DROP TRIGGER /*!50030 IF EXISTS */ `trg_saldo_caixa`;

DELIMITER $$

CREATE DEFINER = `root`@`localhost` TRIGGER `trg_saldo_caixa` AFTER INSERT ON `caixa_entrada` FOR EACH ROW BEGIN
  UPDATE caixa
  SET valorfinal = valorfinal + NEW.valor, saldo = saldo + NEW.valor
  WHERE idcaixa = NEW.idcaixa;
END $$

DELIMITER ;

--
-- Definition of table `caixa_saida`
--

DROP TABLE IF EXISTS `caixa_saida`;
CREATE TABLE `caixa_saida` (
  `idsaida` int(11) NOT NULL,
  `idcaixa` int(11) NOT NULL,
  `data` datetime NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `obs` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`idsaida`,`idcaixa`),
  KEY `FK_caixa_saida_1` (`idcaixa`),
  CONSTRAINT `FK_caixa_saida_1` FOREIGN KEY (`idcaixa`) REFERENCES `caixa` (`idcaixa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `caixa_saida`
--

/*!40000 ALTER TABLE `caixa_saida` DISABLE KEYS */;
/*!40000 ALTER TABLE `caixa_saida` ENABLE KEYS */;


--
-- Definition of trigger `trg_saldo_caixa2`
--

DROP TRIGGER /*!50030 IF EXISTS */ `trg_saldo_caixa2`;

DELIMITER $$

CREATE DEFINER = `root`@`localhost` TRIGGER `trg_saldo_caixa2` AFTER INSERT ON `caixa_saida` FOR EACH ROW BEGIN
  UPDATE caixa
  SET valorfinal = valorfinal - NEW.valor, saldo = saldo - NEW.valor
  WHERE idcaixa = NEW.idcaixa;
END $$

DELIMITER ;

--
-- Definition of table `cliente_debito`
--

DROP TABLE IF EXISTS `cliente_debito`;
CREATE TABLE `cliente_debito` (
  `idvenda` int(11) NOT NULL,
  `idparcela` int(11) NOT NULL,
  `dtvencimento` date NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `idcliente` int(11) DEFAULT NULL,
  `prazo` int(11) DEFAULT NULL,
  `estado` varchar(45) NOT NULL,
  `obs` varchar(300) NOT NULL,
  `juros` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`idvenda`,`idparcela`),
  KEY `FK_cliente_debito_2` (`idcliente`),
  CONSTRAINT `FK_cliente_debito_1` FOREIGN KEY (`idvenda`, `idparcela`) REFERENCES `venda_parcela` (`idvenda`, `idparcela`),
  CONSTRAINT `FK_cliente_debito_2` FOREIGN KEY (`idcliente`) REFERENCES `clientes` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cliente_debito`
--

/*!40000 ALTER TABLE `cliente_debito` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente_debito` ENABLE KEYS */;


--
-- Definition of table `cliente_pagamento`
--

DROP TABLE IF EXISTS `cliente_pagamento`;
CREATE TABLE `cliente_pagamento` (
  `idpagamento` int(11) NOT NULL AUTO_INCREMENT,
  `idvenda` int(11) NOT NULL,
  `idparcela` int(11) NOT NULL,
  `valor_pagto` decimal(10,2) NOT NULL,
  `data_pagto` datetime NOT NULL,
  `obs` varchar(300) NOT NULL,
  `idcliente` int(11) DEFAULT NULL,
  `idfinalizadora` int(11) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  PRIMARY KEY (`idpagamento`),
  KEY `FK_cliente_pagamento_1` (`idcliente`),
  KEY `FK_cliente_pagamento_2` (`idvenda`,`idparcela`),
  KEY `FK_cliente_pagamento_3` (`idfinalizadora`),
  CONSTRAINT `FK_cliente_pagamento_1` FOREIGN KEY (`idcliente`) REFERENCES `clientes` (`id`),
  CONSTRAINT `FK_cliente_pagamento_2` FOREIGN KEY (`idvenda`, `idparcela`) REFERENCES `venda_parcela` (`idvenda`, `idparcela`),
  CONSTRAINT `FK_cliente_pagamento_3` FOREIGN KEY (`idfinalizadora`) REFERENCES `finalizadoras` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cliente_pagamento`
--

/*!40000 ALTER TABLE `cliente_pagamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente_pagamento` ENABLE KEYS */;


--
-- Definition of table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cep` varchar(9) DEFAULT NULL,
  `logradouro` varchar(45) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `telefone1` varchar(13) DEFAULT NULL,
  `ramal1` varchar(10) DEFAULT NULL,
  `telefone2` varchar(13) DEFAULT NULL,
  `ramal2` varchar(10) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `PessoaFisica_cpf` varchar(15) DEFAULT NULL,
  `PessoaJuridica_cnpj` varchar(18) DEFAULT NULL,
  `obs` varchar(200) DEFAULT NULL,
  `c_status` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Clientes_PessoaFisica1` (`PessoaFisica_cpf`),
  KEY `fk_Clientes_PessoaJuridica1` (`PessoaJuridica_cnpj`),
  CONSTRAINT `fk_Clientes_PessoaFisica1` FOREIGN KEY (`PessoaFisica_cpf`) REFERENCES `pessoafisica` (`cpf`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_Clientes_PessoaJuridica1` FOREIGN KEY (`PessoaJuridica_cnpj`) REFERENCES `pessoajuridica` (`cnpj`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clientes`
--

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`id`,`cep`,`logradouro`,`numero`,`bairro`,`cidade`,`estado`,`telefone1`,`ramal1`,`telefone2`,`ramal2`,`email`,`PessoaFisica_cpf`,`PessoaJuridica_cnpj`,`obs`,`c_status`) VALUES 
 (1,'     -','TRAVESSA SAO DOMINGOS','285','MORRO DO ALGODAO','CARAGUATATUBA','SP','(12)3887-7493','','(12)9795-7186','','','257.334.538-69',NULL,'','ATIVO'),
 (2,'     -','RUA GUARUJA','74','PEREQUE MIRIM','CARAGUATATUBA','SP','(  )9153-3625','','(  )    -','','','387.023.018-57',NULL,'','ATIVO'),
 (3,'     -','AVENIDA GUILHERME DE ALMEIDA ','1125','MORRO DO ALGODAO ','CARAGUATATUBA','SP','(  )    -','','(  )    -','','marina_conc@hotmail.com','714.749.016-97',NULL,'','ATIVO'),
 (4,'11671-000','RUA EDSON DOS SANTOS ','10','MORRO DO ALGODAO ','CARAGUATATUBA ','SP','(12)3888-4601','','(12)8133-9669','','patricia-iorio@hotmail.com','248.938.568-20',NULL,'','ATIVO'),
 (5,'11671-210','RUA JOSE MARQUE CASIMIRO DE ABREU','24','MORRO DO ALGODAO','CARAGUATATUBA ','SP','(12)9194-9438','','(  )    -','','evelyn1.8','368.594.778-81',NULL,'','ATIVO');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;


--
-- Definition of table `cod_barras`
--

DROP TABLE IF EXISTS `cod_barras`;
CREATE TABLE `cod_barras` (
  `ean13` varchar(13) NOT NULL DEFAULT '',
  `idproduto` int(11) NOT NULL,
  `embalagem` varchar(10) DEFAULT NULL,
  `unidade` int(11) DEFAULT NULL,
  PRIMARY KEY (`ean13`),
  KEY `cod_barras_ibfk_1` (`idproduto`),
  CONSTRAINT `cod_barras_ibfk_1` FOREIGN KEY (`idproduto`) REFERENCES `produtos` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cod_barras`
--

/*!40000 ALTER TABLE `cod_barras` DISABLE KEYS */;
/*!40000 ALTER TABLE `cod_barras` ENABLE KEYS */;


--
-- Definition of table `finalizadoras`
--

DROP TABLE IF EXISTS `finalizadoras`;
CREATE TABLE `finalizadoras` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `finalizadoras`
--

/*!40000 ALTER TABLE `finalizadoras` DISABLE KEYS */;
INSERT INTO `finalizadoras` (`id`,`descricao`) VALUES 
 (1,'DINHEIRO'),
 (2,'CHEQUE'),
 (3,'CARTAO');
/*!40000 ALTER TABLE `finalizadoras` ENABLE KEYS */;


--
-- Definition of table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
CREATE TABLE `fornecedor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `razaosocial` varchar(50) DEFAULT NULL,
  `nomefantasia` varchar(50) DEFAULT NULL,
  `cnpj` varchar(18) DEFAULT NULL,
  `ie` varchar(15) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `logradouro` varchar(50) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `telefone1` varchar(13) DEFAULT NULL,
  `ramal1` varchar(10) DEFAULT NULL,
  `telefone2` varchar(13) DEFAULT NULL,
  `ramal2` varchar(10) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `obs` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fornecedor`
--

/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` (`id`,`razaosocial`,`nomefantasia`,`cnpj`,`ie`,`cep`,`logradouro`,`numero`,`bairro`,`cidade`,`estado`,`telefone1`,`ramal1`,`telefone2`,`ramal2`,`email`,`obs`) VALUES 
 (1,'NEW CAT ATACADOS','NEW CAT ','57.973.182/0001-02','','     -','','','','','','(  )    -','','(  )    -','','','');
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;


--
-- Definition of table `funcao`
--

DROP TABLE IF EXISTS `funcao`;
CREATE TABLE `funcao` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `funcao`
--

/*!40000 ALTER TABLE `funcao` DISABLE KEYS */;
/*!40000 ALTER TABLE `funcao` ENABLE KEYS */;


--
-- Definition of table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE `funcionario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `cpf` varchar(15) DEFAULT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `logradouro` varchar(45) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `datanasc` date DEFAULT NULL,
  `dataadmi` date DEFAULT NULL,
  `salario` decimal(10,2) DEFAULT NULL,
  `telefone` varchar(13) DEFAULT NULL,
  `celular` varchar(13) DEFAULT NULL,
  `idFuncao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idFuncao` (`idFuncao`),
  CONSTRAINT `mecanico_ibfk_1` FOREIGN KEY (`idFuncao`) REFERENCES `funcao` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `funcionario`
--

/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;


--
-- Definition of table `mov_estoque`
--

DROP TABLE IF EXISTS `mov_estoque`;
CREATE TABLE `mov_estoque` (
  `idMov` int(11) NOT NULL AUTO_INCREMENT,
  `descricaoMov` varchar(200) DEFAULT NULL,
  `tipoMov` varchar(50) NOT NULL,
  `qtdeMov` int(11) NOT NULL,
  `dataMov` datetime NOT NULL,
  `usuarioMov` varchar(50) NOT NULL,
  `idProduto` int(11) NOT NULL,
  PRIMARY KEY (`idMov`),
  KEY `idProduto` (`idProduto`),
  CONSTRAINT `mov_estoque_ibfk_1` FOREIGN KEY (`idProduto`) REFERENCES `produtos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mov_estoque`
--

/*!40000 ALTER TABLE `mov_estoque` DISABLE KEYS */;
INSERT INTO `mov_estoque` (`idMov`,`descricaoMov`,`tipoMov`,`qtdeMov`,`dataMov`,`usuarioMov`,`idProduto`) VALUES 
 (1,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 10:58:20','ALEXANDER',1),
 (2,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',2,'2010-08-03 13:40:49','ALEXANDER',36),
 (3,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',2,'2010-08-03 13:43:05','ALEXANDER',36),
 (4,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',2,'2010-08-03 13:58:57','ALEXANDER',47),
 (5,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 14:04:09','ALEXANDER',46),
 (6,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 14:12:14','ALEXANDER',36),
 (7,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 14:16:23','ALEXANDER',40),
 (8,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 14:16:41','ALEXANDER',47),
 (9,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 14:20:19','ALEXANDER',40),
 (10,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',2,'2010-08-03 14:20:30','ALEXANDER',39),
 (11,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 14:34:39','ALEXANDER',44),
 (12,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 14:47:02','ALEXANDER',45),
 (13,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',2,'2010-08-03 15:02:55','ALEXANDER',1),
 (14,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 15:06:56','ALEXANDER',14),
 (15,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',3,'2010-08-03 15:07:39','ALEXANDER',32),
 (16,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 15:08:53','ALEXANDER',3),
 (17,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-03 17:09:04','RAIZA',1),
 (18,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-04 09:57:17','RAIZA',68),
 (19,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-04 09:57:18','RAIZA',68),
 (20,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-04 09:57:19','RAIZA',68),
 (21,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-04 09:57:20','RAIZA',51),
 (22,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',5,'2010-08-04 10:39:47','RAIZA',100),
 (23,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',1,'2010-08-04 10:59:18','RAIZA',121),
 (24,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',3,'2010-08-04 11:28:37','RAIZA',111),
 (25,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',14,'2010-08-05 17:20:51','ALEXANDER',1),
 (26,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',4,'2010-08-05 17:21:05','ALEXANDER',2),
 (27,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',2,'2010-08-05 17:21:15','ALEXANDER',6),
 (28,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',15,'2010-08-06 09:32:13','ALEXANDER',70),
 (29,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',6,'2010-08-06 09:32:51','ALEXANDER',15),
 (30,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',13,'2010-08-06 09:56:45','ALEXANDER',178),
 (31,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',5,'2010-08-06 09:57:10','ALEXANDER',185),
 (32,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',4,'2010-08-06 15:29:27','ALEXANDER',8),
 (33,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',4,'2010-08-06 17:14:51','ALEXANDER',70),
 (34,'AJUSTE MANUAL - POSITIVO, ','POSITIVO',16,'2010-08-09 10:48:55','RAIZA',21);
/*!40000 ALTER TABLE `mov_estoque` ENABLE KEYS */;


--
-- Definition of table `pessoafisica`
--

DROP TABLE IF EXISTS `pessoafisica`;
CREATE TABLE `pessoafisica` (
  `cpf` varchar(15) NOT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `apelido` varchar(50) DEFAULT NULL,
  `datanasc` date DEFAULT NULL,
  `nomepai` varchar(50) DEFAULT NULL,
  `nomemae` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pessoafisica`
--

/*!40000 ALTER TABLE `pessoafisica` DISABLE KEYS */;
INSERT INTO `pessoafisica` (`cpf`,`rg`,`nome`,`apelido`,`datanasc`,`nomepai`,`nomemae`) VALUES 
 ('248.938.568-20','250897052','PATRICIA DAMARIS IORIO ','PATTY','1975-11-13','JOSE IORIO ','ANA RITA IORIO '),
 ('257.334.538-69','','LUCY FABIANA','LUCY','1900-01-01','',''),
 ('368.594.778-81','428289344','EVELYN APARECIDA GRANADO DA SILVA ','EVELYN ','1987-09-29','JOSE MOREIRA DA SILVA ','ARLENE GRANADO DA SILVA '),
 ('387.023.018-57','446189017','STEFANI AMARAL COIMBRA','','1989-01-27','',''),
 ('714.749.016-97','','MARINA DA CONCEIÇAO AMARAL','MARINA','1992-09-25','','');
/*!40000 ALTER TABLE `pessoafisica` ENABLE KEYS */;


--
-- Definition of table `pessoajuridica`
--

DROP TABLE IF EXISTS `pessoajuridica`;
CREATE TABLE `pessoajuridica` (
  `cnpj` varchar(18) NOT NULL DEFAULT '',
  `ie` varchar(15) DEFAULT NULL,
  `razaosocial` varchar(50) DEFAULT NULL,
  `nomefantasia` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cnpj`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pessoajuridica`
--

/*!40000 ALTER TABLE `pessoajuridica` DISABLE KEYS */;
/*!40000 ALTER TABLE `pessoajuridica` ENABLE KEYS */;


--
-- Definition of table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) NOT NULL,
  `descricaoresumida` varchar(45) DEFAULT NULL,
  `unidade` int(11) DEFAULT NULL,
  `margemlucro` decimal(10,2) DEFAULT NULL,
  `venda` decimal(10,2) DEFAULT NULL,
  `estoque` int(11) DEFAULT NULL,
  `marca` varchar(40) DEFAULT NULL,
  `idfornecedor` int(11) DEFAULT NULL,
  `estoqueminimo` int(11) DEFAULT NULL,
  `custo` decimal(10,2) DEFAULT NULL,
  `embalagem` varchar(10) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `estado_estoque` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_produtos_1` (`idfornecedor`),
  CONSTRAINT `FK_produtos_1` FOREIGN KEY (`idfornecedor`) REFERENCES `fornecedor` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=224 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produtos`
--

/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`id`,`descricao`,`descricaoresumida`,`unidade`,`margemlucro`,`venda`,`estoque`,`marca`,`idfornecedor`,`estoqueminimo`,`custo`,`embalagem`,`estado`,`estado_estoque`) VALUES 
 (1,'BLUSINHA MULTIMARCAS - 01','',1,'100.00','45.00',42,'',1,5,'25.00','UN','EM LINHA','DISPONIVEL'),
 (2,'BLUSINHA MULTIMARCAS -02','',1,'100.00','35.00',96,'',1,5,'25.00','UN','EM LINHA','DISPONIVEL'),
 (3,'CAMISA MASCULINA','',1,'100.00','25.00',33,'',1,5,'15.00','UN','EM LINHA','DISPONIVEL'),
 (4,'CAMISETA REGATA','',1,'100.00','20.00',25,'',1,3,'15.00','UN','EM LINHA','DISPONIVEL'),
 (5,'BLUSA FRIO MASCULINA INFANTIL ','',1,'100.00','70.00',6,'',1,3,'40.00','UN','EM LINHA','DISPONIVEL'),
 (6,'CAMISA POLO MASCULINA ','',1,'100.00','45.00',11,'',1,3,'15.00','UN','EM LINHA','DISPONIVEL'),
 (7,'BERMUDA SOCIAL ELASTICO ','',1,'100.00','35.00',4,'',1,1,'15.00','UN','EM LINHA','DISPONIVEL'),
 (8,'BLUSINHA TAMANHO ESPECIAL -01','',1,'100.00','35.00',12,'',1,3,'20.00','UN','EM LINHA','DISPONIVEL'),
 (9,'BLUSINHA TAMANHO ESPECIAL- 02','',1,'100.00','45.00',3,'',1,2,'20.00','UN','EM LINHA','DISPONIVEL'),
 (10,'TOALHA DE BANHO ','',1,'100.00','10.00',13,'',1,3,'5.00','UN','EM LINHA','DISPONIVEL'),
 (11,'CACHICOL','',1,'100.00','15.00',7,'',1,2,'5.00','UN','EM LINHA','DISPONIVEL'),
 (12,'CAPRI JEANS FEMININA','',1,'100.00','68.00',25,'',1,3,'30.00','UN','EM LINHA','DISPONIVEL'),
 (13,'LEGGIN - 01','',1,'100.00','35.00',23,'',1,5,'15.00','UN','EM LINHA','DISPONIVEL'),
 (14,'LEGGIN -02','',1,'100.00','22.00',9,'',1,3,'11.00','UN','EM LINHA','DISPONIVEL'),
 (15,'CALCA JEANS MASCULINA -01','',1,'100.00','78.00',9,'',1,1,'40.00','UN','EM LINHA','DISPONIVEL'),
 (16,'CALCA JEANS MASCULINA -02','',1,'100.00','55.00',9,'',1,2,'30.00','UN','EM LINHA','DISPONIVEL'),
 (17,'VESTIDOS -01','',1,'100.00','68.00',21,'',1,2,'30.00','UN','EM LINHA','DISPONIVEL'),
 (18,'VESTIDOS - 02','',1,'100.00','35.00',7,'',1,2,'15.00','UN','EM LINHA','DISPONIVEL'),
 (19,'CACHARREL FEMININA ','',1,'100.00','25.00',15,'',1,2,'15.00','UN','EM LINHA','DISPONIVEL'),
 (20,'MACACAO JEANS FEMININO ','',1,'100.00','68.00',3,'',1,1,'30.00','UN','EM LINHA','DISPONIVEL'),
 (21,'SAIA JEANS JOYALY','',1,'100.00','86.00',19,'',1,1,'40.00','UN','EM LINHA','DISPONIVEL'),
 (22,'SAIA JEANS OUTRAS ','',1,'100.00','55.00',8,'',1,2,'25.00','UN','EM LINHA','DISPONIVEL'),
 (23,'TOALHA DE ROSTO ','',1,'100.00','5.00',10,'',1,2,'2.50','UN','EM LINHA','DISPONIVEL'),
 (24,'CONTROLE TV MULTIMARCAS','',1,'100.00','15.00',81,'',1,5,'8.00','UN','EM LINHA','DISPONIVEL'),
 (25,'BIQUINIS','',1,'100.00','35.00',66,'',1,5,'15.00','UN','EM LINHA','DISPONIVEL'),
 (26,'CUECAS ADULTOS','',1,'100.00','12.00',22,'',1,3,'4.50','UN','EM LINHA','DISPONIVEL'),
 (27,'SUNGAS ADULTO','',1,'100.00','22.00',11,'',1,5,'11.00','UN','EM LINHA','DISPONIVEL'),
 (28,'SUNGA INFANTIL','',1,'100.00','18.00',23,'',1,5,'7.00','UN','EM LINHA','DISPONIVEL'),
 (29,'SUTIENS','',1,'100.00','13.00',26,'',1,5,'6.00','UN','EM LINHA','DISPONIVEL'),
 (30,'CONJUNTO SUTIEN E CALCINHA','',1,'100.00','30.00',45,'',1,5,'15.00','UN','EM LINHA','DISPONIVEL'),
 (31,'CALCINHAS','',1,'100.00','9.90',106,'',1,5,'4.00','UN','EM LINHA','DISPONIVEL'),
 (32,'BERMUDA MASCULINA','',1,'100.00','25.00',82,'',1,10,'12.50','UN','EM LINHA','DISPONIVEL'),
 (33,'BERMUDA SIMPLES DE ELASTICO,','',1,'100.00','20.00',7,'',1,3,'10.00','UN','EM LINHA','DISPONIVEL'),
 (34,'CAMISA DE TIMES','',1,'100.00','20.00',49,'',1,5,'10.00','UN','EM LINHA','DISPONIVEL'),
 (35,'CAMISA DE TIME INFANTIL','',1,'100.00','10.00',5,'',1,3,'5.00','UN','EM LINHA','DISPONIVEL'),
 (36,'CONJUNTO DE TIME INFANTIL','',1,'100.00','32.00',7,'',1,1,'20.00','UN','EM LINHA','DISPONIVEL'),
 (37,'CALÇA DE TIME ADULTO','',1,'100.00','25.00',1,'',1,1,'10.00','UN','EM LINHA','MINIMO'),
 (38,'SHORT DE TIME ADULTO','',1,'0.00','25.00',3,'',1,1,'10.00','UN','EM LINHA','DISPONIVEL'),
 (39,'REGATA INFANTIL','',1,'100.00','13.00',15,'',1,2,'6.00','UN','EM LINHA','DISPONIVEL'),
 (40,'CAMISA INFANTIL','',1,'100.00','16.00',5,'',1,1,'4.00','UN','EM LINHA','DISPONIVEL'),
 (41,'BERMUDA INFANTIL','',1,'100.00','22.00',28,'',1,1,'11.00','UN','EM LINHA','DISPONIVEL'),
 (42,'CANGA','',1,'100.00','20.00',4,'',1,1,'10.00','UN','EM LINHA','DISPONIVEL'),
 (43,'SHORT SIMPLES INFANTIL','',1,'100.00','16.00',19,'',1,1,'4.00','UN','EM LINHA','DISPONIVEL'),
 (44,'SHORT SIMPLES FEMININO INFANTIL','',1,'100.00','14.00',4,'',1,1,'2.50','UN','EM LINHA','DISPONIVEL'),
 (45,'SAIA SIMLPES FEMININA INFANTIL ','',1,'100.00','13.00',4,'',1,1,'6.00','UN','EM LINHA','DISPONIVEL'),
 (46,'BLUSINHAS MULTIMARCAS INFANTIL-01','',1,'100.00','26.00',5,'',1,1,'16.00','UN','EM LINHA','DISPONIVEL'),
 (47,'BLUSINHA MULTIMARCAS INFANTIL-02','',1,'100.00','16.00',12,'',1,1,'6.00','UN','EM LINHA','DISPONIVEL'),
 (48,'BLUSINHA PERFUME DE BONECA ','',1,'100.00','32.00',1,'',1,1,'16.00','UN','EM LINHA','MINIMO'),
 (49,'CACHARREL INFANTIL','',1,'100.00','22.00',1,'',1,1,'11.00','UN','EM LINHA','MINIMO'),
 (50,'LEGGIN INFANTIL ','',1,'100.00','16.00',1,'',1,1,'4.00','UN','EM LINHA','MINIMO'),
 (51,'BLUSA DE FRIO ROSA INFANTIL','',1,'100.00','32.00',2,'',1,1,'18.00','UN','EM LINHA','DISPONIVEL'),
 (52,'CONJUNTO INFANTIL MASCULINO-01','',1,'100.00','35.00',33,'',1,10,'17.00','UN','EM LINHA','DISPONIVEL'),
 (53,'CONJUNTO MASCULINO INFANTIL KARO LINES-02','',1,'100.00','16.00',15,'',1,5,'7.00','UN','EM LINHA','DISPONIVEL'),
 (54,'PAGAO INFANTIL','',1,'100.00','35.00',8,'',1,3,'15.00','UN','EM LINHA','DISPONIVEL'),
 (55,'VESTIDO INFANTIL','',1,'100.00','35.00',5,'',1,2,'15.00','UN','EM LINHA','DISPONIVEL'),
 (56,'CAMISA SOCIAL INFANTIL ','',1,'100.00','28.00',1,'',1,1,'12.00','UN','EM LINHA','MINIMO'),
 (57,'BERMUDA RAMABI','',1,'100.00','28.00',1,'',1,1,'12.00','UN','EM LINHA','MINIMO'),
 (58,'CONJUNTO DE FRIO MASCULINO','',1,'100.00','29.90',8,'',1,5,'12.00','UN','EM LINHA','DISPONIVEL'),
 (59,'CONJUNTO INFANTIL FEMININO','',1,'100.00','35.00',33,'',1,10,'15.00','UN','EM LINHA','DISPONIVEL'),
 (60,'CALCA JEANS INFANTIL MASCULINA','',1,'100.00','35.00',1,'',1,1,'15.00','UN','EM LINHA','MINIMO'),
 (61,'SHORTS FEMININO INFANTIL ','',1,'100.00','10.00',8,'',1,2,'5.00','UN','EM LINHA','DISPONIVEL'),
 (62,'SHORTS JEANS FEMININO INFANTIL','',1,'100.00','23.00',5,'',1,1,'10.00','UN','EM LINHA','DISPONIVEL'),
 (63,'CALCA JEANS FEMININA INFANTIL','',1,'100.00','68.00',2,'',1,1,'25.00','UN','EM LINHA','DISPONIVEL'),
 (64,'BERMUDA JEANS INFANTIL FEMININA','',1,'100.00','35.00',1,'',1,1,'15.00','UN','EM LINHA','MINIMO'),
 (65,'CAPRI JEANS INFANTIL FEMININA','',1,'100.00','58.00',1,'',1,1,'25.00','UN','EM LINHA','MINIMO'),
 (66,'SHORT JEANS FEMININO ADULTO ','',1,'100.00','55.00',34,'',1,10,'25.00','UN','EM LINHA','DISPONIVEL'),
 (67,'CONJUNTO DE FRIO INFANTIL FEMININO ','',1,'100.00','29.90',15,'',1,5,'12.00','UN','EM LINHA','DISPONIVEL'),
 (68,'BERMUDA FEMININA BRANCA ADULTO ','',1,'100.00','55.00',12,'',1,3,'25.00','UN','EM LINHA','DISPONIVEL'),
 (69,'SAIA LISA','',1,'100.00','35.00',26,'',1,5,'14.00','UN','EM LINHA','DISPONIVEL'),
 (70,'CALCA JEANS FEMININA ADULTO ','',1,'100.00','78.00',41,'',1,5,'35.00','UN','EM LINHA','DISPONIVEL'),
 (71,'BLUSA DE FRIO MASCULINA ADULTO -01','',1,'100.00','89.00',9,'',1,4,'30.00','UN','EM LINHA','DISPONIVEL'),
 (72,'BLUSA DE FRIO MASCULINA ADULTO-02','',1,'100.00','68.00',4,'',1,2,'30.00','UN','EM LINHA','DISPONIVEL'),
 (73,'BLUSA DE FRIO FEMININA-01','',1,'100.00','58.00',7,'',1,3,'20.00','UN','EM LINHA','DISPONIVEL'),
 (74,'BLUSA FRIO FEMININA-02','',1,'100.00','78.00',5,'',1,3,'35.00','UN','EM LINHA','DISPONIVEL'),
 (75,'SAIA JEANS CURTA','',1,'100.00','55.00',5,'',1,3,'20.00','UN','EM LINHA','DISPONIVEL'),
 (76,'MEIA CALÇA LISA','',1,'100.00','26.00',7,'',1,2,'12.00','UN','EM LINHA','DISPONIVEL'),
 (77,'MEIA CALCA DANIELA','',1,'100.00','23.00',1,'',1,1,'10.00','UN','EM LINHA','MINIMO'),
 (78,'MEIA CALCA KINGSPEARL','',1,'100.00','36.00',2,'',1,1,'12.00','UN','EM LINHA','DISPONIVEL'),
 (79,'MEIA CALCA TRIFIL ','',1,'100.00','48.00',0,'',1,0,'20.00','UN','EM LINHA','MINIMO'),
 (80,'SAIA CINTURA ALTA','',1,'100.00','45.00',3,'',1,1,'20.00','UN','EM LINHA','DISPONIVEL'),
 (81,'CALCA CINTURA ALTA','',1,'100.00','68.00',2,'',1,1,'29.00','UN','EM LINHA','DISPONIVEL'),
 (82,'CALÇA MASCULINA ESPORTE','',1,'100.00','45.00',5,'',1,3,'19.90','UN','EM LINHA','DISPONIVEL'),
 (83,'SHORT FEMININO CINTURA ALTA','',1,'100.00','55.00',2,'',1,1,'25.00','UN','EM LINHA','DISPONIVEL'),
 (84,'SHORT DE COTOON','',1,'100.00','16.00',10,'',1,5,'4.00','UN','EM LINHA','DISPONIVEL'),
 (85,'SHORT TATUI','',1,'100.00','18.00',4,'',1,2,'8.00','UN','EM LINHA','DISPONIVEL'),
 (86,'SHORT DE TECTEL','',1,'100.00','20.00',5,'',1,2,'9.00','UN','EM LINHA','DISPONIVEL'),
 (87,'SHORT RIP GIRLS','',1,'100.00','15.00',3,'',1,1,'12.00','UN','EM LINHA','DISPONIVEL'),
 (88,'SHORT FRAN DANIELS','',1,'100.00','15.00',2,'',1,1,'7.00','UN','EM LINHA','DISPONIVEL'),
 (89,'MEIAS VARIADAS INFANTIL','',1,'100.00','4.50',8,'',1,3,'1.50','UN','EM LINHA','DISPONIVEL'),
 (90,'MEIA CALCA INFANTIL','',1,'100.00','13.00',14,'',1,5,'5.00','UN','EM LINHA','DISPONIVEL'),
 (91,'MEIA ADULTO ','',1,'100.00','5.00',71,'',1,10,'2.00','UN','EM LINHA','DISPONIVEL'),
 (92,'CALCA DE MOLETON ADULTO ','',1,'100.00','68.00',1,'',1,1,'30.00','UN','EM LINHA','MINIMO'),
 (93,'LUVA ADULTO','',1,'100.00','10.00',10,'',1,3,'4.00','UN','EM LINHA','DISPONIVEL'),
 (94,'CACHICOL INFANTIL','',1,'100.00','10.00',1,'',1,1,'5.00','UN','EM LINHA','MINIMO'),
 (95,'CARREGADOR DE BATERIA','',1,'100.00','10.00',7,'',1,3,'5.00','UN','EM LINHA','DISPONIVEL'),
 (96,'PIJAMA ROSA ADULTO','',1,'100.00','28.00',1,'',1,1,'12.00','UN','EM LINHA','MINIMO'),
 (97,'CORPETE','',1,'100.00','35.00',1,'',1,1,'15.00','UN','EM LINHA','MINIMO'),
 (98,'CONTROLE PARA DVD','',1,'100.00','20.00',16,'',1,5,'10.00','UN','EM LINHA','DISPONIVEL'),
 (99,'CARTEIRA','',1,'100.00','16.00',7,'',1,3,'4.00','UN','EM LINHA','DISPONIVEL'),
 (100,'CARREGADOR PARA PILHA','',1,'100.00','15.00',5,'',1,5,'14.00','UN','EM LINHA','MINIMO'),
 (101,'LENCO','',1,'100.00','11.00',2,'',1,1,'5.00','UN','EM LINHA','DISPONIVEL'),
 (102,'CARTEIRA COMUN','',1,'100.00','5.00',3,'',1,1,'1.50','UN','EM LINHA','DISPONIVEL'),
 (103,'CINTO MASCULINO','',1,'100.00','6.00',2,'',1,1,'2.50','UN','EM LINHA','DISPONIVEL'),
 (104,'TIARA DE CABELO INFANTIL','',1,'100.00','2.00',1,'',1,1,'1.00','UN','EM LINHA','MINIMO'),
 (105,'ESTOJO PARA MAQUINA','',1,'100.00','20.00',2,'',1,1,'10.00','UN','EM LINHA','DISPONIVEL'),
 (106,'BOTA FEMININA','',1,'100.00','68.00',2,'',1,1,'30.00','UN','EM LINHA','DISPONIVEL'),
 (107,'SANDALIA ELEGANCI','',1,'100.00','26.00',8,'',1,3,'12.00','UN','EM LINHA','DISPONIVEL'),
 (108,'SANDALIA LUXUOSA','',1,'100.00','20.00',10,'',1,5,'10.00','UN','EM LINHA','DISPONIVEL'),
 (109,'SANDALIA INFANTIL SCALENO','',1,'100.00','28.00',4,'',1,2,'12.00','UN','EM LINHA','DISPONIVEL'),
 (110,'TENIS MASCULINO ','',1,'100.00','68.00',2,'',1,1,'30.00','UN','EM LINHA','DISPONIVEL'),
 (111,'CINTO SOCIAL MASCULINO','',1,'100.00','12.00',6,'',1,1,'5.00','UN','EM LINHA','DISPONIVEL'),
 (112,'CINTO INFANTIL','',1,'100.00','5.00',6,'',1,2,'2.00','UN','EM LINHA','DISPONIVEL'),
 (113,'CINTO FEMININO','',1,'100.00','15.00',2,'',1,1,'12.00','UN','EM LINHA','DISPONIVEL'),
 (114,'PRANCHA DE SURF PEQUENA','',1,'100.00','25.00',1,'',1,1,'12.00','UN','EM LINHA','MINIMO'),
 (115,'PRANCHA DE SURF MEDIA','',1,'100.00','35.00',1,'',1,1,'16.00','UN','EM LINHA','MINIMO'),
 (116,'PRANCHA DE SURF GRANDE','',1,'100.00','45.00',1,'',1,1,'20.00','UN','EM LINHA','MINIMO'),
 (117,'BONECA NICKI','',1,'100.00','28.00',1,'',1,1,'12.00','UN','EM LINHA','MINIMO'),
 (118,'BOLA DE PRAIA','',1,'100.00','4.00',2,'',1,1,'2.00','UN','EM LINHA','DISPONIVEL'),
 (119,'BOLA FUTEBOL DE PRAIA','',1,'100.00','2.00',2,'',1,1,'1.00','UN','EM LINHA','DISPONIVEL'),
 (120,'BONECA NANINHA','',1,'100.00','16.00',1,'',1,1,'4.00','UN','EM LINHA','MINIMO'),
 (121,'TRATOR AGROTURBO','',1,'100.00','18.00',1,'',1,0,'8.00','UN','EM LINHA','DISPONIVEL'),
 (122,'BONECA BEATRIZ','',1,'100.00','18.00',2,'',1,1,'7.00','UN','EM LINHA','DISPONIVEL'),
 (123,'BONECO KEVIN ','',1,'100.00','18.00',1,'',1,1,'7.00','UN','EM LINHA','MINIMO'),
 (124,'BONECA ANAIZA','',1,'100.00','89.00',2,'',1,1,'40.00','UN','EM LINHA','DISPONIVEL'),
 (125,'CHINELOS','',1,'100.00','10.00',81,'',1,10,'5.00','UN','EM LINHA','DISPONIVEL'),
 (126,'FONE PARA COMPUTADOR','',1,'100.00','35.00',4,'',1,1,'16.00','UN','EM LINHA','DISPONIVEL'),
 (127,'RAQUETE FRESCOLBOL','',1,'100.00','12.00',2,'',1,1,'4.00','UN','EM LINHA','DISPONIVEL'),
 (128,'ALARME ','',1,'100.00','28.00',3,'',1,1,'12.00','UN','EM LINHA','DISPONIVEL'),
 (129,'BONECO EXERCITO','',1,'100.00','9.90',1,'',1,1,'4.00','UN','EM LINHA','MINIMO'),
 (130,'BONECO FAZENDA','',1,'100.00','9.90',1,'',1,1,'4.00','UN','EM LINHA','MINIMO'),
 (131,'BLUETOOTH PARA CELULAR','',1,'100.00','20.00',2,'',1,1,'10.00','UN','EM LINHA','DISPONIVEL'),
 (132,'RELOGIO DE PAREDE','',1,'100.00','23.00',3,'',1,1,'11.00','UN','EM LINHA','DISPONIVEL'),
 (133,'RASTERINHA','',1,'100.00','15.00',5,'',1,3,'7.00','UN','EM LINHA','DISPONIVEL'),
 (134,'DESODORANTE ROLOOM','',1,'100.00','5.00',5,'',1,2,'2.50','UN','EM LINHA','DISPONIVEL'),
 (135,'DEO COLONIA','',1,'100.00','15.00',2,'',1,2,'6.00','UN','EM LINHA','MINIMO'),
 (136,'CELULAR DE BRINQUEDO ','',1,'100.00','9.90',3,'',1,2,'4.00','UN','EM LINHA','DISPONIVEL'),
 (137,'CESTO DE ROUPA','',1,'100.00','8.00',4,'',1,2,'3.00','UN','EM LINHA','DISPONIVEL'),
 (138,'BOLINHA DE AGUA ','',1,'100.00','2.00',27,'',1,5,'0.50','UN','EM LINHA','DISPONIVEL'),
 (139,'BOIA DE PRAIA','',1,'100.00','10.00',1,'',1,1,'5.00','UN','EM LINHA','MINIMO'),
 (140,'MEMORY CARD PARA PLAY 2','',1,'100.00','35.00',1,'',1,1,'16.00','UN','EM LINHA','MINIMO'),
 (141,'BARBANTE ','',1,'100.00','3.00',1,'',1,1,'1.50','UN','EM LINHA','MINIMO'),
 (142,'RADIO','',1,'100.00','20.00',1,'',1,1,'10.00','UN','EM LINHA','MINIMO'),
 (143,'FICHARIO','',1,'100.00','10.00',1,'',1,1,'5.00','UN','EM LINHA','MINIMO'),
 (144,'BOLINHAS EXOTICAS','',1,'100.00','10.00',10,'',1,5,'5.00','UN','EM LINHA','DISPONIVEL'),
 (145,'CREME PARA O  CORPO EXOTICO','',1,'100.00','12.00',2,'',1,1,'6.00','UN','EM LINHA','DISPONIVEL'),
 (146,'FITA METRICA','',1,'100.00','2.00',8,'',1,4,'1.00','UN','EM LINHA','DISPONIVEL'),
 (147,'KIT MUSICAL INFNATIL','',1,'100.00','12.00',1,'',1,1,'6.00','UN','EM LINHA','MINIMO'),
 (148,'PORTA OCULOS PARA CARRO','',1,'100.00','6.00',3,'',1,1,'2.00','UN','EM LINHA','DISPONIVEL'),
 (149,'KIT PARA BANHO','',1,'100.00','12.00',1,'',1,1,'6.00','UN','EM LINHA','MINIMO'),
 (150,'TACA DE TIMES','',1,'100.00','10.00',4,'',1,2,'10.00','UN','EM LINHA','DISPONIVEL'),
 (151,'MAQUIAGEM INFANTIL','',1,'100.00','8.00',1,'',1,1,'4.00','UN','EM LINHA','MINIMO'),
 (152,'MUNHEQUEIRA','',1,'100.00','5.00',3,'',1,1,'2.50','UN','EM LINHA','DISPONIVEL'),
 (153,'SOMBRINHA','',1,'100.00','10.00',5,'',1,1,'5.00','UN','EM LINHA','DISPONIVEL'),
 (154,'CARRINHO GRXR','',1,'100.00','18.00',1,'',1,1,'6.00','UN','EM LINHA','MINIMO'),
 (155,'CONTROLE USB','',1,'100.00','35.00',5,'',1,2,'15.00','UN','EM LINHA','DISPONIVEL'),
 (156,'ENFEITE DE NATAL ','',1,'100.00','28.00',1,'',1,1,'12.00','UN','EM LINHA','MINIMO'),
 (157,'BINOCULOS','',1,'100.00','35.00',2,'',1,2,'12.00','UN','EM LINHA','MINIMO'),
 (158,'BOLINHAS DE PING PONG','',1,'100.00','1.00',23,'',1,5,'0.50','UN','EM LINHA','DISPONIVEL'),
 (159,'PEAO','',1,'100.00','1.50',4,'',1,2,'0.50','UN','EM LINHA','DISPONIVEL'),
 (160,'RASTELO PARA PRAIA INFANTIL','',1,'100.00','10.00',2,'',1,1,'5.00','UN','EM LINHA','DISPONIVEL'),
 (161,'RELOGIO DESPERTADOR AZUL','',1,'100.00','26.00',1,'',1,1,'12.00','UN','EM LINHA','MINIMO'),
 (162,'PORTA CD','',1,'100.00','10.00',4,'',1,2,'5.00','UN','EM LINHA','DISPONIVEL'),
 (163,'CHAVEIRO FLEX','',1,'100.00','4.00',10,'',1,4,'2.00','UN','EM LINHA','DISPONIVEL'),
 (164,'MOCHILA INFANTIL','',1,'100.00','10.00',3,'',1,1,'5.00','UN','EM LINHA','DISPONIVEL'),
 (165,'BOMBINHA','',1,'100.00','1.00',3,'',1,1,'0.50','UN','EM LINHA','DISPONIVEL'),
 (166,'FUTURE GAME ','',1,'100.00','9.90',4,'',1,2,'4.00','UN','EM LINHA','DISPONIVEL'),
 (167,'CHIP DE MEMORIA ','',1,'100.00','58.00',3,'',1,1,'28.00','UN','EM LINHA','DISPONIVEL'),
 (168,'BOLSA DE MAO ANIMOB','',1,'100.00','6.00',4,'',1,1,'3.00','UN','EM LINHA','DISPONIVEL'),
 (169,'ISCA PARA PEIXE','',1,'10.00','12.00',1,'',1,1,'6.00','UN','EM LINHA','MINIMO'),
 (170,'MOCHILA','',1,'100.00','25.00',4,'',1,1,'12.00','UN','EM LINHA','DISPONIVEL'),
 (171,'BANDEIRA DO BRASIL PARA CARRO','',1,'100.00','5.00',11,'',1,4,'2.50','UN','EM LINHA','DISPONIVEL'),
 (172,'MOUSE DE CARRO','',1,'100.00','12.00',1,'',1,1,'6.00','UN','EM LINHA','MINIMO'),
 (173,'LENCO DO BRASIL','',1,'100.00','6.00',7,'',1,1,'3.00','UN','EM LINHA','DISPONIVEL'),
 (174,'POMPOM DE CABELO DO BRASIL','',1,'100.00','2.00',2,'',1,2,'1.00','UN','EM LINHA','MINIMO'),
 (175,'COLARES','',1,'100.00','10.00',4,'',1,2,'5.00','UN','EM LINHA','DISPONIVEL'),
 (176,'BOLSAS FEMININAS','',1,'100.00','25.00',3,'',1,2,'12.00','UN','EM LINHA','DISPONIVEL'),
 (177,'BOLA TEMA INFANTIS','',1,'100.00','28.00',2,'',1,2,'12.00','UN','EM LINHA','MINIMO'),
 (178,'BONE','',1,'100.00','10.00',35,'',1,10,'5.00','UN','EM LINHA','DISPONIVEL'),
 (179,'BALDE DE PRAIA INFANTIL','',1,'100.00','9.90',4,'',1,2,'4.00','UN','EM LINHA','DISPONIVEL'),
 (180,'PAPETE PIMPOLHO','',1,'100.00','35.00',2,'',1,2,'16.00','UN','EM LINHA','MINIMO'),
 (181,'SAPATILHA ADULTO FUME','',1,'100.00','18.00',2,'',1,2,'6.00','UN','EM LINHA','MINIMO'),
 (182,'SAPATILHA INFANTIL','',1,'100.00','13.00',1,'',1,1,'6.00','UN','EM LINHA','MINIMO'),
 (183,'TENIS INFANTIL ROSA','',1,'100.00','20.00',1,'',1,1,'10.00','UN','EM LINHA','MINIMO'),
 (184,'PORCHETE','',1,'100.00','15.00',5,'',1,3,'7.00','UN','EM LINHA','DISPONIVEL'),
 (185,'TOALHAS VARIOS TEMAS','',1,'100.00','25.00',31,'',1,10,'10.00','UN','EM LINHA','DISPONIVEL'),
 (186,'GUARDA CHUVA','',1,'100.00','13.00',1,'',1,1,'6.00','UN','EM LINHA','MINIMO'),
 (187,'BOIA MACARRAO','',1,'100.00','5.00',1,'',1,1,'2.50','UN','EM LINHA','MINIMO'),
 (188,'CARTOES DE AMOR','',1,'100.00','1.00',100,'',1,10,'0.50','UN','EM LINHA','DISPONIVEL'),
 (189,'IO IO DO BEN 10','',1,'100.00','6.00',2,'',1,2,'3.00','UN','EM LINHA','MINIMO'),
 (190,'BOLSAS SIMPLES','',1,'100.00','10.00',4,'',1,2,'5.00','UN','EM LINHA','DISPONIVEL'),
 (191,'EDREDON','',1,'100.00','60.00',1,'',1,1,'30.00','UN','EM LINHA','MINIMO'),
 (192,'TRICICOLO','',1,'100.00','80.00',1,'',1,1,'40.00','UN','EM LINHA','MINIMO'),
 (193,'BOLSA DE PRAIA','',1,'100.00','10.00',4,'',1,2,'5.00','UN','EM LINHA','DISPONIVEL'),
 (194,'CHAPEU','',1,'100.00','5.00',2,'',1,2,'2.00','UN','EM LINHA','MINIMO'),
 (195,'PILHA','',1,'100.00','3.00',44,'',1,10,'1.50','UN','EM LINHA','DISPONIVEL'),
 (196,'CD EVANGELICO','',1,'100.00','20.00',1,'',1,1,'10.00','UN','EM LINHA','MINIMO'),
 (197,'PRENZILHA','',1,'100.00','1.00',18,'',1,6,'0.50','UN','EM LINHA','DISPONIVEL'),
 (198,'CARTOES DE NATAL ','',1,'100.00','1.00',32,'',1,10,'0.50','UN','EM LINHA','DISPONIVEL'),
 (199,'CONTROLE DE PLAY 2','',1,'100.00','35.00',5,'',1,2,'15.00','UN','EM LINHA','DISPONIVEL'),
 (200,'CAMISETE COM NERVURAS','',1,'100.00','79.00',1,'',1,1,'39.90','UN','EM LINHA','MINIMO'),
 (201,'CONJUNTO CETIM GRAVATA BORDADA','',1,'100.00','89.00',1,'',1,1,'49.90','UN','EM LINHA','MINIMO'),
 (202,'CONJUNTO JOYALI','',1,'100.00','89.00',6,'',1,1,'44.00','UN','EM LINHA','DISPONIVEL'),
 (203,'CONJUNTO DETALHE XADREZ','',1,'100.00','99.00',1,'',1,1,'45.00','UN','EM LINHA','MINIMO'),
 (204,'BLUSA JOYALI','',1,'100.00','59.00',3,'',1,1,'35.00','UN','EM LINHA','DISPONIVEL'),
 (205,'SAIA JEANS JOYALI ','',1,'100.00','86.00',10,'',1,1,'40.00','UN','EM LINHA','DISPONIVEL'),
 (206,'VESTIDO BORDADO COM CINTO JEANS ','',1,'100.00','110.00',2,'',1,1,'50.00','UN','EM LINHA','DISPONIVEL'),
 (207,'CONJUNTO COM JAQUETA JOYALI','',1,'100.00','126.00',1,'',1,1,'59.00','UN','EM LINHA','MINIMO'),
 (208,'CONJUNTO CHANNEL JOYALI ','',1,'100.00','110.00',1,'',1,1,'50.00','UN','EM LINHA','MINIMO'),
 (209,'VESTIDO CINTO DE ARGOLAS ','',1,'100.00','89.00',1,'',1,1,'40.00','UN','EM LINHA','MINIMO'),
 (210,'BERMUDA JEANS JINURS','',1,'100.00','45.00',5,'',1,1,'20.00','UN','EM LINHA','DISPONIVEL'),
 (211,'BOLERO','',1,'100.00','22.00',4,'',1,1,'10.00','UN','EM LINHA','DISPONIVEL'),
 (212,'CINTO MASCULINO VARIAS MARCAS ','',1,'100.00','15.00',4,'',1,1,'8.00','UN','EM LINHA','DISPONIVEL'),
 (213,'BONE IMPORTADO ','',1,'100.00','15.00',25,'',1,1,'8.00','UN','EM LINHA','DISPONIVEL'),
 (214,'BONE INFANTIL ','',1,'100.00','6.00',7,'',1,1,'3.00','UN','EM LINHA','DISPONIVEL'),
 (215,'SAIA COMPRIDA MARROM ','',1,'100.00','48.00',1,'',1,1,'24.00','UN','EM LINHA','MINIMO'),
 (216,'CONTROLE UNIVERSAL PARA DVD ','',1,'100.00','25.00',2,'',1,1,'13.00','UN','EM LINHA','DISPONIVEL'),
 (217,'CAPA PARA OCULOS ','',1,'100.00','2.00',8,'',1,1,'1.00','UN','EM LINHA','DISPONIVEL'),
 (218,'OCULOS DE SOL ADULTO ','',1,'100.00','15.00',33,'',1,1,'8.00','UN','EM LINHA','DISPONIVEL'),
 (219,'OCULOS DE SOL INFANTIL ','',1,'100.00','6.00',6,'',1,1,'3.00','UN','EM LINHA','DISPONIVEL'),
 (220,'CUECA IMPORTADA ','',1,'100.00','22.00',3,'',1,1,'11.00','UN','EM LINHA','DISPONIVEL'),
 (221,'CONJUNTO EXERCITO ADULTO ','',1,'100.00','110.00',1,'',1,1,'55.00','UN','EM LINHA','MINIMO'),
 (222,'TOP ROXO','',1,'100.00','18.00',1,'',1,1,'14.00','UN','EM LINHA','MINIMO'),
 (223,'BERMUDA JEANS INFANTIL','',1,'100.00','32.00',4,'',1,1,'15.00','UN','EM LINHA','DISPONIVEL');
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;


--
-- Definition of table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `senha` char(6) NOT NULL,
  `perfil` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuarios`
--

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id`,`nome`,`senha`,`perfil`) VALUES 
 (1,'SUPERVISOR','1Q2W3E','ADMINISTRADOR'),
 (2,'RAIZA','250688','ADMINISTRADOR'),
 (3,'ALEXANDER','030289','ADMINISTRADOR');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;


--
-- Definition of table `venda`
--

DROP TABLE IF EXISTS `venda`;
CREATE TABLE `venda` (
  `idvenda` int(11) NOT NULL AUTO_INCREMENT,
  `estado` varchar(30) NOT NULL,
  `datavenda` date NOT NULL,
  `vendedor` varchar(45) NOT NULL,
  `totalvenda` decimal(10,2) NOT NULL,
  `obs` varchar(300) NOT NULL,
  `idcliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`idvenda`),
  KEY `FK_venda_1` (`idcliente`),
  CONSTRAINT `FK_venda_1` FOREIGN KEY (`idcliente`) REFERENCES `clientes` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `venda`
--

/*!40000 ALTER TABLE `venda` DISABLE KEYS */;
INSERT INTO `venda` (`idvenda`,`estado`,`datavenda`,`vendedor`,`totalvenda`,`obs`,`idcliente`) VALUES 
 (1,'ABERTA','2010-08-06','ALEXANDER','70.20','DESCONTO - TOTAL A PAGAR 70 REAIS ',5);
/*!40000 ALTER TABLE `venda` ENABLE KEYS */;


--
-- Definition of table `venda_item`
--

DROP TABLE IF EXISTS `venda_item`;
CREATE TABLE `venda_item` (
  `iditem` int(11) NOT NULL,
  `idvenda` int(11) NOT NULL,
  `idproduto` int(11) NOT NULL,
  `preco` decimal(10,2) DEFAULT NULL,
  `qtde` int(11) DEFAULT NULL,
  `desconto` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`iditem`,`idvenda`),
  KEY `idproduto` (`idproduto`),
  KEY `idvenda` (`idvenda`),
  CONSTRAINT `venda_item_ibfk_1` FOREIGN KEY (`idproduto`) REFERENCES `produtos` (`id`),
  CONSTRAINT `venda_item_ibfk_2` FOREIGN KEY (`idvenda`) REFERENCES `venda` (`idvenda`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `venda_item`
--

/*!40000 ALTER TABLE `venda_item` DISABLE KEYS */;
INSERT INTO `venda_item` (`iditem`,`idvenda`,`idproduto`,`preco`,`qtde`,`desconto`,`total`,`estado`) VALUES 
 (1,1,70,'78.00',1,'10.00','70.20','OK');
/*!40000 ALTER TABLE `venda_item` ENABLE KEYS */;


--
-- Definition of table `venda_parcela`
--

DROP TABLE IF EXISTS `venda_parcela`;
CREATE TABLE `venda_parcela` (
  `idvenda` int(10) NOT NULL,
  `idparcela` int(11) NOT NULL,
  `dtvencimento` date NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `idcliente` int(11) DEFAULT NULL,
  `prazo` int(11) DEFAULT NULL,
  `estado` varchar(45) NOT NULL,
  `obs` varchar(300) NOT NULL,
  `juros` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`idvenda`,`idparcela`),
  KEY `FK_venda_parcela_2` (`idcliente`),
  CONSTRAINT `FK_venda_parcela_1` FOREIGN KEY (`idvenda`) REFERENCES `venda` (`idvenda`),
  CONSTRAINT `FK_venda_parcela_2` FOREIGN KEY (`idcliente`) REFERENCES `clientes` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `venda_parcela`
--

/*!40000 ALTER TABLE `venda_parcela` DISABLE KEYS */;
/*!40000 ALTER TABLE `venda_parcela` ENABLE KEYS */;


--
-- Definition of trigger `trg_cli_deb`
--

DROP TRIGGER /*!50030 IF EXISTS */ `trg_cli_deb`;

DELIMITER $$

CREATE DEFINER = `root`@`localhost` TRIGGER `trg_cli_deb` AFTER INSERT ON `venda_parcela` FOR EACH ROW BEGIN
  INSERT INTO cliente_debito
  VALUES (NEW.idvenda, NEW.idparcela, NEW.dtvencimento, NEW.valor, NEW.idcliente, NEW.prazo, NEW.estado, NEW.obs, NEW.juros);
END $$

DELIMITER ;

--
-- Definition of procedure `sp_cad_ean`
--

DROP PROCEDURE IF EXISTS `sp_cad_ean`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cad_ean`(p_ean13 VARCHAR(13), p_idproduto INT,
p_emb VARCHAR(10), p_unid INT)
BEGIN
      INSERT INTO cod_barras
      VALUES (p_ean13, p_idproduto, p_emb, p_unid);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `sp_estado_estoque`
--

DROP PROCEDURE IF EXISTS `sp_estado_estoque`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_estado_estoque`()
BEGIN
      UPDATE produtos SET estado_estoque =
      CASE
      WHEN estoque > estoqueminimo THEN 'DISPONIVEL'
      WHEN estoque < estoqueminimo THEN 'ABAIXO DO MINIMO'
      ELSE 'MINIMO'
      END;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of view `clientespf`
--

DROP TABLE IF EXISTS `clientespf`;
DROP VIEW IF EXISTS `clientespf`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `clientespf` AS select `cli`.`id` AS `id`,`pf`.`nome` AS `nome`,`pf`.`apelido` AS `apelido`,`pf`.`rg` AS `rg`,`pf`.`cpf` AS `cpf`,`cli`.`cep` AS `cep`,`cli`.`logradouro` AS `logradouro`,`cli`.`numero` AS `numero`,`cli`.`bairro` AS `bairro`,`cli`.`cidade` AS `cidade`,`cli`.`estado` AS `estado`,`pf`.`datanasc` AS `datanasc`,`pf`.`nomepai` AS `nomepai`,`pf`.`nomemae` AS `nomemae`,`cli`.`email` AS `email`,`cli`.`telefone1` AS `telefone1`,`cli`.`ramal1` AS `ramal1`,`cli`.`telefone2` AS `telefone2`,`cli`.`ramal2` AS `ramal2`,`cli`.`obs` AS `obs`,`cli`.`c_status` AS `c_status` from (`pessoafisica` `pf` join `clientes` `cli` on((`pf`.`cpf` = `cli`.`PessoaFisica_cpf`))) order by `pf`.`nome`;

--
-- Definition of view `clientespj`
--

DROP TABLE IF EXISTS `clientespj`;
DROP VIEW IF EXISTS `clientespj`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `clientespj` AS select `cli`.`id` AS `id`,`pj`.`razaosocial` AS `razaosocial`,`pj`.`nomefantasia` AS `nomefantasia`,`pj`.`ie` AS `ie`,`pj`.`cnpj` AS `cnpj`,`cli`.`cep` AS `cep`,`cli`.`logradouro` AS `logradouro`,`cli`.`numero` AS `numero`,`cli`.`bairro` AS `bairro`,`cli`.`cidade` AS `cidade`,`cli`.`estado` AS `estado`,`cli`.`email` AS `email`,`cli`.`telefone1` AS `telefone1`,`cli`.`ramal1` AS `ramal1`,`cli`.`telefone2` AS `telefone2`,`cli`.`ramal2` AS `ramal2`,`cli`.`obs` AS `obs`,`cli`.`c_status` AS `c_status` from (`clientes` `cli` join `pessoajuridica` `pj` on((`cli`.`PessoaJuridica_cnpj` = `pj`.`cnpj`))) order by `pj`.`razaosocial`;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
