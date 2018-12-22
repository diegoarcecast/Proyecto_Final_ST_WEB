using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_SITE.ServiceReference;

namespace Proyecto_SITE.WebForms
{
    public partial class wfrm_perfil_usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference.BDClient obj = new BDClient();
            obj.Modificar_Usuario(TextBox1.Text.ToString(), TextBox6.Text.ToString(), TextBox4.Text.ToString(), TextBox2.Text.ToString(), TextBox5.Text.ToString(), CheckBox1.Checked);

        }
    }
}