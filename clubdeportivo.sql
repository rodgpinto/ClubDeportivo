CREATE DATABASE  IF NOT EXISTS `clubdeportivo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `clubdeportivo`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: clubdeportivo
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `nosocios`
--

DROP TABLE IF EXISTS `nosocios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nosocios` (
  `id_NoSocio` int NOT NULL AUTO_INCREMENT,
  `personaId` int NOT NULL,
  `ficha_inscripcion` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_NoSocio`),
  KEY `FK_personaId` (`personaId`),
  CONSTRAINT `FK_personaId` FOREIGN KEY (`personaId`) REFERENCES `persona` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosocios`
--

LOCK TABLES `nosocios` WRITE;
/*!40000 ALTER TABLE `nosocios` DISABLE KEYS */;
/*!40000 ALTER TABLE `nosocios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pago_actividad`
--

DROP TABLE IF EXISTS `pago_actividad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pago_actividad` (
  `idPagoActividad` int NOT NULL AUTO_INCREMENT,
  `id_NoSocio` int NOT NULL,
  `pagado` tinyint(1) DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL,
  `formaDePago` varchar(20) NOT NULL,
  `fechaDePago` date NOT NULL,
  PRIMARY KEY (`idPagoActividad`),
  KEY `FK_no_socio_id` (`id_NoSocio`),
  CONSTRAINT `FK_no_socio_id` FOREIGN KEY (`id_NoSocio`) REFERENCES `nosocios` (`id_NoSocio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pago_actividad`
--

LOCK TABLES `pago_actividad` WRITE;
/*!40000 ALTER TABLE `pago_actividad` DISABLE KEYS */;
/*!40000 ALTER TABLE `pago_actividad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pago_cuota`
--

DROP TABLE IF EXISTS `pago_cuota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pago_cuota` (
  `idPagoCuota` int NOT NULL AUTO_INCREMENT,
  `socio_id` int NOT NULL,
  `pagado` tinyint(1) DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL,
  `fechaVencimiento` date NOT NULL,
  `formaDePago` varchar(20) NOT NULL,
  `fechaDePago` date NOT NULL,
  PRIMARY KEY (`idPagoCuota`),
  KEY `FK_socio_id` (`socio_id`),
  CONSTRAINT `FK_socio_id` FOREIGN KEY (`socio_id`) REFERENCES `socios` (`id_socio`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pago_cuota`
--

LOCK TABLES `pago_cuota` WRITE;
/*!40000 ALTER TABLE `pago_cuota` DISABLE KEYS */;
INSERT INTO `pago_cuota` VALUES (1,1,1,4500.00,'2025-05-15','mensual','2025-05-10');
/*!40000 ALTER TABLE `pago_cuota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `persona` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `dni` int NOT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,'Juan','Perez',12345678,'Calle Falsa 123','1990-01-01'),(2,'s','s',34,'s','2025-05-16'),(3,'s','s',1,'ad','2025-05-16'),(4,'Juan','Perez',30546523,'La casa','1989-07-19'),(5,'','Perez',30546523,'La casa','1989-07-19'),(6,'asd','asd',3,'asd','2025-05-16'),(7,'asdd','asd',1,'asd','2025-05-16'),(8,'Rodrigo','Pinto',34,'ASd','2000-02-02'),(9,'Ale','Ramirez',35,'Falsa 123','1989-07-12'),(10,'Homero','Thompson',123365,'Av Siempre viva 123','1990-02-08'),(11,'Homero','Simpson',123123,'ad','1989-01-31');
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `RolUsuario` int NOT NULL,
  `RolTipo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`RolUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador'),(2,'Empleado');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `socios`
--

DROP TABLE IF EXISTS `socios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `socios` (
  `id_socio` int NOT NULL AUTO_INCREMENT,
  `persona_id` int NOT NULL,
  `carnet` int DEFAULT NULL,
  `ficha_inscripcion` tinyint(1) DEFAULT NULL,
  `apto_fisico` tinyint(1) DEFAULT NULL,
  `socio_activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_socio`),
  KEY `FK_persona_id` (`persona_id`),
  CONSTRAINT `FK_persona_id` FOREIGN KEY (`persona_id`) REFERENCES `persona` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `socios`
--

LOCK TABLES `socios` WRITE;
/*!40000 ALTER TABLE `socios` DISABLE KEYS */;
INSERT INTO `socios` VALUES (1,1,1001,1,1,1),(2,3,2,0,0,1),(3,4,3,0,0,1),(4,5,4,0,0,1),(5,6,5,0,0,1),(6,7,6,0,0,1),(7,8,7,0,0,1),(8,9,8,0,0,1),(9,10,9,0,0,1),(10,11,10,0,0,1);
/*!40000 ALTER TABLE `socios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `idUser` int NOT NULL AUTO_INCREMENT,
  `NombreUsuario` varchar(20) DEFAULT NULL,
  `PassUsuario` varchar(15) DEFAULT NULL,
  `RolUsuario` int DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`idUser`),
  KEY `fk_usuario` (`RolUsuario`),
  CONSTRAINT `fk_usuario` FOREIGN KEY (`RolUsuario`) REFERENCES `roles` (`RolUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Test','12345',1,1),(2,'Tito','12345',1,1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'clubdeportivo'
--
/*!50003 DROP PROCEDURE IF EXISTS `IngresoLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin`(in Usuario varchar(20),in Pass varchar(15))
begin

  select RolTipo
	from usuario u inner join roles r on u.RolUsuario = r.RolUsuario
		where NombreUsuario = Usuario and PassUsuario = Pass 
			and Activo = 1; 

end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-17 20:50:10
