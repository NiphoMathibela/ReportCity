-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 13, 2024 at 09:48 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `report_city`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `Id` int(10) NOT NULL,
  `Name` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`Id`, `Name`) VALUES
(1, 'Roads and Traffic'),
(2, 'Waste Management'),
(3, 'Water and Sewerage'),
(4, 'Electricity'),
(5, 'Public Transportation');

-- --------------------------------------------------------

--
-- Table structure for table `events`
--

CREATE TABLE `events` (
  `Id` int(11) NOT NULL,
  `Title` varchar(250) DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `Date` datetime NOT NULL,
  `Location` varchar(250) DEFAULT NULL,
  `Priority` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `events`
--

INSERT INTO `events` (`Id`, `Title`, `Description`, `Date`, `Location`, `Priority`) VALUES
(1, 'Event 1', 'Description 1', '2024-10-14 00:00:00', 'Location 1', 'High'),
(2, 'Event 2', 'Description 2', '2024-10-15 00:00:00', 'Location 2', 'Medium'),
(3, 'Event 3', 'Description 3', '2024-10-16 00:00:00', 'Location 3', 'Low'),
(4, 'Event 4', 'Description 4', '2024-10-17 00:00:00', 'Location 4', 'High'),
(5, 'Event 5', 'Description 5', '2024-10-18 00:00:00', 'Location 5', 'Medium');

-- --------------------------------------------------------

--
-- Table structure for table `issues`
--

CREATE TABLE `issues` (
  `ReportId` int(11) NOT NULL,
  `Location` varchar(250) NOT NULL,
  `Description` varchar(250) NOT NULL,
  `Category` varchar(250) NOT NULL,
  `Image` varchar(250) DEFAULT NULL,
  `Status` varchar(250) NOT NULL,
  `Priority` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `issues`
--

INSERT INTO `issues` (`ReportId`, `Location`, `Description`, `Category`, `Image`, `Status`, `Priority`) VALUES
(1, 'Pitori', 'PotHole', 'Pot Hole', 'An image', 'Closed', 2),
(2, 'Pretoria', 'Pot Hole on Main Street', 'Pot Hole', 'path/to/image1.jpg', 'Closed', 2),
(3, 'Pretoria', 'Street Light Out on 5th Ave', 'Electrical', 'path/to/image2.jpg', 'Open', 1),
(4, 'Pretoria', 'Graffiti on Wall at Park', 'Vandalism', 'path/to/image3.jpg', 'In Progress', 3),
(5, 'Pretoria', 'Water Leak Near Intersection', 'Plumbing', 'path/to/image4.jpg', 'Closed', 2),
(6, 'Pretoria', 'Traffic Signal Malfunction', 'Traffic', 'path/to/image5.jpg', 'Open', 1),
(7, 'Pretoria', 'Sidewalk Cracked Near School', 'Infrastructure', 'path/to/image6.jpg', 'Pending', 4),
(8, 'Pretoria', 'Overflowing Trash Bin on 2nd St', 'Sanitation', 'path/to/image7.jpg', 'Closed', 3),
(9, 'Pretoria', 'Missing Manhole Cover', 'Safety', 'path/to/image8.jpg', 'Open', 1),
(10, 'Pretoria', 'Pothole Repair Needed on Elm St', 'Pot Hole', 'path/to/image9.jpg', 'In Progress', 2),
(11, 'Pretoria', 'Broken Bench in Park', 'Maintenance', 'path/to/image10.jpg', 'Closed', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `issues`
--
ALTER TABLE `issues`
  ADD PRIMARY KEY (`ReportId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `events`
--
ALTER TABLE `events`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `issues`
--
ALTER TABLE `issues`
  MODIFY `ReportId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
