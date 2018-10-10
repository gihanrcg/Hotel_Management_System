-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 03, 2018 at 04:30 PM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel`
--

-- --------------------------------------------------------

--
-- Table structure for table `employeenotification`
--

CREATE TABLE `employeenotification` (
  `id` int(11) NOT NULL,
  `employeeNo` int(11) DEFAULT NULL,
  `type` varchar(100) DEFAULT NULL,
  `message` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employeenotification`
--

INSERT INTO `employeenotification` (`id`, `employeeNo`, `type`, `message`) VALUES
(5, 10000009, 'LeaveApproved', 'Your leave request to the date 9/2/2018 has been approved by Tharindu Shehan : Manager');

-- --------------------------------------------------------

--
-- Table structure for table `leaverequests`
--

CREATE TABLE `leaverequests` (
  `id` int(11) NOT NULL,
  `employeeNo` int(8) NOT NULL,
  `leaveType` varchar(200) NOT NULL,
  `FromDate` date DEFAULT NULL,
  `toDate` date DEFAULT NULL,
  `fromTime` time DEFAULT NULL,
  `toTime` time DEFAULT NULL,
  `halfdayTime` varchar(50) DEFAULT NULL,
  `reason` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `RoomID` int(11) NOT NULL,
  `roomType` varchar(100) NOT NULL,
  `priceForNight` float NOT NULL,
  `priceForHours` float NOT NULL,
  `noOfRooms` int(11) NOT NULL,
  `noOfRoomsAvailable` int(11) NOT NULL,
  `roomNo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`RoomID`, `roomType`, `priceForNight`, `priceForHours`, `noOfRooms`, `noOfRoomsAvailable`, `roomNo`) VALUES
(1, 'Deluxe', 16000, 2000, 65465, 10, 0),
(3, 'Supreme', 20000, 4000, 7, 6, 0),
(4, 'Honeymoon', 15000, 0, 4, 4, 0),
(5, 'Premier', 25000, 5000, 2, 2, 0);

-- --------------------------------------------------------

--
-- Stand-in structure for view `test`
-- (See below for the actual view)
--
CREATE TABLE `test` (
`type` varchar(300)
,`basic` float
,`casualLeaves` int(11)
,`sickLeaves` int(11)
,`shortLeaves` int(11)
,`halfdays` int(11)
);

-- --------------------------------------------------------

--
-- Table structure for table `testaddemp`
--

CREATE TABLE `testaddemp` (
  `name` varchar(50) NOT NULL,
  `age` int(5) NOT NULL,
  `contact` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `testaddemp`
--

INSERT INTO `testaddemp` (`name`, `age`, `contact`) VALUES
('System.Windows.Forms.TextBox, Text: Kasun', 0, 0);

-- --------------------------------------------------------

--
-- Structure for view `test`
--
DROP TABLE IF EXISTS `test`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `test`  AS  select `employeesalarydetails`.`type` AS `type`,`employeesalarydetails`.`basic` AS `basic`,`employeesalarydetails`.`casualLeaves` AS `casualLeaves`,`employeesalarydetails`.`sickLeaves` AS `sickLeaves`,`employeesalarydetails`.`shortLeaves` AS `shortLeaves`,`employeesalarydetails`.`halfdays` AS `halfdays` from `employeesalarydetails` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employeenotification`
--
ALTER TABLE `employeenotification`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `leaverequests`
--
ALTER TABLE `leaverequests`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`RoomID`),
  ADD UNIQUE KEY `roomType` (`roomType`);

--
-- Indexes for table `testaddemp`
--
ALTER TABLE `testaddemp`
  ADD PRIMARY KEY (`age`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employeenotification`
--
ALTER TABLE `employeenotification`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `leaverequests`
--
ALTER TABLE `leaverequests`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `rooms`
--
ALTER TABLE `rooms`
  MODIFY `RoomID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
