-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 14 Jun 2016 pada 11.46
-- Versi Server: 5.6.20
-- PHP Version: 5.5.15

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
-- Struktur dari tabel `lainnya`
--

CREATE TABLE IF NOT EXISTS `lainnya` (
  `no_transaksi` float NOT NULL,
  `no_admin` int(11) NOT NULL,
  `no_karyawan` int(11) NOT NULL,
  `no_obat` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `lainnya`
--

INSERT INTO `lainnya` (`no_transaksi`, `no_admin`, `no_karyawan`, `no_obat`) VALUES
(36, 7, 26, 7);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_admin`
--

CREATE TABLE IF NOT EXISTS `tb_admin` (
  `id_admin` varchar(15) NOT NULL,
  `password` varchar(50) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_admin`
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
-- Struktur dari tabel `tb_detil_transaksi`
--

CREATE TABLE IF NOT EXISTS `tb_detil_transaksi` (
  `id_transaksi` varchar(50) NOT NULL,
  `id_obat` varchar(50) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `sub_total` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_detil_transaksi`
--

INSERT INTO `tb_detil_transaksi` (`id_transaksi`, `id_obat`, `jumlah`, `sub_total`) VALUES
('TS-31', 'OBT-2', 21345, '85380'),
('TS-31', 'OBT-7', 12342, '3998808'),
('TS-32', 'OBT-5', 2, '6'),
('TS-32', 'OBT-6', 234567, '28851741'),
('TS-33', 'OBT-2', 4, '16'),
('TS-34', 'OBT-2', 3, '12'),
('TS-34', 'OBT-5', 5, '15'),
('TS-35', 'OBT-2', 2, '8'),
('TS-36', 'OBT-2', 2, '8'),
('TS-36', 'OBT-5', 3, '9');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_karyawan`
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
-- Dumping data untuk tabel `tb_karyawan`
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
-- Struktur dari tabel `tb_obat`
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
-- Dumping data untuk tabel `tb_obat`
--

INSERT INTO `tb_obat` (`id_obat`, `nama_obat`, `jenis_obat`, `stock`, `harga_beli`, `harga_jual`, `keterangan`) VALUES
('OBT-1', 'arewr', 'ewrwer', 12323, 432423, 2, 'sdgfsd'),
('OBT-2', 'fsds', 'fsd', 6, 342342, 4, '231'),
('OBT-5', 'sdffsf', 'sdfsfd1', 17, 42342, 3, 'gfdgxsd'),
('OBT-6', 'ewrew', 'rewrew', 0, 21321, 123, '32'),
('OBT-7', 'dsfsd', 'sfds', 34, 432, 324, '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_transaksi`
--

CREATE TABLE IF NOT EXISTS `tb_transaksi` (
  `id_transaksi` varchar(50) NOT NULL,
  `id_karyawan` varchar(15) NOT NULL,
  `tgl_transaksi` date NOT NULL,
  `nama_pelanggan` varchar(50) NOT NULL,
  `hp_pelanggan` varchar(15) NOT NULL,
  `harga_total` varchar(100) NOT NULL,
  `bayar` varchar(100) NOT NULL,
  `kembali` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_transaksi`
--

INSERT INTO `tb_transaksi` (`id_transaksi`, `id_karyawan`, `tgl_transaksi`, `nama_pelanggan`, `hp_pelanggan`, `harga_total`, `bayar`, `kembali`) VALUES
('TS-1', 'AD-1', '2016-06-12', 'sdgfds', '3254325', '0.999999999999999', '0.999999999999999', '0.999999999999999'),
('TS-10', 'Selamat Datang', '2016-06-14', 'fdefe', '34535', '1.289000000000000', '2.222000000000000', '9.999999999999999'),
('TS-11', 'Selamat Datang', '2016-06-12', 'sfdsdf', '2432432', '2.521000000000000', '3.500000000000000', '9.999999999999999'),
('TS-12', 'Selamat Datang', '2016-06-12', '323323', '2323423', '2.521.839', '3.230.000', '708.161'),
('TS-16', 'Selamat Datang', '2016-06-12', 'sfdsfd', '4224323', '1.285.285.292', '2.222.222.222', '936.936.930'),
('TS-17', 'Selamat Datang', '2016-06-12', 'dfsfsdf`', '32432', '62.642.642', '323.232.323', '260.589.681'),
('TS-18', 'Selamat Datang', '2016-06-12', 'sda', '243234', '892', '3.233', '2.341'),
('TS-19', 'KR-26', '2016-06-14', 'mahrus', '0243342', '1.824.492', '2.000.000', '175.508'),
('TS-20', 'KR-26', '2016-06-12', 'msnbdkjwb', '231213', '36.494.934', '111.111.111', '74.616.177'),
('TS-21', 'Selamat Datang', '2016-06-13', 'mahrus', '24234232', '15.656.630', '20.000.000', '4.343.370'),
('TS-22', 'Selamat Datang', '2016-06-16', 'm,wnfkjfhb', '0937', '4.920', '5.000', '80'),
('TS-25', 'Selamat Datang', '2016-06-13', 'mmm', '342342', '4.256.049', '5.000.000', '743.951'),
('TS-27', 'Selamat Datang', '2016-06-13', 'mahrus', '0089779798', '7.839', '10.000', '2.161'),
('TS-29', 'Selamat Datang', '2016-06-13', 'ghcvjbknlm', '23456789', '1.285.692', '1.400.000', '114.308'),
('TS-3', 'AD-1', '2016-06-12', '342', '424', '0.000000000000000', '0.000000000000000', '0.000000000000000'),
('TS-30', 'Selamat Datang', '2016-06-13', 'ghfvjkl', '658736', '93.669', '324.288', '230.619'),
('TS-31', 'Selamat Datang', '2016-06-13', 'mahdsf', '768473', '4.084.188', '4.500.000', '415.812'),
('TS-32', 'Selamat Datang', '2016-06-13', 'mnsdmsnd', '25472635', '28.851.747', '30.000.000', '1.148.253'),
('TS-33', 'Selamat Datang', '2016-06-14', 'ghjljhg', '546789', '16', '122', '106'),
('TS-34', 'Selamat Datang', '2016-06-14', 'fghjkl', '234567', '27', '30', '3'),
('TS-35', 'Selamat Datang', '2016-06-14', 'mah', '8989', '17', '20', '3'),
('TS-36', 'Selamat Datang', '2016-06-14', 'segdhfjkghljm', '1234567', '17', '20', '3'),
('TS-4', 'AD-1', '2016-06-12', 'vfsdv', '1234', '0.999999999999999', '0.999999999999999', '0.999999999999999'),
('TS-5', 'AD-1', '2016-06-12', 'xzzczc', '4234243', '0.999999999999999', '0.999999999999999', '0.999999999999999'),
('TS-7', 'Selamat Datang', '2016-06-12', 'wewfe', '2342342', '0.999999999999999', '0.999999999999999', '0.999999999999999'),
('TS-8', 'Selamat Datang', '2016-06-12', 'fsdfsds', '324324243', '0.999999999999999', '0.999999999999999', '0.999999999999999'),
('TS-9', 'Selamat Datang', '2016-06-12', 'dewdwe', '432432', '0.999999999999999', '0.999999999999999', '0.999999999999999');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_admin`
--
ALTER TABLE `tb_admin`
 ADD PRIMARY KEY (`id_admin`);

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
