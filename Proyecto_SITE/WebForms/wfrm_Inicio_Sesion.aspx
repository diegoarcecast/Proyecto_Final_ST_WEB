<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Inicio_Sesion.aspx.cs" Inherits="Proyecto_SITE.WebForms.wfrm_Inicio_Sesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Iniciar Sesión</title>
<meta charset="UTF-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link rel="stylesheet" href="../CSS/Inicio_Sesion.css" />
    </head>
<style>
body {font-family: "Lato", sans-serif}
</style>
<body>

<!-- Navbar -->

  <div class="w3-bar w3-black w3-card">
    <a class="w3-bar-item w3-button w3-padding-large w3-hide-medium w3-hide-large w3-right" href="javascript:void(0)" onclick="myFunction()" title="Toggle Navigation Menu"><i class="fa fa-bars"></i></a>
    <a href="wfrm_Principal.aspx" class="w3-bar-item w3-button w3-padding-large">Inicio</a>
    <a href="wfrm_Principal.aspx#ProximosEventos" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Proximos Eventos</a>
    <a href="wfrm_Principal.aspx#Nosotros" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Nosotros</a>
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
        <a href="wfrm_Principal.aspx#Contacto" class="w3-bar-item w3-button">Contacto</a>
      </div>
    </div>
      <div class="w3-right">
          <a href="wfrm_Inicio_Sesion.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Iniciar Sesión</a>
          <a href="Reg_Usuario.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Registrarse</a>   
      </div>    
  </div>


<!-- Navbar  -->
<div id="navDemo" class="w3-bar-block w3-black w3-hide w3-hide-large w3-hide-medium w3-top" style="margin-top:46px">
  <a href="wfrm_Principal.aspx#ProximosEventos" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">ProximosEventos</a>
  <a href="wfrm_Principal.aspx#Nosotros" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Nosotros</a>
  <a href="wfrm_Inicio_Sesion.aspx" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Iniciar Sesión</a>
  <a href="Reg_Usuario.aspx" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Registrarse</a>   
</div>

<!-- Div Pagina -->
<div class="w3-content" style="max-width:2000px;margin-top:46px">
    <form id="form1" runat="server">
        <div class="w3-center">
             <br /> <br />
            <h4>Inicio Sesión</h4>                  
            <br /> <br />
            <asp:Label runat="server" ID="lbl_Correo">Correo Electronico:</asp:Label>
            <br /> <br />   
                <asp:TextBox runat="server" ID="txt_Correo" MaxLength="76" CssClass=" w3-large" /> 
            <br /> <br />
            <asp:Label runat="server" ID="lbl_Contraseña">Contraseña:</asp:Label>
            <br /> <br />
            <asp:TextBox runat="server" ID="txt_Contraseña" MaxLength="32" CssClass="w3-large"/> 
            <br /> <br /> <br />

             <a href="wfrm_perfil_usuario.aspx" class="w3-button w3-black w3-section w3-center" type="submit" id="btn_Ligin">Iniciar Sesion</a>
        <a href="#" class="w3-button w3-black w3-section w3-center" type="submit" id="btn_reset_pass">¿Olvido su contraseña?</a>
        </div>
        </form>
</div>

<!-- Footer -->
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