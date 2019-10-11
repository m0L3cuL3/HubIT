-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: hubit
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `category_id` int(11) NOT NULL AUTO_INCREMENT,
  `category_type` varchar(30) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Java'),(2,'Python'),(3,'C#'),(4,'C++');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `file`
--

DROP TABLE IF EXISTS `file`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `file` (
  `file_id` int(11) NOT NULL AUTO_INCREMENT,
  `file_name` varchar(20) NOT NULL,
  `file_type` varchar(20) NOT NULL,
  `file_data` longblob,
  `file_date` date NOT NULL,
  `user_name` varchar(11) DEFAULT NULL,
  `topic_type` varchar(30) DEFAULT NULL,
  `category_type` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`file_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `file`
--

LOCK TABLES `file` WRITE;
/*!40000 ALTER TABLE `file` DISABLE KEYS */;
INSERT INTO `file` VALUES (8,'SampleJava','.java',_binary 'import java.util.Scanner;\r\n\r\npublic class Main {\r\n	\r\n	public static Scanner in;\r\n	public static String products[] = {\"Mangoes\", \"Banana\", \"Apple\", \"Durian\"}; // product names\r\n	public static int mango = 150;\r\n	public static int banana = 200;\r\n	public static int apple = 500;\r\n	public static int durian = 1000;\r\n	\r\n	public static void main(String[] args){\r\n		\r\n		in = new Scanner(System.in);\r\n		\r\n		System.out.println(\"Product List:\");\r\n		for(int i = 0; i < 4; i++){\r\n			System.out.println(i + \". \" + products[i]);\r\n		}\r\n		\r\n		System.out.print(\"Enter Product: \");\r\n		int product = in.nextInt();\r\n		\r\n		System.out.print(\"Enter Quantity: \");\r\n		int quantity = in.nextInt();\r\n		\r\n		switch(product){\r\n			case 0:\r\n				System.out.println(\"Total Mangoes Left: \" + getMango(quantity));\r\n				break;\r\n			case 1:\r\n				System.out.println(\"Total Banana Left: \" + getBanana(quantity));\r\n				break;\r\n			case 2:\r\n				System.out.println(\"Total Apple Left: \" + getApple(quantity));\r\n				break;\r\n			case 3:\r\n				System.out.println(\"Total Durian Left: \" + getDurian(quantity));\r\n				break;\r\n			default:\r\n				System.out.println(\"Invalid Option!\");\r\n				break;\r\n		}\r\n	}\r\n	\r\n	public static int getMango(int userinput){\r\n		int total = mango - userinput;\r\n		return total;\r\n	}\r\n	\r\n	public static int getBanana(int userinput){\r\n		int total = banana - userinput;\r\n		return total;\r\n	}\r\n	\r\n	public static int getApple(int userinput){\r\n		int total = apple - userinput;\r\n		return total;\r\n	}\r\n	\r\n	public static int getDurian(int userinput){\r\n		int total = durian - userinput;\r\n		return total;\r\n	}\r\n}','2019-10-06','seanbaang','Arrays','Java');
/*!40000 ALTER TABLE `file` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manager`
--

DROP TABLE IF EXISTS `manager`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `manager` (
  `manager_id` int(11) NOT NULL AUTO_INCREMENT,
  `manager_username` varchar(11) NOT NULL,
  `manager_password` varchar(50) NOT NULL,
  PRIMARY KEY (`manager_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manager`
--

LOCK TABLES `manager` WRITE;
/*!40000 ALTER TABLE `manager` DISABLE KEYS */;
INSERT INTO `manager` VALUES (2,'seanbaang','admin123'),(3,'admin','admin123');
/*!40000 ALTER TABLE `manager` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `topic`
--

DROP TABLE IF EXISTS `topic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `topic` (
  `topic_id` int(11) NOT NULL AUTO_INCREMENT,
  `topic_title` varchar(20) NOT NULL,
  `topic_desc` varchar(255) NOT NULL,
  `topic_type` varchar(30) NOT NULL,
  `topic_date` date NOT NULL,
  `user_name` varchar(11) DEFAULT NULL,
  `category_type` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`topic_id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `topic`
--

LOCK TABLES `topic` WRITE;
/*!40000 ALTER TABLE `topic` DISABLE KEYS */;
INSERT INTO `topic` VALUES (25,'Test Title','Test Description','Inheritance','2019-10-05','seanbaang','Python'),(26,'Python','Python Description','Inheritance','2019-10-05','seanbaang','C++'),(38,'Java','Inheritance Description here , , ,','Inheritance','2019-10-05','seanbaang','Java'),(39,'C# Help!','I need help in programming in C# that exhibits Inheritance.','Inheritance','2019-10-06','bobmarley','C#'),(40,'C++ Help','I want to learn how to code abstraction in C++, although I am not really good at coding. :(','Abstraction','2019-10-06','bobmarley','C++');
/*!40000 ALTER TABLE `topic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(11) NOT NULL,
  `user_fname` varchar(15) NOT NULL,
  `user_lname` varchar(15) NOT NULL,
  `user_email` varchar(50) NOT NULL,
  `user_occupation` varchar(50) NOT NULL,
  `user_gender` varchar(15) NOT NULL,
  `user_birthdate` date NOT NULL,
  `user_password` varchar(50) NOT NULL,
  `user_address` varchar(50) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (7,'seanbaang','Sean Myko','Baang','skidrowloler@gmail.com','Student','Male','2000-07-19','1234','Morning Mist Village'),(8,'bobmarley','Bob','Marley','bobmarley@gmail.com','Singer','Male','1989-01-01','1234','Babylon');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-06 12:07:18
