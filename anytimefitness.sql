-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 28, 2025 at 06:13 AM
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
-- Database: `anytimefitness`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `SecQuestion` varchar(255) NOT NULL,
  `SecAnswer` varchar(255) NOT NULL,
  `status` enum('Pending','Accepted','Rejected') DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`id`, `username`, `password`, `SecQuestion`, `SecAnswer`, `status`) VALUES
(1, 'James', '$2a$11$BP4spDbOG7LewXIWeeWsyugTyvgbMAOCjQ1/P.CLyEMX5gd82Ix9q', 'Dog', '$2a$11$N3TWIsURuKYhCpRMRSTsz.3x/X5HWf.B2hia8bT0PQxQNGoQ5JklW', 'Accepted'),
(2, 'Senpai', '$2a$11$H57TjDWcsBDgVYLh8pFquOgAZnWtQpXhPMUvy5jife0MQJOl/C0z.', 'Dog', '$2a$11$PcZi5Fi5c7f8IGJsJq8.WOIT6Pq9KGBBlXzrbeV0A7fXTODRf0mvS', 'Accepted');

-- --------------------------------------------------------

--
-- Table structure for table `addonservices`
--

CREATE TABLE `addonservices` (
  `AddOnID` int(11) NOT NULL,
  `ServiceName` varchar(100) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `BillingType` enum('Per Session','Monthly') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `addonservices`
--

INSERT INTO `addonservices` (`AddOnID`, `ServiceName`, `Price`, `BillingType`) VALUES
(1, 'Personal Training', 750.00, 'Per Session'),
(2, 'Nutrient Coach', 800.00, 'Per Session'),
(3, 'Locker Rent', 500.00, 'Monthly');

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `AttendanceID` int(11) NOT NULL,
  `MemberID` int(11) DEFAULT NULL,
  `CheckInTime` datetime DEFAULT NULL,
  `CheckOutTime` datetime DEFAULT NULL,
  `AttendanceCount` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`AttendanceID`, `MemberID`, `CheckInTime`, `CheckOutTime`, `AttendanceCount`) VALUES
(1, 1, '2025-08-28 06:14:01', '2025-08-28 06:15:51', 'Day 1');

-- --------------------------------------------------------

--
-- Table structure for table `gymequipment`
--

CREATE TABLE `gymequipment` (
  `EquipmentID` int(11) NOT NULL,
  `EquipmentName` varchar(100) NOT NULL,
  `Category` varchar(50) DEFAULT NULL,
  `PurchaseDate` date DEFAULT NULL,
  `ConditionStatus` enum('Good','Needs Repair','Out of Service') DEFAULT 'Good'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `memberaddons`
--

CREATE TABLE `memberaddons` (
  `MemberAddOnID` int(11) NOT NULL,
  `MemberID` int(11) DEFAULT NULL,
  `AddOnID` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `MemberID` int(11) NOT NULL,
  `FullName` varchar(255) NOT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `ContactNo` varchar(20) DEFAULT NULL,
  `EmergencyContact` varchar(20) DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `DateOfRegistration` date DEFAULT curdate(),
  `PlanID` int(11) DEFAULT NULL,
  `BillingFrequency` enum('Monthly','Quarterly','One Time') DEFAULT NULL,
  `Status` enum('Active','Expired') DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`MemberID`, `FullName`, `Email`, `ContactNo`, `EmergencyContact`, `BirthDate`, `Address`, `DateOfRegistration`, `PlanID`, `BillingFrequency`, `Status`) VALUES
(1, 'asdfsfsd', 'fddsfsdfsd', '6165165', '234554534', '1995-07-08', 'wefwefwef', '2025-08-08', 3, 'Monthly', 'Active'),
(2, 'rerergeg', 'ergergerg', '4535476432', '245544322', '1994-06-08', 'ertnwd2435dfdsd', '2025-08-08', 4, 'Monthly', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `membershipplans`
--

CREATE TABLE `membershipplans` (
  `PlanID` int(11) NOT NULL,
  `PlanName` varchar(50) NOT NULL,
  `DurationMonths` int(11) NOT NULL,
  `Price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `membershipplans`
--

INSERT INTO `membershipplans` (`PlanID`, `PlanName`, `DurationMonths`, `Price`) VALUES
(1, 'Monthly', 1, 2000.00),
(2, '3 Months', 3, 5500.00),
(3, '6 Months', 6, 10500.00),
(4, 'Annual', 12, 19500.00);

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `PaymentID` int(11) NOT NULL,
  `MemberID` int(11) DEFAULT NULL,
  `Amount` decimal(10,2) NOT NULL,
  `PaymentDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `PaymentType` enum('Downpayment','Balance','AddOn') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `addonservices`
--
ALTER TABLE `addonservices`
  ADD PRIMARY KEY (`AddOnID`);

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`AttendanceID`),
  ADD KEY `MemberID` (`MemberID`);

--
-- Indexes for table `gymequipment`
--
ALTER TABLE `gymequipment`
  ADD PRIMARY KEY (`EquipmentID`);

--
-- Indexes for table `memberaddons`
--
ALTER TABLE `memberaddons`
  ADD PRIMARY KEY (`MemberAddOnID`),
  ADD KEY `MemberID` (`MemberID`),
  ADD KEY `AddOnID` (`AddOnID`);

--
-- Indexes for table `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`MemberID`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD KEY `PlanID` (`PlanID`);

--
-- Indexes for table `membershipplans`
--
ALTER TABLE `membershipplans`
  ADD PRIMARY KEY (`PlanID`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`PaymentID`),
  ADD KEY `MemberID` (`MemberID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `addonservices`
--
ALTER TABLE `addonservices`
  MODIFY `AddOnID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `AttendanceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `gymequipment`
--
ALTER TABLE `gymequipment`
  MODIFY `EquipmentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `memberaddons`
--
ALTER TABLE `memberaddons`
  MODIFY `MemberAddOnID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `MemberID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `membershipplans`
--
ALTER TABLE `membershipplans`
  MODIFY `PlanID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`MemberID`) REFERENCES `members` (`MemberID`);

--
-- Constraints for table `memberaddons`
--
ALTER TABLE `memberaddons`
  ADD CONSTRAINT `memberaddons_ibfk_1` FOREIGN KEY (`MemberID`) REFERENCES `members` (`MemberID`),
  ADD CONSTRAINT `memberaddons_ibfk_2` FOREIGN KEY (`AddOnID`) REFERENCES `addonservices` (`AddOnID`);

--
-- Constraints for table `members`
--
ALTER TABLE `members`
  ADD CONSTRAINT `members_ibfk_1` FOREIGN KEY (`PlanID`) REFERENCES `membershipplans` (`PlanID`);

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`MemberID`) REFERENCES `members` (`MemberID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
