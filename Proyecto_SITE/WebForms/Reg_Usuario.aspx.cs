using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_SITE.ServiceReference;

namespace Proyecto_SITE.WebForms
{
    public partial class Reg_Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference.BDClient obj = new BDClient();
            obj.Insertar_Usuarios(txt1.Value.ToString(), txt2.Value.ToString(), txt4.Value.ToString(), txt5.Value.ToString(), txt6.Value.ToString(), true);
        }
    }
}