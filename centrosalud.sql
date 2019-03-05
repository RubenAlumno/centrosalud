-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-03-2019 a las 20:33:31
-- Versión del servidor: 10.1.35-MariaDB
-- Versión de PHP: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `centrosalud`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `citas`
--

CREATE TABLE `citas` (
  `idpaciente` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `idcita` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `citas`
--

INSERT INTO `citas` (`idpaciente`, `fecha`, `hora`, `idcita`) VALUES
(1, '2019-01-25', '14:30:00', 0),
(1, '2019-03-06', '12:42:00', 2),
(1, '2019-03-06', '12:44:00', 2),
(3, '2019-02-08', '11:20:00', 1),
(3, '2019-02-08', '12:20:00', 0),
(3, '2019-03-06', '12:43:00', 2),
(3, '2019-03-07', '12:43:00', 2),
(13, '2019-02-08', '14:25:00', 0),
(13, '2019-03-08', '12:43:00', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `especialidad`
--

CREATE TABLE `especialidad` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `especialidad`
--

INSERT INTO `especialidad` (`id`, `nombre`) VALUES
(5, 'Cabezera'),
(2, 'Neurologo'),
(1, 'Otorrinolaringología');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `especialistas`
--

CREATE TABLE `especialistas` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telefono` varchar(12) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `especialistas`
--

INSERT INTO `especialistas` (`id`, `nombre`, `telefono`) VALUES
(1, 'Pepe Ojo', '555666777999'),
(2, 'Juan Cabeza', '555666777'),
(3, 'Pepe Ojo3', 'eee333333');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `especialistashacenespecialidades`
--

CREATE TABLE `especialistashacenespecialidades` (
  `idespecialidad` int(11) NOT NULL,
  `idespecialista` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `especialistashacenespecialidades`
--

INSERT INTO `especialistashacenespecialidades` (`idespecialidad`, `idespecialista`, `id`) VALUES
(1, 2, 1),
(1, 3, 2),
(2, 2, 0),
(2, 3, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pacientes`
--

CREATE TABLE `pacientes` (
  `id` int(11) NOT NULL,
  `nombreCompleto` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telefono` varchar(12) COLLATE utf8mb4_unicode_ci NOT NULL,
  `direccion` varchar(250) COLLATE utf8mb4_unicode_ci NOT NULL,
  `localidad` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `pacientes`
--

INSERT INTO `pacientes` (`id`, `nombreCompleto`, `telefono`, `direccion`, `localidad`) VALUES
(1, 'Juan Garcia', '555666777', 'Mi direccion', 'Pamplona'),
(3, 'Maria Garcia', '555666777', 'Mi direccion', 'Salamanca'),
(13, 'pepito', '44444', 'rrrr3333444444444', 'tttttt'),
(14, 'juanito', 'eee', 'eee', 'eee'),
(15, 'federico', '444', 'rrrrt', 'tttt');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `citas`
--
ALTER TABLE `citas`
  ADD PRIMARY KEY (`idpaciente`,`fecha`,`hora`,`idcita`),
  ADD KEY `idcita` (`idcita`);

--
-- Indices de la tabla `especialidad`
--
ALTER TABLE `especialidad`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `especialistas`
--
ALTER TABLE `especialistas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `especialistashacenespecialidades`
--
ALTER TABLE `especialistashacenespecialidades`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `idespecialidad` (`idespecialidad`,`idespecialista`),
  ADD KEY `idespecialista` (`idespecialista`);

--
-- Indices de la tabla `pacientes`
--
ALTER TABLE `pacientes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombreCompleto` (`nombreCompleto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `especialidad`
--
ALTER TABLE `especialidad`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `especialistas`
--
ALTER TABLE `especialistas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `pacientes`
--
ALTER TABLE `pacientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `citas`
--
ALTER TABLE `citas`
  ADD CONSTRAINT `citas_ibfk_1` FOREIGN KEY (`idpaciente`) REFERENCES `pacientes` (`id`),
  ADD CONSTRAINT `citas_ibfk_2` FOREIGN KEY (`idcita`) REFERENCES `especialistashacenespecialidades` (`id`);

--
-- Filtros para la tabla `especialistashacenespecialidades`
--
ALTER TABLE `especialistashacenespecialidades`
  ADD CONSTRAINT `especialistashacenespecialidades_ibfk_1` FOREIGN KEY (`idespecialista`) REFERENCES `especialistas` (`id`),
  ADD CONSTRAINT `especialistashacenespecialidades_ibfk_2` FOREIGN KEY (`idespecialidad`) REFERENCES `especialidad` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
