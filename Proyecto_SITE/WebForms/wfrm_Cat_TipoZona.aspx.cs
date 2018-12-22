using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Proyecto_DAL;
using Proyecto_BLL;
//using Proyecto_BLL.svc_specialticket;
using Proyecto_SITE.ServiceReference1;


namespace Proyecto_SITE.WebForms
{
    public partial class wfrm_Cat_TipoZona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        public void CargarListado()
        {//Carga el listado de los objetos cuando los busca



            DataTable DT = new DataTable();
            ServiceReference1.BDClient Obj_WCF = new BDClient();
            DT = Obj_WCF.ListarDatosZona("SP_LISTAR_ZONA");

            grv_TipoZona.DataSource = DT;
            grv_TipoZona.DataBind();
            grv_TipoZona.Enabled = false;
            //CLS_EveZona_BLL Obj_EveZona_BLL = new CLS_EveZona_BLL();
            //CLS_EveZona_DAL Obj_EveZona_DAL = new CLS_EveZona_DAL();


            //try
            //{

            //    grv_Zona.DataSource = Obj_EveZona_BLL.ListarEveZona(ref Obj_EveZona_DAL);
            //    grv_Zona.DataBind();
            //}
            //catch (Exception ex)
            //{
            //    //lblMensaje.Text = ex.Message;
            //}
        }

    }
}