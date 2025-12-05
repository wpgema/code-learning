-- phpMyAdmin SQL Dump
-- version 5.2.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 05, 2025 at 08:21 AM
-- Server version: 8.0.42
-- PHP Version: 8.3.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbgolang`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int NOT NULL,
  `name` varchar(100) NOT NULL,
  `prefix` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `suffix` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `birth_date` date NOT NULL,
  `birth_place` varchar(50) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `religion` varchar(10) NOT NULL,
  `maritial_status` varchar(20) NOT NULL,
  `picture_path` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `prefix`, `suffix`, `birth_date`, `birth_place`, `gender`, `religion`, `maritial_status`, `picture_path`) VALUES
(1, 'M. Gema Maulana', 'Prof. Dr.', 'S. Kom., M. Kom', '2003-01-13', 'Tembilahan', 'Laki-laki', 'Islam', 'Single', '/uploads/profile.jpg'),
(2, 'Ahmad Tamsil', NULL, 'S. Kom., M. Kom', '2003-08-24', 'Tembilahan', 'Laki-laki', 'Islam', 'Single', '/uploads/profile.jpg'),
(3, 'M. Shandito Reynaldi Marwanda', NULL, 'S. Kom', '2003-02-16', 'Rantau Panjang', 'Laki-laki', 'Islam', 'Single', '/uploads/profile.jpg'),
(5, 'Lusy Rahmadayanti', NULL, 'S. Pd', '1998-05-27', 'Tembilahan', 'Perempuan', 'Islam', 'Marriage', '/uploads/profile.jpg'),
(6, 'Amelia Rahayu', NULL, 'S. Ag', '2000-12-19', 'Kuala Lahang', 'Perempuan', 'Islam', 'Marriage', '/uploads/profile.jpg'),
(7, 'Dewi Purwati', NULL, 'S. Pd', '1999-10-22', 'Tempuling', 'Perempuan', 'Islam', 'Single', '/uploads/profile.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
