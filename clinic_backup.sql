-- MySQL dump 10.13  Distrib 5.7.15, for Win64 (x86_64)
--
-- Host: localhost    Database: clinic
-- ------------------------------------------------------
-- Server version	5.7.15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bookings`
--

DROP TABLE IF EXISTS `bookings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bookings` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `patient_id` bigint(10) NOT NULL,
  `doctor_id` bigint(10) NOT NULL,
  `disease_id` bigint(10) NOT NULL,
  `time_date` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `doctor_id` (`doctor_id`),
  KEY `patient_id` (`patient_id`),
  KEY `disease_id` (`disease_id`),
  CONSTRAINT `bookings_ibfk_1` FOREIGN KEY (`doctor_id`) REFERENCES `doctors` (`id`),
  CONSTRAINT `bookings_ibfk_2` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`),
  CONSTRAINT `bookings_ibfk_3` FOREIGN KEY (`disease_id`) REFERENCES `diseases` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bookings`
--

LOCK TABLES `bookings` WRITE;
/*!40000 ALTER TABLE `bookings` DISABLE KEYS */;
INSERT INTO `bookings` VALUES (2,3,2,2,'2016-12-23 20:48:55');
/*!40000 ALTER TABLE `bookings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diseases`
--

DROP TABLE IF EXISTS `diseases`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diseases` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` longtext,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diseases`
--

