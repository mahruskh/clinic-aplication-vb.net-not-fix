-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 19, 2016 at 11:35 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `klinik_andi`
--

-- --------------------------------------------------------

--
-- Table structure for table `lainnya`
--

CREATE TABLE IF NOT EXISTS `lainnya` (
  `no_transaksi` float NOT NULL,
  `no_admin` tinyint(4) NOT NULL,
  `no_karyawan` tinyint(4) NOT NULL,
  `no_obat` float NOT NULL,
  `no_asistant` smallint(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `lainnya`
--

INSERT INTO `lainnya` (`no_transaksi`, `no_admin`, `no_karyawan`, `no_obat`, `no_asistant`) VALUES
(52, 7, 26, 7, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tb_admin`
--

CREATE TABLE IF NOT EXISTS `tb_admin` (
  `id_admin` varchar(15) NOT NULL,
  `password` varchar(50) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_admin`
--

INSERT INTO `tb_admin` (`id_admin`, `password`, `nama`, `keterangan`) VALUES
('A1', 'sasasa', '', '0'),
('AD-1', 'kh', 'HAHHAHHA', ''),
('AD-7', 'sdfsfsdf', 'sdfsfd', ''),
('ADM-1', '', '', '0'),
('ADM-5', 'adswfdw', 'wfewf', 'fweef'),
('ADM-6', 'dbfns', 'ngsnfs', 'ngsfng');

-- --------------------------------------------------------

--
-- Table structure for table `tb_asistant`
--

CREATE TABLE IF NOT EXISTS `tb_asistant` (
  `id_asistant` varchar(50) NOT NULL,
  `password` varchar(80) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `hp` varchar(15) NOT NULL,
  `alamat` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_asistant`
--

INSERT INTO `tb_asistant` (`id_asistant`, `password`, `nama`, `hp`, `alamat`) VALUES
('AS-1', 'kh', 'fgsdfgdfg', '53434', 'gdfgd');

-- --------------------------------------------------------

--
-- Table structure for table `tb_detil_transaksi`
--

CREATE TABLE IF NOT EXISTS `tb_detil_transaksi` (
  `id_transaksi` varchar(50) NOT NULL,
  `id_obat` varchar(50) NOT NULL,
  `id_asistant` varchar(50) NOT NULL,
  `id_karyawan` varchar(50) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `sub_total` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_detil_transaksi`
--

INSERT INTO `tb_detil_transaksi` (`id_transaksi`, `id_obat`, `id_asistant`, `id_karyawan`, `jumlah`, `sub_total`) VALUES
('TS-31', 'OBT-2', '', '', 21345, '85380'),
('TS-31', 'OBT-7', '', '', 12342, '3998808'),
('TS-32', 'OBT-5', '', '', 2, '6'),
('TS-32', 'OBT-6', '', '', 234567, '28851741'),
('TS-33', 'OBT-2', '', '', 4, '16'),
('TS-34', 'OBT-2', '', '', 3, '12'),
('TS-34', 'OBT-5', '', '', 5, '15'),
('TS-35', 'OBT-2', '', '', 2, '8'),
('TS-36', 'OBT-2', '', '', 2, '8'),
('TS-36', 'OBT-5', '', '', 3, '9'),
('TS-37', 'OBT-1', '', '', 2, '4'),
('TS-38', 'OBT-1', '', '', 2, '4'),
('TS-39', 'OBT-1', '', '', 23, '46'),
('TS-39', 'OBT-5', '', '', 34, '102'),
('TS-39', 'OBT-2', '', '', 23, '92'),
('TS-40', 'OBT-2', '', '', 22, '88'),
('TS-40', 'OBT-7', '', '', 2, '648'),
('TS-41', 'OBT-1', '', '', 2, '4'),
('TS-42', 'OBT-7', '', '', 3, '972'),
('TS-42', 'OBT-5', '', '', 3, '9'),
('TS-43', 'OBT-1', '', '', 2, '4'),
('TS-43', 'OBT-5', '', '', 21, '63'),
('TS-44', 'OBT-1', '', '', 2, '4'),
('TS-45', 'OBT-2', '', '', 2, '8'),
('TS-46', 'OBT-1', '', '', 2, '4'),
('TS-46', 'OBT-5', '', '', 231, '693'),
('TS-47', 'OBT-1', '', '', 323, '646'),
('TS-48', 'OBT-2', '', '', 2, '8'),
('TS-49', 'OBT-1', 'Selamat Datang', '', 1, '2'),
('TS-49', 'OBT-7', 'Selamat Datang', '', 34234, '11091816'),
('TS-50', 'OBT-2', 'Selamat Datang', '', 342, '1368'),
('TS-50', 'OBT-5', 'Selamat Datang', '', 4, '12'),
('TS-51', 'OBT-5', 'KR-26', '', 2, '6'),
('TS-51', 'OBT-5', 'KR-26', '', 23, '69'),
('TS-51', 'OBT-2', 'KR-26', '', 1, '4'),
('TS-51', 'OBT-5', 'KR-26', '', 32, '96'),
('TS-52', 'OBT-2', 'AS-1', '', 324, '1296'),
('TS-52', 'OBT-6', 'AS-1', '', 3, '369');

-- --------------------------------------------------------

--
-- Table structure for table `tb_karyawan`
--

CREATE TABLE IF NOT EXISTS `tb_karyawan` (
  `id_karyawan` varchar(15) NOT NULL,
  `password` varchar(50) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(15) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `hp` varchar(20) NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_karyawan`
--

INSERT INTO `tb_karyawan` (`id_karyawan`, `password`, `nama`, `jenis_kelamin`, `alamat`, `hp`, `keterangan`) VALUES
('KR-23', 'gfdgf', 'fgdfd', 'Laki - Laki', 'fgdfgd', 'gfdgd', 'gfdg'),
('KR-24', 'dfsfds', 'fdsfd', 'Laki - Laki', 'fdsfdfds', 'dsfds', 'fsfds'),
('KR-26', 'kh', 'mahrus', 'Laki - Laki', 'fefrer', '32535', 'mhndgfrghdjfkjh'),
('KR10', 'oig9', 'Ini Dia namnya', 'Laki - Laki', 'fds', 'fds', 'sdfs'),
('KR16', 'pere', 'wanita', 'Perempuan', 'dfsdf', 'sdfs', 'dfsf'),
('KR5', '23213', 'sdadsa', 'Laki - Laki', '0', '0', 'dsadsa'),
('KR8', 'fdsfs', 'fdsfs', 'Perempuan', '0', '0', 'fsf'),
('KR9', 'ddsa', 'Siapa ini', 'Perempuan', 'sdasda', 'adsa', 'dsadsa');

-- --------------------------------------------------------

--
-- Table structure for table `tb_obat`
--

CREATE TABLE IF NOT EXISTS `tb_obat` (
  `id_obat` varchar(50) NOT NULL,
  `nama_obat` varchar(100) NOT NULL,
  `jenis_obat` varchar(100) NOT NULL,
  `stock` int(11) NOT NULL,
  `harga_beli` float NOT NULL,
  `harga_jual` float NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_obat`
--

INSERT INTO `tb_obat` (`id_obat`, `nama_obat`, `jenis_obat`, `stock`, `harga_beli`, `harga_jual`, `keterangan`) VALUES
('OBT-1', 'arewr', 'ewrwer', 11964, 432423, 2, 'sdgfsd'),
('OBT-2', 'fsds', 'fsd', -305, 342342, 4, '231'),
('OBT-5', 'sdffsf', 'sdfsfd1', -38, 42342, 3, 'gfdgxsd'),
('OBT-6', 'ewrew', 'rewrew', 18, 21321, 123, '32'),
('OBT-7', 'dsfsd', 'sfds', 213, 432, 324, '');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pelanggan`
--

CREATE TABLE IF NOT EXISTS `tb_pelanggan` (
  `nama_pelanggan` varchar(50) NOT NULL,
  `tgl_lahir_pelanggan` date NOT NULL,
  `hp` varchar(15) NOT NULL,
  `alamat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_pelanggan`
--

INSERT INTO `tb_pelanggan` (`nama_pelanggan`, `tgl_lahir_pelanggan`, `hp`, `alamat`) VALUES
('Dani', '2016-06-19', '0384924382342', 'goallllll'),
('doyok', '2016-06-19', '984329048', 'jihjukibshbijhbsfjkdnbjfkdnvfnfjnvjfjfvjfn');

-- --------------------------------------------------------

--
-- Table structure for table `tb_transaksi`
--

CREATE TABLE IF NOT EXISTS `tb_transaksi` (
  `id_transaksi` varchar(50) NOT NULL,
  `id_asistant` varchar(50) NOT NULL,
  `id_karyawan` varchar(15) NOT NULL,
  `nama_pelanggan` varchar(50) NOT NULL,
  `alamat_pelanggan` varchar(50) NOT NULL,
  `tgl_transaksi` date NOT NULL,
  `harga_total` varchar(100) NOT NULL,
  `bayar` varchar(100) NOT NULL,
  `kembali` varchar(100) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_transaksi`
--

INSERT INTO `tb_transaksi` (`id_transaksi`, `id_asistant`, `id_karyawan`, `nama_pelanggan`, `alamat_pelanggan`, `tgl_transaksi`, `harga_total`, `bayar`, `kembali`, `status`) VALUES
('TS-1', '', 'AD-1', '', '', '2016-06-12', '0.999999999999999', '0.999999999999999', '0.999999999999999', ''),
('TS-10', '', 'Selamat Datang', '', '', '2016-06-14', '1.289000000000000', '2.222000000000000', '9.999999999999999', ''),
('TS-11', '', 'Selamat Datang', '', '', '2016-06-12', '2.521000000000000', '3.500000000000000', '9.999999999999999', ''),
('TS-12', '', 'Selamat Datang', '', '', '2016-06-12', '2.521.839', '3.230.000', '708.161', ''),
('TS-16', '', 'Selamat Datang', '', '', '2016-06-12', '1.285.285.292', '2.222.222.222', '936.936.930', ''),
('TS-17', '', 'Selamat Datang', '', '', '2016-06-12', '62.642.642', '323.232.323', '260.589.681', ''),
('TS-18', '', 'Selamat Datang', '', '', '2016-06-12', '892', '3.233', '2.341', ''),
('TS-19', '', 'KR-26', '', '', '2016-06-14', '1.824.492', '2.000.000', '175.508', ''),
('TS-20', '', 'KR-26', '', '', '2016-06-12', '36.494.934', '111.111.111', '74.616.177', ''),
('TS-21', '', 'Selamat Datang', '', '', '2016-06-13', '15.656.630', '20.000.000', '4.343.370', ''),
('TS-31', '', 'Selamat Datang', '', '', '2016-06-13', '4.084.188', '4.500.000', '415.812', ''),
('TS-32', '', 'Selamat Datang', '', '', '2016-06-13', '28.851.747', '30.000.000', '1.148.253', ''),
('TS-33', '', 'Selamat Datang', '', '', '2016-06-14', '16', '122', '106', ''),
('TS-34', '', 'Selamat Datang', '', '', '2016-06-14', '27', '30', '3', ''),
('TS-35', '', 'Selamat Datang', '', '', '2016-06-14', '17', '20', '3', ''),
('TS-36', '', 'Selamat Datang', '', '', '2016-06-14', '17', '20', '3', ''),
('TS-39', '', 'KR-26', '', '', '2016-06-15', '240', '141,234', '140,994', ''),
('TS-4', '', 'AD-1', '', '', '2016-06-12', '0.999999999999999', '0.999999999999999', '0.999999999999999', ''),
('TS-40', 'Selamat Datang', '', '', '', '2016-06-18', '736', '', '', 'BB'),
('TS-41', 'Selamat Datang', '', '', '', '2016-06-18', '4', '', '', 'BB'),
('TS-42', 'Selamat Datang', '', '', '', '2016-06-18', '981', '', '', 'BB'),
('TS-43', 'Selamat Datang', '', '', '', '2016-06-18', '67', '', '', 'BB'),
('TS-44', 'Selamat Datang', '', '', '', '2016-06-18', '4', '', '', 'BB'),
('TS-45', 'Selamat Datang', '', '', '', '2016-06-18', '8', '', '', 'BB'),
('TS-46', 'Selamat Datang', '', '', '', '2016-06-18', '697', '', '', 'BB'),
('TS-47', 'Selamat Datang', '', '', '', '2016-06-18', '646', '', '', 'Belum Bayar'),
('TS-48', 'Selamat Datang', 'Selamat Datang', 'rtyrtuye', 'yterytert', '2016-06-18', '8', '12', '4', 'Sudah Bayar'),
('TS-49', 'Selamat Datang', 'Selamat Datang', 'fewfe', 'fewfewfewe43', '2016-06-18', '11,091,818', '12,000,000', '908,182', 'Belum Bayar'),
('TS-5', '', 'AD-1', 'mamamsdwe', 'fewe', '2016-06-12', '0.999999999999999', '0.999999999999999', '0.999999999999999', ''),
('TS-50', 'Selamat Datang', 'Selamat Datang', 'Dani', 'goallllll', '2016-06-19', '1,380', '2,000', '620', 'Belum Bayar'),
('TS-51', 'KR-26', '', 'doyok', 'jihjukibshbijhbsfjkdnbjfkdnvfnfjnvjfjfvjfn', '2016-06-19', '175', '', '', 'Belum Bayar'),
('TS-52', 'AS-1', 'KR-26', 'doyok', 'jihjukibshbijhbsfjkdnbjfkdnvfnfjnvjfjfvjfn', '2016-06-19', '1,665', '2,000', '335', 'Sudah Bayar'),
('TS-7', '', 'Selamat Datang', '', '', '2016-06-12', '0.999999999999999', '0.999999999999999', '0.999999999999999', ''),
('TS-8', '', 'Selamat Datang', '', '', '2016-06-12', '0.999999999999999', '0.999999999999999', '0.999999999999999', ''),
('TS-9', '', 'Selamat Datang', '', '', '2016-06-12', '0.999999999999999', '0.999999999999999', '0.999999999999999', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `lainnya`
--
ALTER TABLE `lainnya`
 ADD PRIMARY KEY (`no_transaksi`), ADD UNIQUE KEY `no_admin` (`no_admin`);

--
-- Indexes for table `tb_admin`
--
ALTER TABLE `tb_admin`
 ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `tb_asistant`
--
ALTER TABLE `tb_asistant`
 ADD PRIMARY KEY (`id_asistant`);

--
-- Indexes for table `tb_karyawan`
--
ALTER TABLE `tb_karyawan`
 ADD PRIMARY KEY (`id_karyawan`);

--
-- Indexes for table `tb_obat`
--
ALTER TABLE `tb_obat`
 ADD PRIMARY KEY (`id_obat`);

--
-- Indexes for table `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
 ADD PRIMARY KEY (`id_transaksi`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
