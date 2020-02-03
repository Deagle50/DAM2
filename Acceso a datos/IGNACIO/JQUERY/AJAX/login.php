<?php
$password="secreto";
$usuario="007";

$usu=isset($_GET['usuario']) ? $_GET['usuario'] : $_POST['usuario'];
$pass=isset($_GET['password']) ? $_GET['password'] : $_POST['password'];


if ($usu==$usuario&& $pass==$password) {
  echo 'correcto';
} else {
  echo 'fallo';
}
?>