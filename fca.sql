-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 10-12-2023 a las 06:49:56
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `fca`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE `alumnos` (
  `matricula` int(8) NOT NULL,
  `nombre` varchar(70) NOT NULL,
  `apellido_paterno` varchar(50) NOT NULL,
  `apellido_materno` varchar(50) NOT NULL,
  `edad` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`matricula`, `nombre`, `apellido_paterno`, `apellido_materno`, `edad`) VALUES
(12003332, 'MANUEL\r\n', 'PECH', 'EK', '22'),
(16003226, 'AIDY\r\n', 'MAY', 'VERDE', '23'),
(17000601, 'LUIS', 'CASTILLO', 'GALEANA', '23'),
(17003610, 'SAUL\r\n', 'POOL', 'LOPEZ', '25'),
(19211571, 'ABRAHAM\r\n', 'PUCH', 'KUK', '23'),
(19211574, 'ANA', 'ROBERTOS', 'RODRIGUEZ', '24'),
(19211646, 'MONICA\r\n', 'PECH', 'MAAS', '24'),
(20211400, 'WILBERT \r\n', 'AKE', 'BERZUNZA', '22'),
(20211404, 'DIEGO\r\n', 'CETZ', 'DOMINGUEZ', '24'),
(20211406, 'DAMIAN\r\n', 'DZUL', 'GAMBOA', '22'),
(20211407, 'FATIMA\r\n', 'GARCIA', 'ECHEVERRIA', '25'),
(20211413, 'GLIDER\r\n', 'ORTEGA', 'CASTILLO', '24'),
(20211700, 'CARLOS\r\n', 'OROZCO', 'UCAN', '25'),
(20211705, 'CHARLIE\r\n', 'POOL', 'DZUL', '24');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `servicios`
--

CREATE TABLE `servicios` (
  `idServicio` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion` varchar(250) NOT NULL,
  `horarios` varchar(250) NOT NULL,
  `horariosVirtuales` varchar(80) NOT NULL,
  `horariosPresenciales` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `servicios`
--

INSERT INTO `servicios` (`idServicio`, `nombre`, `descripcion`, `horarios`, `horariosVirtuales`, `horariosPresenciales`) VALUES
(1, 'Constancias diversas', 'Se entregan constancias de manera presencial o virtual dependiendo el caso', 'Lunes a viernes de 9:00 a 18:00 horas', 'Lunes a miércoles de 9:00 a 18:00 horas', 'Jueves a viernes de 8:00 a 19:00 horas'),
(2, 'Afiliación del seguro facultativo del IMSS', 'Se realiza la afiliación al seguro del IMSS', 'Lunes a jueves de 7:00 a 14:00 horas', 'Lunes a miércoles de 7:00 a 14:00 horas', 'Jueves a Viernes de 9:00 a 14:00 horas'),
(3, 'Entrega de kardex', 'Se realiza la entrega de kardex de manera presencial en la facultad ', 'Viernes de 8:00 a 15:00 horas', 'Viernes de 8:00 a 15:00 horas', 'Lunes a jueves de 9:00 a 14:00 horas'),
(4, 'Historial académico', 'Se realiza la entrega de historial académico en la facultad ', 'Lunes a viernes de 8:00 a 14:00 horas', 'Lunes a miércoles de 8:00 a 14:00 horas', 'Jueves a viernes de 10:00 a 14:00 horas'),
(5, 'Certificados ', 'Se realiza la entrega de certificados de manera presencial, parciales o completos', 'Lunes a miércoles de 8:00 a 14:00 horas ', 'Lunes a miércoles de 8:00 a 14:00 horas ', 'Jueves a viernes de 10:00 a 14:00 horas '),
(6, 'Situación académica', 'Se realiza carta de situación académica entregada de manera presencial', 'Lunes a viernes de 8:00 a 16:00 horas', 'Lunes a miércoles de 8:00 a 16:00 horas', 'Jueves a viernes de 11:00 a 16:00 horas');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD PRIMARY KEY (`matricula`);

--
-- Indices de la tabla `servicios`
--
ALTER TABLE `servicios`
  ADD PRIMARY KEY (`idServicio`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `servicios`
--
ALTER TABLE `servicios`
  MODIFY `idServicio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
