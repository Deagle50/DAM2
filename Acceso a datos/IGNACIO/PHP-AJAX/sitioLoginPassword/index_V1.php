<?php
	session_start();
	if(isset($_POST['btLogout']))
	{
	 	unset($_SESSION['codUsuario']);
	 	echo 'DESCONECTADO';
	}
	else
	    echo $_SESSION['codUsuario'];
?>

<html>
<body>
 <h2>HOLA</h2>
 <form method='post'>
  	<input type='submit' name='btLogout' value='Desconectar'>
 </form>
</body>
</html>