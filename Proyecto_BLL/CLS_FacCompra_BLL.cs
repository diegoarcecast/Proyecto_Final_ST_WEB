using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_DAL;

namespace Proyecto_BLL
{
    public class CLS_FacCompra_BLL
    {
        public bool InsertarFacCompra(ref CLS_FacCompra_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idCompra", "1", obj_DAL.IDCompra1);
            dtParametros.Rows.Add("@i_FK_idUsuario", "1", obj_DAL.IDUsuario1);
            dtParametros.Rows.Add("@i_FK_idArticulo", "1", obj_DAL.IDArticulo1);
            dtParametros.Rows.Add("@i_cantidadCompra", "1", obj_DAL.CantidadCompra1);
            dtParametros.Rows.Add("@dec_montoCompra", "2", obj_DAL.MontoCompra1);
            dtParametros.Rows.Add("@ dt_fechaCompra", "2", obj_DAL.FechaCompra1);


           
            //obj_service.InsertarNonQuery("dbo.SP_INSERTAR_fac_Compra", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public bool ModificarFacCompra(ref CLS_FacCompra_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idCompra", "1", obj_DAL.IDCompra1);
            dtParametros.Rows.Add("@i_FK_idUsuario", "1", obj_DAL.IDUsuario1);
            dtParametros.Rows.Add("@i_FK_idArticulo", "1", obj_DAL.IDArticulo1);
            dtParametros.Rows.Add("@i_cantidadCompra", "1", obj_DAL.CantidadCompra1);
            dtParametros.Rows.Add("@dec_montoCompra", "2", obj_DAL.MontoCompra1);
            dtParametros.Rows.Add("@ dt_fechaCompra", "2", obj_DAL.FechaCompra1);



            //obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_fac_Compra", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public DataTable ListarFacCompra(ref CLS_FacCompra_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            //dt = obj_Service.Listar("dbo.SP_Seleccionar_fac_Compra");

            return dt;

        }

        public DataTable FiltrarFacCompra(ref CLS_FacCompra_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            //DT = obj_service.Filtrar("dbo.SP_Filtrar_fac_Compra", "@i_PK_idCompra", SqlDbType.Int, Filtro);

            return DT;

        }

    }
}
