-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 02, 2015 at 02:03 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `minicashieringdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `autonum`
--

CREATE TABLE IF NOT EXISTS `autonum` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `STRT` int(11) NOT NULL,
  `END` int(11) NOT NULL,
  `INC` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `autonum`
--

INSERT INTO `autonum` (`ID`, `STRT`, `END`, `INC`) VALUES
(1, 1, 9, 1);

-- --------------------------------------------------------

--
-- Table structure for table `cashier_user`
--

CREATE TABLE IF NOT EXISTS `cashier_user` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Firstname` char(15) NOT NULL,
  `Lastname` char(15) NOT NULL,
  `username` varchar(15) NOT NULL,
  `pass` varchar(15) NOT NULL,
  `User_status` char(15) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `cashier_user`
--

INSERT INTO `cashier_user` (`ID`, `Firstname`, `Lastname`, `username`, `pass`, `User_status`) VALUES
(1, 'dolan', 'cuevas', 'dcuevas', '11111', 'cashier'),
(2, 'jimme', 'espars', 'jim2', '1212', 'Owner'),
(3, 'jack', 'flaviano', 'jackF', '2323', 'Cashier'),
(4, 'angie', 'calalas', 'angie1', '22222', 'Cashier');

-- --------------------------------------------------------

--
-- Table structure for table `foods_list`
--

CREATE TABLE IF NOT EXISTS `foods_list` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `pro_id` varchar(15) NOT NULL DEFAULT '',
  `Item_name` varchar(40) DEFAULT NULL,
  `Product_name` varchar(40) DEFAULT NULL,
  `category` varchar(30) NOT NULL,
  `price` int(100) DEFAULT NULL,
  `size` varchar(40) DEFAULT NULL,
  `Photos` text,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `pro_id` (`pro_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=22 ;

--
-- Dumping data for table `foods_list`
--

INSERT INTO `foods_list` (`ID`, `pro_id`, `Item_name`, `Product_name`, `category`, `price`, `size`, `Photos`) VALUES
(1, '20001', 'B3', 'Heavy Burger', 'Burger', 55, 'Large', 'burger (2).jpg'),
(2, '200017', 'D1', 'Chocolate Sundae', 'Desert', 30, 'Medium', '8.jpg'),
(3, '20002', 'B4', 'Giant Burger', 'Burger', 65, 'Large', 'burger (2).jpg'),
(4, '20003', 'S1', 'cocacola', 'Drinks', 25, 'Large', 'f641d2b2e8138198e2bf6c3df90b8efb.jpg'),
(5, '20004', 'S1', 'Cocacola', '', 18, 'Small', ''),
(6, '20005', 'S2', 'Sprite', '', 18, 'Small', ''),
(7, '20006', 'S2', 'Sprite', '', 25, 'Large', ''),
(8, '20007', 'S3', 'Universal Float', 'Drinks', 25, 'Small', 'CHOCOLATE FLOAT.JPG'),
(9, '20008', 'S3', 'Universal Float', '', 34, 'Medium', ''),
(10, '20009', 'S3', 'universal Float', '', 42, 'Large', ''),
(11, '20010', 'S4', 'Creamy float', '', 25, 'Small', ''),
(12, '20011', 'S4', 'Creamy float', '', 30, 'Small', ''),
(13, '20012', 'S5', 'Coffee', '', 18, 'Small', ''),
(14, '20013', 'S5', 'Coffee', '', 25, 'Medium', ''),
(15, '20014', 'S5', 'Coffee', '', 30, 'Large', ''),
(16, '20016', 'D1', 'Chocolate Sundae', '', 25, 'Small', ''),
(17, '20018', 'D1', 'Chocolate Sundae', '', 35, 'Large', ''),
(19, '2415344', 'B2', 'Hum & Cheese Burger', '', 40, 'Medium', 'Burger (1).jpg'),
(20, '423441', 'F1', 'Hotcake with Hotdog', '', 65, 'Small', 'Chicken-Sausages-with-2-piece-Pancakes-–-Php-52.00.jpg'),
(21, '4241', 'B1', 'Regular Burger', '', 35, 'Small', 'brute-burger.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tblpayments`
--

CREATE TABLE IF NOT EXISTS `tblpayments` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `PAYMENTID` int(11) NOT NULL,
  `pro_id` varchar(30) NOT NULL,
  `QTY` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `tblpayments`
--

INSERT INTO `tblpayments` (`ID`, `PAYMENTID`, `pro_id`, `QTY`, `TOTALPRICE`) VALUES
(1, 13, '20002', 1, 61.6),
(2, 13, '20002', 1, 61.6),
(3, 14, '20003', 2, 53),
(4, 14, '20002', 1, 72.8),
(5, 15, '20003', 12, 303),
(6, 16, '200017', 1, 33.6),
(7, 16, '200017', 3, 93.6),
(8, 17, '20007', 1, 28),
(9, 18, '20007', 1, 28);

-- --------------------------------------------------------

--
-- Table structure for table `tblsummary`
--

CREATE TABLE IF NOT EXISTS `tblsummary` (
  `summryid` int(11) NOT NULL AUTO_INCREMENT,
  `PAYMENTID` int(11) NOT NULL,
  `OVERALLPRICE` double NOT NULL,
  `CHANGE` double NOT NULL,
  PRIMARY KEY (`summryid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `tblsummary`
--

INSERT INTO `tblsummary` (`summryid`, `PAYMENTID`, `OVERALLPRICE`, `CHANGE`) VALUES
(1, 13, 123.2, 76.8),
(2, 14, 125.8, 74.2),
(3, 15, 303, 7),
(4, 16, 127.2, 72.8),
(5, 17, 28, 194),
(6, 18, 28, 3);
