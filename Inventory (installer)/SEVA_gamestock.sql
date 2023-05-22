CREATE DATABASE  IF NOT EXISTS `gamestocks` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `gamestocks`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: gamestocks
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `employee_id` int NOT NULL AUTO_INCREMENT,
  `fname` varchar(45) DEFAULT NULL,
  `mname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `profession_id` int DEFAULT NULL,
  `date_started` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`employee_id`),
  KEY `profession_idx` (`profession_id`),
  CONSTRAINT `employee_profession` FOREIGN KEY (`profession_id`) REFERENCES `employeeprofession` (`prof_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (2,'Juan','Antonio','Dela Cruz',7,'2-10-2023'),(4,'Anthony','Bahia','Ortiz',1,'2-10-2023'),(5,'Roy','Bahia','Ortiz',1,'2-10-2023'),(8,'Kirk','Owen','Jesalva',9,'2-10-2023'),(9,'Dennise','Ann','Orlanda',6,'2-10-2023'),(10,'Francis',NULL,'Santiago',5,'2-10-2023'),(11,NULL,NULL,NULL,3,'2-10-2023'),(12,'SUSSY','AMONGUS','IMPOSTOR',2,NULL),(13,'Juan',NULL,'Dela Cruz',NULL,NULL),(14,'?','!',NULL,NULL,NULL);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `employee_AFTER_DELETE` AFTER DELETE ON `employee` FOR EACH ROW BEGIN
INSERT INTO employeefired(employee_fname, employee_lname, employee_status) VALUES (old.fname, old.lname, 'FIRED');
-- 'When deleting an employee, it will be inserted into a new table named "empployee fired"';
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `employee_daily_income`
--

