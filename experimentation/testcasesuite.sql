-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema ntccat
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ntccat
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ntccat` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `ntccat` ;

-- -----------------------------------------------------
-- Table `ntccat`.`employee`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`employee` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `firstname` VARCHAR(45) NULL DEFAULT NULL,
  `lastname` VARCHAR(45) NULL DEFAULT NULL,
  `username` VARCHAR(45) NULL DEFAULT NULL,
  `email` VARCHAR(45) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `password` VARCHAR(255) NULL DEFAULT NULL,
  `salt` VARCHAR(255) NULL DEFAULT NULL,
  `isactive` TINYINT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 24
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`project`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`project` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `projectname` VARCHAR(45) NULL DEFAULT NULL,
  `projectcode` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`employeeprojectmapping`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`employeeprojectmapping` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `empid` INT NOT NULL,
  `projid` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `projidFK_idx` (`projid` ASC) VISIBLE,
  INDEX `asdadad_idx` (`empid` ASC) VISIBLE,
  CONSTRAINT `asdadad`
    FOREIGN KEY (`empid`)
    REFERENCES `ntccat`.`employee` (`id`),
  CONSTRAINT `projidFK`
    FOREIGN KEY (`projid`)
    REFERENCES `ntccat`.`project` (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 15
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`employeeroles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`employeeroles` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `accesslevelname` VARCHAR(45) NULL DEFAULT NULL,
  `accesslevel` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`employeerolesmapping`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`employeerolesmapping` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `empid` INT NOT NULL,
  `accesslevelid` INT NOT NULL,
  `projid` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`, `accesslevelid`),
  INDEX `accesslevelidFK_idx` (`accesslevelid` ASC) VISIBLE,
  INDEX `adadadsw_idx` (`empid` ASC) VISIBLE,
  INDEX `adawdawdw_idx` (`projid` ASC) VISIBLE,
  CONSTRAINT `accesslevelidFK`
    FOREIGN KEY (`accesslevelid`)
    REFERENCES `ntccat`.`employeeroles` (`id`),
  CONSTRAINT `adadadsw`
    FOREIGN KEY (`empid`)
    REFERENCES `ntccat`.`employee` (`id`),
  CONSTRAINT `adawdawdw`
    FOREIGN KEY (`projid`)
    REFERENCES `ntccat`.`project` (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 12
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci
COMMENT = '	';


-- -----------------------------------------------------
-- Table `ntccat`.`testcase`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`testcase` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `projID` INT NULL DEFAULT NULL,
  `name` VARCHAR(255) NULL DEFAULT NULL,
  `sprint` VARCHAR(50) NULL DEFAULT NULL,
  `jiraticketnumber` VARCHAR(20) NULL DEFAULT NULL,
  `templateid` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  INDEX `adawdd_fk_idx` (`projID` ASC) VISIBLE,
  CONSTRAINT `adawdd_fk`
    FOREIGN KEY (`projID`)
    REFERENCES `ntccat`.`project` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`employeetestcase`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`employeetestcase` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `empid` INT NOT NULL,
  `testcaseid` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `qwdwqeweFK_idx` (`testcaseid` ASC) VISIBLE,
  INDEX `asdsdadad_idx` (`empid` ASC) VISIBLE,
  CONSTRAINT `asdsdadad`
    FOREIGN KEY (`empid`)
    REFERENCES `ntccat`.`employee` (`id`),
  CONSTRAINT `qwdwqeweFK`
    FOREIGN KEY (`testcaseid`)
    REFERENCES `ntccat`.`testcase` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci
COMMENT = '		';


-- -----------------------------------------------------
-- Table `ntccat`.`testcasefields`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`testcasefields` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `fieldname` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`testcasetemplate`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`testcasetemplate` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `templatename` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`templatedetails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`templatedetails` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `templateid` INT NULL DEFAULT NULL,
  `fieldid` INT NULL DEFAULT NULL,
  `ordinal` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  INDEX `xlkcjzlzjl_idx` (`templateid` ASC) VISIBLE,
  INDEX `kdlkjfslj_idx` (`fieldid` ASC) VISIBLE,
  CONSTRAINT `kdlkjfslj`
    FOREIGN KEY (`fieldid`)
    REFERENCES `ntccat`.`testcasefields` (`id`),
  CONSTRAINT `xlkcjzlzjl`
    FOREIGN KEY (`templateid`)
    REFERENCES `ntccat`.`testcasetemplate` (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`testcaseversion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`testcaseversion` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `testCaseID` INT NULL DEFAULT NULL,
  `versionNumber` INT NULL DEFAULT NULL,
  `ModificationDate` DATETIME NULL DEFAULT NULL,
  `ModifiedBy` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `asdwFK_idx` (`testCaseID` ASC) VISIBLE,
  CONSTRAINT `asdwFK`
    FOREIGN KEY (`testCaseID`)
    REFERENCES `ntccat`.`testcase` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`testcasedetails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`testcasedetails` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `TestCaseID` INT NULL DEFAULT NULL,
  `field` VARCHAR(255) NULL DEFAULT NULL,
  `value` VARCHAR(255) NULL DEFAULT NULL,
  `versionid` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `testcaseidFK_idx` (`TestCaseID` ASC) VISIBLE,
  INDEX `testcaseid2FK_idx` (`TestCaseID` ASC) VISIBLE,
  INDEX `sfjjklkj_idx` (`versionid` ASC) VISIBLE,
  CONSTRAINT `sfjjklkj`
    FOREIGN KEY (`versionid`)
    REFERENCES `ntccat`.`testcaseversion` (`id`),
  CONSTRAINT `thisFK`
    FOREIGN KEY (`TestCaseID`)
    REFERENCES `ntccat`.`testcase` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ntccat`.`usertestcase`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ntccat`.`usertestcase` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `empid` INT NOT NULL,
  `testcaseid` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `testcaseidFK_idx` (`testcaseid` ASC) VISIBLE,
  INDEX `asdadads_idx` (`empid` ASC) VISIBLE,
  CONSTRAINT `asdadads`
    FOREIGN KEY (`empid`)
    REFERENCES `ntccat`.`employee` (`id`),
  CONSTRAINT `testcaseidFK`
    FOREIGN KEY (`testcaseid`)
    REFERENCES `ntccat`.`testcase` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `ntccat` ;

-- -----------------------------------------------------
-- procedure DynamicPivot
-- -----------------------------------------------------

DELIMITER $$
USE `ntccat`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DynamicPivot`(IN templateId INT)
BEGIN
    SET SESSION group_concat_max_len = 100000000;
    SET @sql = NULL;

    SELECT GROUP_CONCAT(DISTINCT
        CONCAT(
            'MAX(CASE WHEN fieldname = ''',
            fieldname,
            ''' THEN ''change me'' ELSE ''change me'' END) AS `',
            fieldname, '`'
        )
    ) INTO @sql
    FROM (
        SELECT fieldname
        FROM testcasefields f
        JOIN templatedetails d ON f.id = d.fieldid
        JOIN testcasetemplate t ON t.id = d.templateid
        WHERE t.id = templateId
    ) d;

	IF @sql IS NOT NULL THEN
		SET @sql = CONCAT('
			SELECT ', @sql, '
			FROM testcasefields f
			JOIN templatedetails d ON f.id = d.fieldid
			JOIN testcasetemplate t ON t.id = d.templateid
			WHERE t.id = templateId
			GROUP BY t.id
		');

		PREPARE stmt FROM @sql;
		EXECUTE stmt;
		DEALLOCATE PREPARE stmt;
    END IF;
END$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
