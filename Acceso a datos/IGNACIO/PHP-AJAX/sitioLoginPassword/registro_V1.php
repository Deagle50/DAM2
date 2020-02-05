<!DOCTYPE html>
<html>

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Registro</title>
   <!-- Bootstrap CSS
     <link rel="stylesheet"  href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" /> -->
    <link rel="stylesheet" href="loginStyle.css" />
   
    <script src="jquery.min.js"></script>
    <script type="text/javascript">
      function hacerLogin()
	  {
		 var email=$("#txtEmail").val();
		 var pass=$("#pwdContrasena").val();
		 if(email!="" && pass!="")
		 {
		    $("#cargarLogoDescarga").css({"display":"block"});
			$.ajax({
				  type:'post',
				  url:'hacerLogin_V1.php',
				  data:{
				         hacerLogin:"hacerLogin",
				         email:email,
				         pass:pass
				       },
		  		  success:function(response) {		  		      
					  if(response=="existe")
					  {
					    window.location.href="index_V1.php";
					  }
					  else
					  {
					    $("#cargarLogoDescarga").css({"display":"none"});
					    $("#resultado").html(response);
					  }
		  		  }
		  	});
	 	  }
	      else
		  {
		    alert("Por favor, rellene la información solicitada");
		  }
	
		  return false;
	  }
   </script>
</head>

<body style="background-color:gray">
   <div id="contenGeneral">
		<div id="formLogin">
			 <h1>Formulario de conexión</h1>
			 <form method="post" action="hacerLogin_V1.php" 
			        onsubmit="return hacerLogin();">
				  <input type="text" name="txtEmail" id="txtEmail" 
				     placeholder="Introduce la cuenta de correo">
				  <br>
				  <input type="password" name="pwdContrasena" id="pwdContrasena" 
				      placeholder="***********">
				  <br>
				  <input type="submit" name="btLogin" value="LOGIN" 
				     id="btLogin">
			 </form>
			 <p id="cargarLogoDescarga"><img src="descarga.gif"></p>
			 <div id="resultado"></div>

		</div>	
	</div>
</body>

</html>

