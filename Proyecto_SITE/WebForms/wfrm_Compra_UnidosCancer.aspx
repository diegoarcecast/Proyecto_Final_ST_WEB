<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Compra_UnidosCancer.aspx.cs" Inherits="Proyecto_SITE.WebForms.wfrm_Compra_UnidosCancer" %>

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
    .auto-style1 {
        width: 77px;
        height: 26px;
    }
    .auto-style2 {
        height: 26px;
    }
    .auto-style3 {
        width: 383px;
    }
    .auto-style4 {
        width: 370px;
    }
    .auto-style5 {
        height: 26px;
        width: 370px;
    }
    .auto-style6 {
        width: 717px;
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
    <div class="w3-white">
        <div class="w3-container w3-content w3-padding-64" style="max-width:800px">
             <div class="w3-row-padding w3-padding-32" style="margin:0 -16px">
    <div class="w3-third w3-margin-bottom">
          <img src="../Resources/90p.png" alt="90 Minutos por la vida" style="width:150%" class="w3-hover-opacity"/>
          <div class="w3-container w3-white">
              <table class="auto-style3">
        <tr>
            <td class="auto-style4"><strong></strong></td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Cantidad de entradas</strong></td>
            <td class="auto-style2">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
            </td><td class="auto-style1"><strong></strong></td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Ubicacion</strong></td>
            <td><strong><asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="Sombra ESTE">Sombra ESTE</asp:ListItem>
                <asp:ListItem>Sombra Oeste</asp:ListItem>
                <asp:ListItem>Sol Norte</asp:ListItem>
                <asp:ListItem>Sol Sur</asp:ListItem>
                <asp:ListItem>Palco</asp:ListItem>
                </asp:DropDownList>
                </strong>
            </td>
        </tr>
            <tr>
            <td class="auto-style4"><strong>Total</strong></td>
            <td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> </td>
        </tr>
        <tr>
            <td class="auto-style4">
       <table>
        <tr>
            <td class="auto-style6"><strong>Detalles de Facturación</strong></td>
        </tr>
        <tr>
            
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            
            <td class="auto-style6">&nbsp;</td>
        </tr>
           <tr>
            <td class="auto-style6"><strong>Tipo de Tarjeta:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
            <td><strong><asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>Mastercard</asp:ListItem>
                <asp:ListItem>Visa</asp:ListItem>
                </asp:DropDownList></strong></td>
        </tr>
           <tr>
            <td class="auto-style6"><strong>Ingrese el nombre completo del dueño de la tarjeta:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
            <td><strong>
                <asp:RegularExpressionValidator  ID="Regex" runat="server" ErrorMessage="Ingrese los datos adecuados" ValidationExpression="[a-zA-Z]*[^!@%~?:#$%^&*()'0123456789]*" ControlToValidate="TextBox3" ValidationGroup="vg"> </asp:RegularExpressionValidator>
                <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="vg"></asp:TextBox></strong></td>
        </tr>
        <tr>
            <td class="auto-style6"><strong>Ingrese el número de tarjeta:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Ingrese los datos adecuados" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                <strong><asp:TextBox ID="TextBox1" runat="server" ValidationGroup="vg2" MaxLength="17"></asp:TextBox></strong></td>
        </tr>
           
           <tr>
            <td class="auto-style6"><strong>Código de Seguridad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
               
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Ingrese los datos adecuados" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                <strong><asp:TextBox ID="TextBox2" runat="server" ValidationGroup="vg3" MaxLength="3"></asp:TextBox></strong></td>
        </tr>
           <tr>
            <td class="auto-style6">&nbsp;</td>
        </tr>
    </table>

             </td>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
               <div class="w3-container w3-white">

             <a href="wfrm_TerminarCompra.aspx" class="w3-button w3-black w3-margin-bottom">Comprar entrada</a> 
          
           </div>
        </div>
            </div>
            </div>
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
