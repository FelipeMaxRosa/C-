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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `caixa`
--

/*!40000 ALTER TABLE `caixa` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clientes`
--

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `finalizadoras`
--

/*!40000 ALTER TABLE `finalizadoras` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fornecedor`
--

/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mov_estoque`
--

/*!40000 ALTER TABLE `mov_estoque` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produtos`
--

/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuarios`
--

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id`,`nome`,`senha`,`perfil`) VALUES 
 (1,'SUPERVISOR','1Q2W3E','ADMINISTRADOR');
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `venda`
--

/*!40000 ALTER TABLE `venda` DISABLE KEYS */;
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
