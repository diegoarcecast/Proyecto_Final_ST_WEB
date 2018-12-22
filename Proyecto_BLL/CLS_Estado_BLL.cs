using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_DAL;
using System.Data;

namespace Proyecto_BLL
{
   
   public  class CLS_Estado_BLL
    {
        CLS_Estado_DAL obj_DAL = new CLS_Estado_DAL();
        public bool InsertarEstado(ref CLS_Estado_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idEstado", "2", obj_DAL.IDEstado1);
            dtParametros.Rows.Add("vc_nombreEstado", "2", obj_DAL.NombreEstado1);

            obj_service.InsertarNonQuery("dbo.eve_Estado", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }


        }


        public bool ModificarEstado(ref CLS_Estado_DAL obj_DAL, ref string sMsjError)

        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idEstado", "2", obj_DAL.IDEstado1);
            dtParametros.Rows.Add("vc_nombreEstado", "2", obj_DAL.NombreEstado1);

            obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_eve_Estado", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public DataTable ListarEstado(ref CLS_Estado_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            dt = obj_Service.Listar("dbo.SP_SELECCIONAR_eve_Estado");

            return dt;

        }

        public DataTable FiltrarEstado(ref CLS_Estado_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            DT = obj_service.Filtrar("dbo.SP_Filtrar_eve_Estado", "@i_PK_idEstado", SqlDbType.Int, Filtro);

            return DT;

        }


    }
}
