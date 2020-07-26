CREATE TABLE `donaciones` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `tipoDocumento` varchar(255) NOT NULL,
  `numeroCedulaRif` int(11) NOT NULL,
  `fecha` varchar(255) NOT NULL,
  `monto` double NOT NULL,
  `moneda` varchar(255) NOT NULL,
  `tipoDonacion` varchar(255) NOT NULL,
  `formaDePago` varchar(255) NOT NULL,
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
