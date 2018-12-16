<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_donde_retirar.aspx.cs" Inherits="Proyecto_SITE.WebForms.wfrm_donde_retirar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donde Retirar</title>
<meta charset="UTF-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link rel="stylesheet" href="../CSS/Donde_Rertirar.css" />
    </head>
<style>
body {font-family: "Lato", sans-serif}
</style>
<body>

<!-- Navbar -->
<div class="w3-top">
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
</div>

<!-- Navbar  -->
<div id="navDemo" class="w3-bar-block w3-black w3-hide w3-hide-large w3-hide-medium w3-top" style="margin-top:46px">
  <a href="wfrm_Principal.aspx#ProximosEventos" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">ProximosEventos</a>
  <a href="wfrm_Principal.aspx#Nosotros" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Nosotros</a>
  <a href="wfrm_Inicio_Sesion.aspx" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Iniciar Sesión</a>
  <a href="Reg_Usuario.aspx" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Registrarse</a>   
</div>

  <div class="w3-container w3-content w3-center w3-padding-64">
    <h2 class="w3-wide">Puntos de servicio autorizados</h2>
    <br />
    <br />
    <table class="w3-justify">
        <tr>
            <td class="w3-col m6">
                <img src="../Resources/Bansback.png" style="width:50%" id="bansbach"/>
            </td>
            <td class="w3-col m6">
                <p class="w3-center">Bansbach Escazú</p>
                Ubicación: Multiplaza Escazu<br />               
                Dirección: Centro Comercial Multiplaza Escazú <br />
                Horario: M a S de 10:00 AM a 7:30 PM, D de 10:00 AM a 6:30 PM <br /><br />
                <p class="w3-center">Bansbach San José </p>
                Ubicación: San José <br />
                Dirección: De Mas x Menos de Cuesta de Moras,50 Oeste y 100 Norte <br />
                Horario: L a V de 9:30 AM a 5:00 PM, S de 10:00 AM a 12:00 MD<br />
            </td>
        </tr>      
        </table>
        <br /><br />
        <table class="w3-justify">
        <tr>
            <td class="w3-col m6">
                <img src="../Resources/hardrock.png" style="width:40%" />
            </td>
            <td class="w3-col m6">
                <p class="w3-center">HardRock Heredia</p>
                Ubicación: Heredia<br />
                Dirección: Diagonal al Centro Comercial Real Cariari <br />
                Horario: Lunes a Domingo de 12:00 MD a 5:00 PM
            </td>
        </tr>
        </table>
        <br /><br />
      <table class="w3-justify">
        <tr>
            <td class="w3-col m6">
                <img src="../Resources/servimas.jpg" style="width:50%" id="servimas"/>
            </td>
            <td class="w3-col m6">
                <p class="w3-center">Servimás San José</p>
                Ubicación: San José <br />
                Nombre: Servimás en Mas x Menos <br />
                Dirección: 100 Mts Oeste de la Asamblea Legislativa <br />
                Horario: L a S de 8:00 AM a 8:00 PM, D de 9:00 AM a 5:00 PM<br /> <br />
                <p class="w3-center">Servimás Curridabat</p>
                Ubicación: Curridabat <br />
                Nombre: Servimás en Walmart <br />
                Dirección: De la bomba la Galera 1.5 Km Este, sobre carretera vieja a Tres Rios <br />
                Horario: L a S de 8:00 AM a 8:00 PM, D de 9:00 AM a 5:00 PM <br /><br />
                <p class="w3-center">Servimás Desamparados</p>
                Ubicación: Desamparados <br />
                Nombre: Servimás en Maxibodega <br />
                Dirección: Cruce de San Miguel y Aserrí <br />
                Horario: L a S de 8:00 AM a 8:00 PM D de 9:00 AM a 5:00 PM
            </td>
        </tr>
    </table>
  </div>


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
</html>
