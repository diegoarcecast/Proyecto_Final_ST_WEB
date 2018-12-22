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
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
<link rel="stylesheet" href="../CSS/Perfil_Usuario.css" />
    </head>
<style>
body {font-family: "Lato", sans-serif}
    .auto-style1 {
        height: -42px;
    }
</style>
<body>

    <form id="form1" runat="server">

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
          <a href="#" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Cerrar Sesión</a>
      </div>    
  </div>
</div>

<!-- Navbar  -->
<div id="navDemo" class="w3-bar-block w3-black w3-hide w3-hide-large w3-hide-medium w3-top" style="margin-top:46px">
  <a href="wfrm_Principal.aspx#ProximosEventos" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">ProximosEventos</a>
  <a href="wfrm_Principal.aspx#Nosotros" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Nosotros</a>
  <a href="#" class="w3-bar-item w3-button w3-padding-large" onclick="myFunction()">Cerrar Sesión</a>
</div>

<!-- Div Pagina -->
    <div class="content">
        <table>
            <tr>
                <th>
                <div class="sidenav">
                  <a href="wfrm_Mod_Datos.aspx">Actualizar Datos</a>
                  <a href="#">Historial</a>
                  <a href="#">Cerrar Sesión</a>
                </div>
                </th>
                <th>
                  <h1>Mis Datos Personales</h1>
                    <p>Nombre</p>
			        <span class="icon-case">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <i class="fa fa-user"></i></span>
				    &nbsp;<p>Apellido</p>
                    <span class="icon-case"><i class="fa fa-user">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </i></span>
				    &nbsp;<p>Cedula</p>
			        <span class="icon-case"><i class="fa fa-credit-card"></i></span>
				    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<p>Correo</p>	
			        <span class="icon-case">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <i class="fa fa-envelope-o"></i></span>
                    &nbsp;<p>Clave</p>	
			        <span class="icon-case">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    <i class="fa fa-envelope-o"></i></span>
                    &nbsp;<p>Celular</p>
			        <span class="icon-case">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <i class="fa fa-phone"></i></span>&nbsp;<hr />
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Notificaciones" />
                    <hr class="auto-style1" />
                    <asp:Button ID="Button1" runat="server" Text="Cambiar" OnClick="Button1_Click" style="height: 26px" />
                </th>
            </tr>           
        </table>
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

    </form>

</body>
</html>

