-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-05-2019 a las 12:02:09
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
-- Estructura de tabla para la tabla `comentarios`
--

CREATE TABLE `comentarios` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `fecha` date NOT NULL,
  `comentarios` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `comentarios`
--

INSERT INTO `comentarios` (`codigo`, `nombre`, `fecha`, `comentarios`) VALUES
(1, 'ignacio', '2019-05-01', 'No me lo puedo creer.'),
(2, 'Pili', '2019-05-02', 'No me parece normal'),
(3, 'Marian', '2019-05-06', 'La niña tiene tela.'),
(4, 'Roman', '2019-05-06', 'Me encanta ver este tipo de videos'),
(5, 'Benita', '2019-05-07', 'No me parece razonable para la causa animal.'),
(6, 'Roberta', '2019-05-08', 'Espero que nadie vuelva a realizar videos como este'),
(7, 'Miren', '2019-05-08', 'Me encantan sus narices.'),
(8, 'Kino', '2019-05-09', 'la familia no tiene desperdicio. me los comería.'),
(9, 'Casildo', '2019-05-10', 'No entiendo el mensaje del autor.');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `comentarios`
--
ALTER TABLE `comentarios`
  ADD PRIMARY KEY (`codigo`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
