-- Crear tabla
CREATE TABLE IF NOT EXISTS `tablaUsuarios` (
  `ID` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL DEFAULT '',
  `email` varchar(100) NOT NULL DEFAULT '',
  `url` varchar(100) NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

-- Insertar información de ejemplo
INSERT INTO `tablaUsuarios` (`ID`, `nombre`, `email`, `url`) VALUES
(1, 'Edelmiro', 'edelmiro75@gmail.com', 'http://miblog.nombre'),
(2, 'Maruja', 'maruja50@hotmail.com', 'http://www.misitio.com'),
(3, 'Crisontomo', 'crisomajo@yahoo.com', 'http://miweb.com');