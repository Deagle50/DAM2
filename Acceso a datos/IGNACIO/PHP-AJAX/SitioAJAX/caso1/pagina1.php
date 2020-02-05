<?php
	header('Content-Type: text/html; charset=utf-8');
	if ($_GET['cod']==1)
	  echo "<strong>Aries:</strong> Vas a tener cambios físicos, personales y de carácter, Te sentirás impulsivo. Pensarás en unirte a agrupaciones de ayuda a los demás.";
	if ($_REQUEST['cod']==2)
	  echo "<strong>Tauro:</strong> Hoy los cambios serán privados, íntimos. Recuerdos y nostalgia. Pensarás en irte al monte o un convento. Tu cónyuge alucinará.";
	if ($_REQUEST['cod']==3)
	  echo "<strong>Géminis:</strong> Tus asuntos tendrán que ver con las amistades y las actividades con ellos. Mucha energía sexual y fuerza emocional. Deseos difíciles de controlar.";
	if ($_REQUEST['cod']==4)
	  echo "<strong>Cancer:</strong> Tu profesión y las relaciones con tus superiores y con tu madre serán estresantes. Plantéate cogerte un periodo vacacional.";
	if ($_REQUEST['cod']==5)
	  echo "<strong>Leo:</strong> Los estudios, los viajes, el extranjero y la espiritualidad serán lo más importante. Pensamientos, religión, filosofía, vivencias kármicas, tantra, ...";
	if ($_REQUEST['cod']==6)
	  echo "<strong>Virgo:</strong> Lo más importante para tí será tu vida sexual, tal vez miedos, temas legales, juicios o herencias. Nuevas experiencias extrañas.";
	if ($_REQUEST['cod']==7)
	  echo "<strong>Libra:</strong> Todos los asuntos tendrán que ver con tu pareja y con temas domésticos. Ellos serán lo más importante del día. Ganancias a través de especulaciones o del juego.";
	if ($_REQUEST['cod']==8)
	  echo "<strong>Escorpio:</strong> Todos los asuntos tendrán que ver con temas de trabajo y de salud. Presta atención a ambos. Durante este período tendrás muchas oportunidades para ganar dinero.";
	if ($_REQUEST['cod']==9)
	  echo "<strong>Sagitario:</strong> Vivirás cambios en relación en las relaciones con tu pareja. Creatividad, actividad, diversiones y salidas. Período de encuentros con personas o situaciones con las que alucinarás.";
	if ($_REQUEST['cod']==10)
	  echo "<strong>Capricornio:</strong> Los cambios tendrán que ver con tu hogar, con la convivencia y con tu padre, si lo tienes. Asuntos relativos al carácter en la convivencia. El karma de responsabilidad de estos momentos te acercará al mundo de lo desconocido y contacto con el más allá.";
	if ($_REQUEST['cod']==11)
	  echo "<strong>Acuario:</strong> Todos los asuntos tendrán que ver con el entorno inmediato, hermanos y vecinos. Harás viajes cortos o traslados frecuentes.";
	if ($_REQUEST['cod']==12)
	  echo "<strong>Piscis:</strong> Vivirás cambios en la economía, movimientos en los ingresos, negocios, bolsa. Buscarás el liderazgo en tu entorno; no habrá quien te aguante.";
?>