using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_DAL;
using System.Data;


namespace Proyecto_BLL
{
    public class CLS_Evento_BLL
    {


        CLS_Evento_DAL obj_DAL = new CLS_Evento_DAL();
        public bool InsertarEvento(ref CLS_Evento_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idEvento", "2", obj_DAL.IDEvento1);
            dtParametros.Rows.Add("@vc_nombreEvento", "2", obj_DAL.NombreEvento1);
            dtParametros.Rows.Add("@i_FK_idTipoEvento", "2", obj_DAL.TipoEvento1);
            dtParametros.Rows.Add("vc_nombreEstado", "2", obj_DAL.IDEstado1);

            obj_service.InsertarNonQuery("dbo.eve_Evento", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }
        public bool ModificarEvento(ref CLS_Evento_DAL obj_DAL, ref string sMsjError)

        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idEvento", "2", obj_DAL.IDEvento1);
            dtParametros.Rows.Add("@vc_nombreEvento", "2", obj_DAL.NombreEvento1);
            dtParametros.Rows.Add("@i_FK_idTipoEvento", "2", obj_DAL.TipoEvento1);
            dtParametros.Rows.Add("vc_nombreEstado", "2", obj_DAL.IDEstado1);

            obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_eve_Evento", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public DataTable ListarEvento(ref CLS_Evento_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            dt = obj_Service.Listar("dbo.SP_SELECCIONAR_eve_Evento");

            return dt;

        }

        public DataTable FiltrarEvento(ref CLS_Evento_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            DT = obj_service.Filtrar("dbo.SP_Filtrar_eve_Evento", "@i_PK_idEvento", SqlDbType.Int, Filtro);

            return DT;

        }


    }
}
