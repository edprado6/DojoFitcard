create database dojofitcardDB;

CREATE TABLE `dojofitcarddb`.`categoria` (
  `Id` VARCHAR(36) NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `DataCadastro` TIMESTAMP NOT NULL,
  `UltimaAtualizacao` TIMESTAMP NOT NULL,
  `Ativo` ENUM("0", "1") NOT NULL DEFAULT '1',
  `Excluido` ENUM("0", "1") NOT NULL DEFAULT '0',
  `DataExclusao` TIMESTAMP NULL,
  PRIMARY KEY (`Id`));