LOCK TABLES `diseases` WRITE;
/*!40000 ALTER TABLE `diseases` DISABLE KEYS */;
INSERT INTO `diseases` VALUES (3,' not Cold ','  '),(4,' asd ',' wjldsladlsasldal '),(5,' asd123','asdsadasdd'),(8,'MARD','SAKASDL ASD');
/*!40000 ALTER TABLE `diseases` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diseases_doctors`
--

DROP TABLE IF EXISTS `diseases_doctors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diseases_doctors` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `disease_id` bigint(10) NOT NULL,
  `doctor_id` bigint(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `disease_id` (`disease_id`),
  KEY `doctor_id` (`doctor_id`),
  CONSTRAINT `diseases_doctors_ibfk_1` FOREIGN KEY (`disease_id`) REFERENCES `diseases` (`id`),
  CONSTRAINT `diseases_doctors_ibfk_2` FOREIGN KEY (`doctor_id`) REFERENCES `doctors` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diseases_doctors`
--

LOCK TABLES `diseases_doctors` WRITE;
/*!40000 ALTER TABLE `diseases_doctors` DISABLE KEYS */;
INSERT INTO `diseases_doctors` VALUES (2,3,3),(3,4,3),(4,3,4),(5,5,4),(6,8,4);
/*!40000 ALTER TABLE `diseases_doctors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diseases_patients`
--

DROP TABLE IF EXISTS `diseases_patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diseases_patients` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `disease_id` bigint(10) NOT NULL,
  `patient_id` bigint(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `disease_id` (`disease_id`),
  KEY `patient_id` (`patient_id`),
  CONSTRAINT `diseases_patients_ibfk_1` FOREIGN KEY (`disease_id`) REFERENCES `diseases` (`id`),
  CONSTRAINT `diseases_patients_ibfk_2` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diseases_patients`
--

LOCK TABLES `diseases_patients` WRITE;
/*!40000 ALTER TABLE `diseases_patients` DISABLE KEYS */;
INSERT INTO `diseases_patients` VALUES (1,3,4),(2,3,5);
/*!40000 ALTER TABLE `diseases_patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diseases_symptoms`
--

DROP TABLE IF EXISTS `diseases_symptoms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diseases_symptoms` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `disease_id` bigint(10) NOT NULL,
  `symptom_id` bigint(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `disease_id` (`disease_id`),
  KEY `symptom_id` (`symptom_id`),
  CONSTRAINT `diseases_symptoms_ibfk_1` FOREIGN KEY (`disease_id`) REFERENCES `diseases` (`id`),
  CONSTRAINT `diseases_symptoms_ibfk_2` FOREIGN KEY (`symptom_id`) REFERENCES `symptoms` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diseases_symptoms`
--

LOCK TABLES `diseases_symptoms` WRITE;
/*!40000 ALTER TABLE `diseases_symptoms` DISABLE KEYS */;
INSERT INTO `diseases_symptoms` VALUES (7,8,17),(8,8,18);
/*!40000 ALTER TABLE `diseases_symptoms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctors`
--

DROP TABLE IF EXISTS `doctors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doctors` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctors`
--

LOCK TABLES `doctors` WRITE;
/*!40000 ALTER TABLE `doctors` DISABLE KEYS */;
INSERT INTO `doctors` VALUES (2,' Dr Khairy Hussien '),(3,' Dr Said Samy '),(4,'Dr Khairy fady');
/*!40000 ALTER TABLE `doctors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `drugs`
--

DROP TABLE IF EXISTS `drugs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drugs` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `disease_id` bigint(10) NOT NULL,
  `description` longtext,
  PRIMARY KEY (`id`),
  KEY `disease_id` (`disease_id`),
  CONSTRAINT `drugs_ibfk_1` FOREIGN KEY (`disease_id`) REFERENCES `diseases` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drugs`
--

LOCK TABLES `drugs` WRITE;
/*!40000 ALTER TABLE `drugs` DISABLE KEYS */;
INSERT INTO `drugs` VALUES (2,' Not kotofan ',3,'  this is kotofan for some disease '),(3,'Kotofan',3,'sdasd adasd asdsad '),(4,'banadol',3,'sdasd adasd asdsad ');
/*!40000 ALTER TABLE `drugs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log_in`
--

DROP TABLE IF EXISTS `log_in`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `log_in` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(100) NOT NULL,
  `user_password` varchar(100) NOT NULL,
  `user_privilege` enum('Admin','User') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_in`
--

LOCK TABLES `log_in` WRITE;
/*!40000 ALTER TABLE `log_in` DISABLE KEYS */;
INSERT INTO `log_in` VALUES (1,'Hefny','123123 ','Admin');
/*!40000 ALTER TABLE `log_in` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patients` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `time_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `phone` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES (3,' Ibrahim hassan ','2016-12-23 20:28:12','  '),(4,' asdsad','2017-01-06 18:21:52','123213'),(5,' Samir','2016-12-04 21:08:29','120301230');
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients_doctors`
--

DROP TABLE IF EXISTS `patients_doctors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patients_doctors` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `patient_id` bigint(10) NOT NULL,
  `doctor_id` bigint(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `patient_id` (`patient_id`),
  KEY `doctor_id` (`doctor_id`),
  CONSTRAINT `patients_doctors_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`),
  CONSTRAINT `patients_doctors_ibfk_2` FOREIGN KEY (`doctor_id`) REFERENCES `doctors` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients_doctors`
--

LOCK TABLES `patients_doctors` WRITE;
/*!40000 ALTER TABLE `patients_doctors` DISABLE KEYS */;
/*!40000 ALTER TABLE `patients_doctors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients_symptoms`
--

DROP TABLE IF EXISTS `patients_symptoms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patients_symptoms` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `patient_id` bigint(10) NOT NULL,
  `symptom_id` bigint(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `patient_id` (`patient_id`),
  KEY `symptom_id` (`symptom_id`),
  CONSTRAINT `patients_symptoms_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`),
  CONSTRAINT `patients_symptoms_ibfk_2` FOREIGN KEY (`symptom_id`) REFERENCES `symptoms` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients_symptoms`
--

LOCK TABLES `patients_symptoms` WRITE;
/*!40000 ALTER TABLE `patients_symptoms` DISABLE KEYS */;
INSERT INTO `patients_symptoms` VALUES (1,4,17),(2,5,18),(3,5,17);
/*!40000 ALTER TABLE `patients_symptoms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `symptoms`
--

DROP TABLE IF EXISTS `symptoms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `symptoms` (
  `id` bigint(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` longtext,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `symptoms`
--

LOCK TABLES `symptoms` WRITE;
/*!40000 ALTER TABLE `symptoms` DISABLE KEYS */;
INSERT INTO `symptoms` VALUES (17,'Ko7aa','Ko7aa Ko7aa Ko7aa'),(18,'ko7aa',NULL);
/*!40000 ALTER TABLE `symptoms` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-01-11 18:41:58
