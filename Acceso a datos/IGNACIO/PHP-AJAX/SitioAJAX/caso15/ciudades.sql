-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-05-2019 a las 15:17:45
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ajax`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ciudades`
--

CREATE TABLE `ciudades` (
  `codCiudad` smallint(6) NOT NULL,
  `codPais` char(3) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ciudades`
--

INSERT INTO `ciudades` (`codCiudad`, `codPais`, `nombre`) VALUES
(1, 'BEL', 'Bruselas'),
(2, 'BEL', 'Brujas'),
(3, 'DEU', 'Berlín'),
(4, 'DEU', 'Hamburgo'),
(5, 'DEU', 'Munich'),
(6, 'ESP', 'Madrid'),
(7, 'ESP', 'Barcelona'),
(8, 'ESP', 'Zaragoza'),
(9, 'ESP', 'Bilbao'),
(10, 'ESP', 'Sevilla'),
(11, 'ITA', 'Roma'),
(12, 'ITA', 'Verona'),
(13, 'ITA', 'Nápoles'),
(14, 'ITA', 'Pádova'),
(15, 'BRA', 'Río de Janeiro'),
(16, 'BRA', 'Brasilia'),
(17, 'ALB', 'Tirana'),
(18, 'AFG', 'Kabul'),
(19, 'MEX', 'México'),
(20, 'MEX', 'Mérida'),
(21, 'MEX', 'Tijuana'),
(22, 'JPN', 'Osaka'),
(23, 'JPN', 'Tokio'),
(24, 'JPN', 'Yokohama'),
(25, 'JPN', 'Kioto'),
(26, 'JPN', 'Nagasaki');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `ciudades`
--
ALTER TABLE `ciudades`
  ADD PRIMARY KEY (`codCiudad`),
  ADD KEY `ix_pais` (`codPais`) USING BTREE;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `ciudades`
--
ALTER TABLE `ciudades`
  ADD CONSTRAINT `fk_paises` FOREIGN KEY (`codPais`) REFERENCES `paises` (`codPais`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
