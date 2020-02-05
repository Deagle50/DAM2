<?php
	session_start();
	if(isset($_POST['hacerLogin']))
	{
		 $host="localhost";
		 $username="root";
		 $password="";
		 $databasename="fp";
		 $connect=mysqli_connect($host,$username,$password,$databasename);
				
		 $email=$_POST['email'];
		 $contrasena=$_POST['pass'];
		 $datos=mysqli_query($connect,"select codUsuario from usuarios where usuario='$email' and contrasena='$contrasena'");
		 
		 if($fila=mysqli_fetch_assoc($datos))
		 {
			  $_SESSION['codUsuario']=$fila['codUsuario'];
			  echo "existe";
		 }
		 else
		 {
		  	  echo "no existe este usuario";
		 }
		 
		 exit();
	}
?>