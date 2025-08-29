-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1: 3307
-- Waktu pembuatan: 02 Jul 2022 pada 14.06
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.0.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `siakadd3`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `NIM` varchar(12) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Nama_Mahasiswa` varchar(255) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Th_Ajaran` text CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Jenis_Kelamin` varchar(30) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `TTL` varchar(100) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Agama` varchar(30) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `SMU_Asal` varchar(100) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `NEM` decimal(10,0) NOT NULL,
  `Alamat` varchar(255) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Status_Lulus` varchar(30) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Nama_Ortu` varchar(50) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Pekerjaan` varchar(255) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Alamat_Ortu` varchar(300) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `mahasiswa`
--

INSERT INTO `mahasiswa` (`NIM`, `Nama_Mahasiswa`, `Th_Ajaran`, `Jenis_Kelamin`, `TTL`, `Agama`, `SMU_Asal`, `NEM`, `Alamat`, `Status_Lulus`, `Nama_Ortu`, `Pekerjaan`, `Alamat_Ortu`) VALUES
('403211010012', 'Muhammad Nur Latif', '2021/2022', 'Male', 'Tembilahan, 09 September 2002', 'Islam', 'MA NURISSALAM', '9', 'Jl Pelajar', 'L', 'Baharuddin', 'Tokeh Sawit', 'Jl Pelajar'),
('403211010013', 'Kasmawati', '2021/2022', 'Female', 'Kotabaru, 13 Mei 2003', 'Islam', 'MA NURUL WATHAN', '8', 'Jl Sapta Marga', 'L', 'M Aras', 'Petani', 'Parit Bidadari'),
('403211010044', 'Lusy Rahmadayanti', '2021/2022', 'Female', 'Tembilahan, 02 Jaanuari 1998', 'Islam', 'MAN 1 INHIL', '5', 'Jl M Boya Lr Kenanga', 'L', 'Bulkis', 'Petani', 'Jl M Boya Lr Kenanga'),
('403211010045', 'Maudya Nisa', '2021/2022', 'Female', 'Tembilahan, 20 Desember 2003', 'Islam', 'SMA 1 ATAP BELENGKONG', '9', 'Jl Kemang Lr Durian', 'L', 'Abdullah', 'Karyawan', 'Teluk Belengkong'),
('403211010056', 'Putri Yunita', '2021/2022', 'Female', 'Tembilahan, 19 Agustus 2003', 'Islam', 'Man 1 Inhil', '7', 'Jl Bersama', 'L', 'Arhan', 'Pegawai', 'Jl Bersama'),
('403211010060', 'Ferran Danish', '2021/2022', 'Male', 'Tembilahan, 10 Januari 2002', 'Islam', 'MA NURISSALAM', '5', 'Jl Lingkar', 'L', 'Wahid', 'Pegawai Negeri Sipil', 'Jl Lingkar'),
('403211010066', 'M Gema  Maulana', '2021/2022', 'Male', 'Tembilahan, 04 Maret 2003', 'Islam', 'MAN 1 INHIL', '6', 'Jl M Boya Lr Kenanga', 'L', 'Bulkis', 'Petani', 'Jl M Boya Lr Kenanga'),
('403211010069', 'M Ridwan', '2021/2022', 'Male', 'Sungai Guntung, 17 Maret 2003', 'Islam', 'Sma Teluk Kelasa', '7', 'Jl Sabilal', 'L', 'Abdullah', 'Petani', 'Teluk Kelasa'),
('403211020076', 'Muhammad Nurissalam', '2021/2022', 'Male', 'Rengat 24 April 2003', 'Islam', 'MAN 1 INHU', '5', 'Jl Nangka', 'L', 'Badrun', 'Pedagang', 'Jl Nangka');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`NIM`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