DROP TABLE IF EXISTS `employee_daily_income`;
/*!50001 DROP VIEW IF EXISTS `employee_daily_income`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `employee_daily_income` AS SELECT 
 1 AS `lname`,
 1 AS `profession_name`,
 1 AS `daily_income`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `employee_report`
--

DROP TABLE IF EXISTS `employee_report`;
/*!50001 DROP VIEW IF EXISTS `employee_report`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `employee_report` AS SELECT 
 1 AS `fname`,
 1 AS `lname`,
 1 AS `profession_name`,
 1 AS `date_started`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `employeefired`
--

DROP TABLE IF EXISTS `employeefired`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employeefired` (
  `table_id` int NOT NULL AUTO_INCREMENT,
  `employee_fname` varchar(45) DEFAULT NULL,
  `employee_lname` varchar(45) DEFAULT NULL,
  `employee_status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`table_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employeefired`
--

LOCK TABLES `employeefired` WRITE;
/*!40000 ALTER TABLE `employeefired` DISABLE KEYS */;
INSERT INTO `employeefired` VALUES (2,'Kirck','Navarro','FIRED'),(3,'Gerald','Baldon','FIRED'),(4,'Joriza','Oliva','FIRED'),(5,'Kennethsss','Seva','FIRED');
/*!40000 ALTER TABLE `employeefired` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employeeprofession`
--

DROP TABLE IF EXISTS `employeeprofession`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employeeprofession` (
  `prof_id` int NOT NULL AUTO_INCREMENT,
  `profession_name` varchar(45) DEFAULT NULL,
  `daily_income` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`prof_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employeeprofession`
--

LOCK TABLES `employeeprofession` WRITE;
/*!40000 ALTER TABLE `employeeprofession` DISABLE KEYS */;
INSERT INTO `employeeprofession` VALUES (1,'Cashier','250php'),(2,'Service Tour','350php'),(3,'Inventory Control Specialists','500php'),(4,'Janitor','750php'),(5,'Guard','400php'),(6,'Manager','1500php'),(7,'Assistant Manager','1000php'),(8,'Online Customer Services','150php'),(9,'Stock Clerk','800php'),(10,'Overnight Stock Clerk','1100php');
/*!40000 ALTER TABLE `employeeprofession` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `product_report`
--

DROP TABLE IF EXISTS `product_report`;
/*!50001 DROP VIEW IF EXISTS `product_report`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `product_report` AS SELECT 
 1 AS `product_name`,
 1 AS `product_quantity`,
 1 AS `date_of_arrival`,
 1 AS `product_type`,
 1 AS `brand_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `productbrands`
--

DROP TABLE IF EXISTS `productbrands`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productbrands` (
  `brand_id` int NOT NULL AUTO_INCREMENT,
  `brand_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`brand_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productbrands`
--

LOCK TABLES `productbrands` WRITE;
/*!40000 ALTER TABLE `productbrands` DISABLE KEYS */;
INSERT INTO `productbrands` VALUES (1,'Razer'),(2,'Logitech'),(3,'Steel Series'),(4,'Alienwares'),(5,'Corsair'),(6,'Kingston'),(7,'Lenovo'),(8,'HP'),(9,'ROG'),(10,'Red Dragon'),(11,'MSI'),(13,'Huion');
/*!40000 ALTER TABLE `productbrands` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `products_id` int NOT NULL AUTO_INCREMENT,
  `product_name` varchar(45) DEFAULT NULL,
  `date_of_arrival` varchar(45) DEFAULT NULL,
  `product_type_id` int DEFAULT NULL,
  `product_quantity` varchar(45) DEFAULT NULL,
  `product_brand` int DEFAULT NULL,
  PRIMARY KEY (`products_id`),
  KEY `type_name_idx` (`product_type_id`),
  KEY `p_brand_name_idx` (`product_brand`),
  CONSTRAINT `p_brand_name` FOREIGN KEY (`product_brand`) REFERENCES `productbrands` (`brand_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `p_type_name` FOREIGN KEY (`product_type_id`) REFERENCES `producttypes` (`types_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (2,'Logitech G502','2-1-2023',1,'Out of Stock',2),(3,'Corsair K70 RGB','2-2-2023',2,'10',5),(4,'SteelSeries Apex','2-2-2023',2,'Out of Stock',3),(5,'Roccat Vulcan II Max','2-2-2023',2,'100',4),(6,'Roccat Vulcan Mk 3Max','2-2-2023',2,'1000',4),(7,'Astro Gaming A10','2-3-2023',3,'1',10),(8,'Razer Barracuda X','2-3-2023',3,'5',1),(9,'Razer Blackshark V2','2-3-2023',3,'10',1),(10,'Asus ROG Zephyrus G15','2-4-2023',4,'2',9),(11,'Razer Sphenx','2-7-2023',6,'1',1),(12,'ROG ZEPHYRUS G14','PENDING ARRIVAL',4,'5',9),(13,'ROF AMONGUS GAMER','PENDING ARRIVAL',2,'7',10),(14,'Laptop','PENDING ARRIVAL',5,'OUT OF STOCK',10),(15,'Onikuma 19 Gaming Headset','PENDING ARRIVAL',8,'10',5);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `products_BEFORE_INSERT` BEFORE INSERT ON `products` FOR EACH ROW BEGIN
IF new.date_of_arrival IS NULL THEN
SET new.date_of_arrival = "PENDING ARRIVAL";
END IF;
-- 'THIS Trigger allows to put a "PENDING ARRIVAL" if the user input is null on column';
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `products_BEFORE_UPDATE` BEFORE UPDATE ON `products` FOR EACH ROW BEGIN
IF new.product_quantity < 0 OR new.product_quantity = 0 THEN
SET new.product_quantity = "OUT OF STOCK";
END IF;
-- 'Same on Before Insert but this time is update when the quantity reached 0 or negative';
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `producttypes`
--

DROP TABLE IF EXISTS `producttypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producttypes` (
  `types_id` int NOT NULL AUTO_INCREMENT,
  `product_type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`types_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producttypes`
--

LOCK TABLES `producttypes` WRITE;
/*!40000 ALTER TABLE `producttypes` DISABLE KEYS */;
INSERT INTO `producttypes` VALUES (1,'Gaming Mouse'),(2,'Gaming Keyboard'),(3,'Gaming Headset'),(4,'Gaming Laptop'),(5,'Bag'),(6,'Mousepad'),(7,'3A USB Type C Cable'),(8,'3A MIcro USB Cable'),(9,'Solid State Drive'),(10,'Hard Disk Drive'),(12,'Drawing Tablet');
/*!40000 ALTER TABLE `producttypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'gamestocks'
--

--
-- Dumping routines for database 'gamestocks'
--
/*!50003 DROP FUNCTION IF EXISTS `sample_function` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `sample_function`(s CHAR(20)) RETURNS char(50) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
	
RETURN CONCAT('SAMPLE HELLO, ' ,s, '!');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `product_name_tye_brand_only` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `product_name_tye_brand_only`()
BEGIN
SELECT 
    products.product_name,
    producttypes.product_type,
    productbrands.brand_name
FROM 
	products RIGHT JOIN producttypes
ON 
	products.product_type_id = producttypes.types_id
RIGHT JOIN 
	productbrands ON products.product_brand = productbrands.brand_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `employee_daily_income`
--

/*!50001 DROP VIEW IF EXISTS `employee_daily_income`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `employee_daily_income` AS select `employee`.`lname` AS `lname`,`employeeprofession`.`profession_name` AS `profession_name`,`employeeprofession`.`daily_income` AS `daily_income` from (`employeeprofession` left join `employee` on((`employee`.`profession_id` = `employeeprofession`.`prof_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `employee_report`
--

/*!50001 DROP VIEW IF EXISTS `employee_report`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `employee_report` AS select `employee`.`fname` AS `fname`,`employee`.`lname` AS `lname`,`employeeprofession`.`profession_name` AS `profession_name`,`employee`.`date_started` AS `date_started` from (`employeeprofession` left join `employee` on((`employee`.`profession_id` = `employeeprofession`.`prof_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `product_report`
--

/*!50001 DROP VIEW IF EXISTS `product_report`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `product_report` AS select `products`.`product_name` AS `product_name`,`products`.`product_quantity` AS `product_quantity`,`products`.`date_of_arrival` AS `date_of_arrival`,`producttypes`.`product_type` AS `product_type`,`productbrands`.`brand_name` AS `brand_name` from (`productbrands` left join (`producttypes` left join `products` on((`products`.`product_type_id` = `producttypes`.`types_id`))) on((`products`.`product_brand` = `productbrands`.`brand_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-22 19:03:16
