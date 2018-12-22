using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_DAL;
using System.Data;

namespace Proyecto_BLL
{
    public class CLS_TipoEvento_BLL
    {
        public bool InsertartipoEvento(ref CLS_TipoEvento_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idTipoEvento", "1", obj_DAL.IDTipoEvento1);
            dtParametros.Rows.Add("@vc_nombreTipoEvento", "2", obj_DAL.NombreTipoEvento1);
            dtParametros.Rows.Add("@vc_descripcionTipoEvento", "2", obj_DAL.DescripcionTipoEvento1);
           


            //obj_service.InsertarNonQuery("dbo.SP__INSERTAR_eve_TipoEvento", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public bool ModificartipoEvento(ref CLS_TipoEvento_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idTipoEvento", "1", obj_DAL.IDTipoEvento1);
            dtParametros.Rows.Add("@vc_nombreTipoEvento", "2", obj_DAL.NombreTipoEvento1);
            dtParametros.Rows.Add("@vc_descripcionTipoEvento", "2", obj_DAL.DescripcionTipoEvento1);



            //obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_eve_TipoEvento", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public DataTable ListartipoEvento(ref CLS_TipoEvento_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            //dt = obj_Service.Listar("dbo.SP_SELECCIONAR_eve_TipoEvento");

            return dt;

        }

        public DataTable FiltrartipoEvento(ref CLS_TipoEvento_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            //DT = obj_service.Filtrar("dbo.SP_Filtrar_eve_TipoEvento", "@i_PK_idTipoEvento", SqlDbType.Int, Filtro);

            return DT;

        }


    }
}
