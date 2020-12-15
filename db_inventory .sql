-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2020 at 09:09 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_inventory`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteCustomerInfo` (IN `CustomerID` INT(20))  NO SQL
BEGIN

DELETE FROM ppcustomerinfo WHERE ppcustomerinfo.CustomerID = CustomerID;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteProduct` (IN `ProductID` INT(255))  NO SQL
BEGIN

DELETE FROM ppinventory WHERE ppinventory.ProductID = ProductID;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DisplayCustomerInfo` ()  NO SQL
BEGIN
	SELECT * FROM ppcustomerinfo;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DisplayProduct` ()  NO SQL
BEGIN 
	SELECT ProductName, ProductID, Model, Brand, Attributes FROM ppinventory;
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertCustomerInfo` (IN `CustomerName` VARCHAR(50), IN `ItemBrought` TEXT, IN `DateBrought` TEXT)  NO SQL
BEGIN 
	INSERT INTO ppcustomerinfo(
        ppcustomerinfo.CustomerName,
        ppcustomerinfo.ItemBrought,
        ppcustomerinfo.DateBrought
        )
     VALUES(
         CustomerName,
         ItemBrought,
         DateBrought
         );
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertProduct` (IN `ProductName` VARCHAR(50), IN `Model` TEXT, IN `Brand` TEXT, IN `Attributes` TEXT)  NO SQL
BEGIN 
	INSERT INTO ppinventory(
        ppinventory.ProductName,
        ppinventory.Model,
        ppinventory.Brand,
        ppinventory.Attributes
        )
     VALUES(
         ProductName,
         Model,
         Brand,
         Attributes
         );
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateCustomer` (IN `CustomerID` INT(20), IN `CustomerName` VARCHAR(50), IN `ItemBrought` TEXT, IN `DateBrought` TEXT)  NO SQL
BEGIN

UPDATE ppcustomerinfo
SET
	ppcustomerinfo.CustomerName = CustomerName,
    ppcustomerinfo.ItemBrought = ItemBrought,
    ppcustomerinfo.DateBrought = DateBrought
WHERE
	ppcustomerinfo.CustomerID = CustomerID;
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateProduct` (IN `ProductName` VARCHAR(50), IN `ProductID` INT(255), IN `Model` TEXT, IN `Brand` TEXT, IN `Attributes` TEXT)  NO SQL
BEGIN

UPDATE ppinventory
SET
	ppinventory.ProductName = ProductName,
    ppinventory.Model = Model,
    ppinventory.Brand = Brand,
    ppinventory.Attributes = Attributes
WHERE
	ppinventory.ProductID = ProductID;
    
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `ppcustomerinfo`
--

CREATE TABLE `ppcustomerinfo` (
  `CustomerID` int(20) NOT NULL,
  `CustomerName` varchar(50) NOT NULL,
  `ItemBrought` text NOT NULL,
  `DateBrought` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ppcustomerinfo`
--

INSERT INTO `ppcustomerinfo` (`CustomerID`, `CustomerName`, `ItemBrought`, `DateBrought`) VALUES
(23, 'Android CUstomer', 'MOnitor', '1/23/20');

-- --------------------------------------------------------

--
-- Table structure for table `ppinventory`
--

CREATE TABLE `ppinventory` (
  `ProductName` varchar(50) NOT NULL,
  `ProductID` int(255) NOT NULL,
  `Model` text NOT NULL,
  `Brand` text NOT NULL,
  `Attributes` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ppinventory`
--

INSERT INTO `ppinventory` (`ProductName`, `ProductID`, `Model`, `Brand`, `Attributes`) VALUES
('Android', 987513, 'JSD23', 'DELL', 'White');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ppcustomerinfo`
--
ALTER TABLE `ppcustomerinfo`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `ppinventory`
--
ALTER TABLE `ppinventory`
  ADD PRIMARY KEY (`ProductID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ppcustomerinfo`
--
ALTER TABLE `ppcustomerinfo`
  MODIFY `CustomerID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `ppinventory`
--
ALTER TABLE `ppinventory`
  MODIFY `ProductID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=987514;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
