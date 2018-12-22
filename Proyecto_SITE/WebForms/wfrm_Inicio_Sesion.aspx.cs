using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_SITE.ServiceReference;

namespace Proyecto_SITE.WebForms
{
    public partial class wfrm_Inicio_Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //BDClient obj = new BDClient();
            //if (obj.InicioSesion(txt_Correo.Text.ToString(), txt_Contraseña.Text.ToString())== "Inicio exitoso")
            //{
               Response.Redirect("wfrm_perfil_usuario.aspx");
            //} 
        }
    }
}