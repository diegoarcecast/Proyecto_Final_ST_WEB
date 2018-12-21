﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Principal.aspx.cs" Inherits="Proyecto_SITE.WebForms.wfrm_Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SpecialTicket</title>
<meta charset="UTF-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    </head>
<style>
body {font-family: "Lato", sans-serif}
.mySlides {display: none}
</style>
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
          <a href="Prueba.aspx" class="w3-bar-item w3-button">Administrar Usuarios</a>
        <a href="#Contacto" class="w3-bar-item w3-button">Contacto</a>
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
  <a href="#ProximosEventos" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">ProximosEventos</a>
  <a href="#Nosotros" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Nosotros</a>
  <a href="wfrm_Inicio_Sesion.aspx" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Iniciar Sesión</a>
  <a href="Reg_Usuario.aspx" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Registrarse</a>   
</div>

<!-- Div Pagina -->
<div class="w3-content" style="max-width:2000px;margin-top:46px">

  <!-- Slideshow  -->
  <div class="mySlides w3-display-container w3-center">
    <img src="../Resources/img1.jpg" style="width:100%"/>
    <div class="w3-display-bottommiddle w3-container w3-text-white w3-padding-32 w3-hide-small"> 
    </div>
  </div>
  <div class="mySlides w3-display-container w3-center">
    <img src="../Resources/90c.png" style="width:100%"/>
    <div class="w3-display-bottommiddle w3-container w3-text-white w3-padding-32 w3-hide-small">   
    </div>
  </div>
  </div>

  <!-- Proximos Eventos -->
  <div class="w3-white" id="ProximosEventos">
    <div class="w3-container w3-content w3-padding-64" style="max-width:800px">
      <h2 class="w3-wide w3-center">Proximos Eventos</h2>
      <p class="w3-opacity w3-center"><i>Reserva tu entrada!</i></p><br />

      <div class="w3-row-padding w3-padding-32" style="margin:0 -16px">
        <div class="w3-third w3-margin-bottom">
          <img src="../Resources/90p.png" alt="90 minutos por la vida" style="width:100%" class="w3-hover-opacity"/>
          <div class="w3-container w3-white">
            <p><b>90 minutos por la vida</b></p>
            <p class="w3-opacity">06 Enero 2019</p>
            <p>Unidos contra el cáncer infantil</p>
            <a href="wfrm_Compra_UnidosCancer.aspx" class="w3-button w3-black w3-margin-bottom">Comprar entrada</a> 
          </div>
        </div>
        <div class="w3-third w3-margin-bottom">
          <img src="../Resources/img1.jpg" alt="Orquesta Filarmónica" style="width:150%" class="w3-hover-opacity"/>
          <div class="w3-container w3-white">
            <p><b>Orquesta Filarmónica</b></p>
            <p class="w3-opacity">16-17 Dic 2018</p>
            <p>Disfute del talento nacional</p>
            
              <a href="wfrm_Compra_SomosLatinos.aspx" class="w3-button w3-black w3-margin-bottom">Comprar entrada</a> 
          </div>
        </div>
      </div>
    </div>
  </div>


  <!-- Nosotros -->
    <div class="w3-black">
  <div class="w3-container w3-content w3-center w3-padding-64" style="max-width:800px" id="Nosotros">
    <h2 class="w3-wide">Nosotros</h2>
    <p class="w3-opacity"><i>Special Ticket</i></p>
    <p class="w3-justify">Somos una empresa costarricense independiente que se dedica al servicio de emisión y distribución de entradas para todo tipo de eventos (musicales, teatrales, culturales, deportivos, seminarios, entre otros.)
                          SpecialTicket emite las entradas por orden y cuenta de los productores o promotores que nos contratan para uno o más eventos.
                          Gracias a nuestro sistema de emisión computarizada de entradas aseguramos la más transparente gestión a los productores o promotores del evento y al mismo tiempo, garantizamos un método eficiente y seguro a los consumidores que adquieren su entrada sin correr el riesgo de sobreventa de asientos.</p>
    <div class="w3-row w3-padding-32">
      <div class="w3-half">
        <p>Terminos y Condiciones</p>
        <a title="Terminos y Condiciones" href="wfrm_Term_Condic.aspx"><img src="../Resources/terminos-y-condiciones-img.png" class="w3-round w3-margin-bottom" alt="Terminos y Condiciones" style="width:60%"/></a>
      </div>
      <div class="w3-half">
        <p>Politica de Privacidad</p>
        <a title="Politica de Privacidad" href="wfrm_politica_privacidad.aspx"><img src="../Resources/security_icon.png" class="w3-round w3-margin-bottom" alt="Politica de Privacidad" style="width:60%" onclick=""/></a>
      </div>      
    </div>
  </div>
 </div>

  <!-- Contacto -->
  <div class="w3-container w3-content w3-padding-64" style="max-width:800px" id="Contacto">
    <h2 class="w3-wide w3-center">Contáctenos</h2>
    <p class="w3-opacity w3-center"><i>Comentarios, Dudas y/o Sugerencias</i></p>
    <div class="w3-row w3-padding-32">
      <div class="w3-col m6 w3-large w3-margin-bottom">
        <i class="fa fa-map-marker" style="width:30px"></i> San José, CR<br/>
        <i class="fa fa-phone" style="width:30px"></i> Phone: 4000-5990<br/>
        <i class="fa fa-envelope" style="width:30px"> </i> Correo: info@specialticket.com<br/>
      </div>
      <div class="w3-col m6">
        <form action="/action_page.php" target="_blank">
          <div class="w3-row-padding" style="margin:0 -16px 8px -16px">
            <div class="w3-complete">
              <input class="w3-input w3-border-dark-grey" type="text" placeholder="Nombre" required name="Nombre"/>
            </div>
              <div class="w3-complete">
              <input class="w3-input w3-border-dark-grey" type="text" placeholder="Primer Apellido" required name="Primer Apellido"/>
            </div>
              <div class="w3-complete">
              <input class="w3-input w3-border-dark-grey" type="text" placeholder="Segundo Apellido" required name="Segundo Apellido"/>
            </div>
            <div class="w3-complete">
              <input class="w3-input w3-border-dark-grey" type="text" placeholder="Correo" required name="Correo"/>
            </div>
              <div class="w3-complete">
              <input class="w3-input w3-border-dark-grey" type="text" placeholder="Confirmación Correo" required name="Confirmación Correo"/>
            </div>
              <div class="w3-complete">
              <input class="w3-input w3-border-dark-grey" type="text" placeholder="Teléfono" required name="Teléfono" />
            </div>
            <div class="w3-complete">
              <input class="w3-input w3-border-dark-grey" type="text" placeholder="Comentarios" required name="Comentarios"/>
            </div>
          </div>            
          <button class="w3-button w3-black w3-section w3-right" type="submit">Enviar</button>
        </form>
      </div>
    </div>
  </div>
  
<!-- Final  -->


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
    

<script>
// Slideshow - 4 segundos
var myIndex = 0;
carousel();

function carousel() {
    var i;
    var x = document.getElementsByClassName("mySlides");
    for (i = 0; i < x.length; i++) {
       x[i].style.display = "none";  
    }
    myIndex++;
    if (myIndex > x.length) {myIndex = 1}    
    x[myIndex-1].style.display = "block";  
    setTimeout(carousel, 4000);    
}

// Navbar
function myFunction() {
    var x = document.getElementById("navDemo");
    if (x.className.indexOf("w3-show") == -1) {
        x.className += " w3-show";
    } else { 
        x.className = x.className.replace(" w3-show", "");
    }
}

// Cerrar Modal
var modal = document.getElementById('ticketModal');
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
    }
</script>

</body>
</html>
