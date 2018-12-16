<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Mod_Datos.aspx.cs" Inherits="Proyecto_SITE.WebForms.wfrm_Mod_Datos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../CSS/Mod_Datos.css" />   
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <style>
    body {font-family: "Lato", sans-serif}
    </style>
    <title>Modificar Datos</title>
</head>
<body>
    <!-- Navbar -->
<div class="w3-top">
  <div class="w3-bar w3-black w3-card">
    <a class="w3-bar-item w3-button w3-padding-large w3-hide-medium w3-hide-large w3-right" href="javascript:void(0)" onclick="myFunction()" title="Toggle Navigation Menu"><i class="fa fa-bars"></i></a>
    <a href="wfrm_Principal.aspx" class="w3-bar-item w3-button w3-padding-large">Inicio</a>
    <a href="#ProximosEventos" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Proximos Eventos</a>
    <a href="#Nosotros" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Nosotros</a>
       <div class="w3-dropdown-hover w3-hide-small">
        <button class="w3-padding-large w3-button" title="More">Categorías<i class="fa fa-caret-down"></i></button>     
        <div class="w3-dropdown-content w3-bar-block w3-card-4">
        <a href="wfrm_Cat_Conciertos.aspx" class="w3-bar-item w3-button">Conciertos</a>
        <a href="wfrm_Cat_Teatro.aspx" class="w3-bar-item w3-button">Teatro</a>
        <a href="wfrm_Cat_Deportes.aspx" class="w3-bar-item w3-button">Deportes</a>
      </div>
       </div>
    <div class="w3-dropdown-hover w3-hide-small">
      <button class="w3-padding-large w3-button" title="More">Ayuda<i class="fa fa-caret-down"></i></button>     
      <div class="w3-dropdown-content w3-bar-block w3-card-4">
        <a href="wfrm_Term_Condic.aspx" class="w3-bar-item w3-button">Términos y Condiciones</a>
        <a href="wfrm_como_comprar.aspx" class="w3-bar-item w3-button">¿Cómo comprar?</a>
        <a href="wfrm_donde_retirar.aspx" class="w3-bar-item w3-button">¿Dónde retirar?</a>
        <a href="#Contacto" class="w3-bar-item w3-button">Contacto</a>
      </div>
    </div>
      <div class="w3-right">
          <a href="#" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Cerrar Sesión</a>
      </div>    
  </div>
</div>

<!-- Navbar  -->
<div id="navDemo" class="w3-bar-block w3-black w3-hide w3-hide-large w3-hide-medium w3-top" style="margin-top:46px">
  <a href="#ProximosEventos" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">ProximosEventos</a>
  <a href="#Nosotros" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Nosotros</a>
  <a href="wfrm_Inicio_Sesion.aspx" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Iniciar Sesión</a>
  <a href="Reg_Usuario.aspx" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Registrarse</a>   
</div>

  <form>    
    <div class="contentform">
        <h1>Modificar Datos</h1>
    	<div class="leftcontact">
			      <div class="form-group">
			        <p>Nombre <span>*</span></p>
			        <span class="icon-case"><i class="fa fa-user"></i></span>
				    <input type="text" name="nombre" id="nombre" required="required"/>
                <div class="validation"></div>
       </div> 

            <div class="form-group">
            <p>Apellido <span>*</span></p>
            <span class="icon-case"><i class="fa fa-user"></i></span>
				<input type="text" name="apellido" id="apellido" required="required"/>
                <div class="validation"></div>
			</div>

			<div class="form-group">
			<p>Correo <span>*</span></p>	
			<span class="icon-case"><i class="fa fa-envelope-o"></i></span>
                <input type="email" name="email" id="email" required="required"/>
                <div class="validation"></div>
			</div>	

			<div class="form-group">
			<p>Cedula <span>*</span></p>
			<span class="icon-case"><i class="fa fa-credit-card"></i></span>
				<input type="number" name="cedula" id="cedula" required="required"/>
                <div class="validation"></div>
			</div>

			<div class="form-group">
			<p>Fecha nacimiento <span>*</span></p>
			<span class="icon-case"><i class="fa fa-calendar"></i></span>
				<input type="date" name="date" id="date" required="required"/>
                <div class="validation"></div>
			</div>

			<div class="form-group">
			<p>Celular <span>*</span></p>
			<span class="icon-case"><i class="fa fa-phone"></i></span>
				<input type="tel" name="celular" id="celular" required="required"/>
                <div class="validation"></div>
			</div>	
            <div class="form-group">
			<p>Provincia <span>*</span></p>
			<span class="icon-case"><i class="fa fa-building-o"></i></span>
				<input type="text" name="provincia" id="provincia" required="required"/>
                <div class="validation"></div>
			</div>
	</div>

	<div class="rightcontact">	
            <h4>Datos de la Tarjeta</h4>
			<div class="form-group">
			<p>Nombre Completo <span>*</span></p>
			<span class="icon-case"><i class="fa fa-male"></i></span>
				<input type="text" name="nom_tarjeta" id="nom_tarjeta" required="required"/>
                <div class="validation"></div>
			</div>	

			<div class="form-group">
			<p>Número de Tarjeta<span>*</span></p>	
			<span class="icon-case"><i class="fa fa-credit-card"></i></span>
				<input type="number" name="num_tarjeta" id="num_tarjeta" required="required"/>
                <div class="validation"></div>
			</div>

			<div class="form-group">
			<p>Tipo Tarjeta <span>*</span></p>
			<span class="icon-case"><i class="fa fa-info"></i></span>
                <input type="text" name="tipo_tarjeta" id="tipo_tarjeta" required="required"/>
                <div class="validation"></div>
			</div>

			<div class="form-group">
			<p>Fecha Expiración <span>*</span></p>	
			<span class="icon-case"><i class=" fa fa-calendar-o"></i></span>
                <input type="datetime" name="fecha_exp" id="fecha_exp" required="required"/>
                <div class="validation"></div>
			</div>		
			<div class="form-group">
			<p>Dirección <span>*</span></p>
			<span class="icon-case"><i class="fa fa-text-width"></i></span>
                <textarea name="message" rows="14" required="required"></textarea>
                <div class="validation"></div>
			</div>	
	</div>
	</div>
      <button class="w3-button w3-black w3-section w3-center" type="submit" id="btn_actualizar">Actualizar</button>
      <a href="wfrm_perfil_usuario.aspx" class="w3-button w3-black w3-section w3-center" type="submit" id="btn_cancelar">Cancelar</a>

      
          
</form>	
    <footer class="w3-footer w3-padding-64 w3-center w3-opacity w3-light-grey w3-xlarge">
        <h3>Síguenos</h3>
          <i class="fa fa-facebook-official w3-hover-opacity"></i>
          <i class="fa fa-instagram w3-hover-opacity"></i>
          <i class="fa fa-snapchat w3-hover-opacity"></i>
          <i class="fa fa-pinterest-p w3-hover-opacity"></i>
          <i class="fa fa-twitter w3-hover-opacity"></i>
          <i class="fa fa-linkedin w3-hover-opacity"></i>  
          <h4>© 2018 Special Ticket. Todos los derechos reservados.</h4>
</footer>
  
</body>
</html>
