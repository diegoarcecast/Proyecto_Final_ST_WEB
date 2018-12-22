using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_DAL;
using System.Data;


namespace Proyecto_BLL
{
    public class CLS_EveTipoZona_BLL
    {
        public bool InsertarEveTipoZona(ref CLS_EveTipoZona_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idTipoZona", "1", obj_DAL.TipoZona1);
            dtParametros.Rows.Add("@vc_nombreTipoZona", "2", obj_DAL.NombreTipoZona1);
            dtParametros.Rows.Add("@vc_descripcionTipoZona", "2", obj_DAL.DescripcionTipoZona1);
           
            obj_service.InsertarNonQuery("dbo.SP__INSERTAR_eve_TipoZona", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }


        public bool ModificarEveTipoZona(ref CLS_EveTipoZona_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idTipoZona", "1", obj_DAL.TipoZona1);
            dtParametros.Rows.Add("@vc_nombreTipoZona", "2", obj_DAL.NombreTipoZona1);
            dtParametros.Rows.Add("@vc_descripcionTipoZona", "2", obj_DAL.DescripcionTipoZona1);

            obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_eve_TipoZona", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public DataTable ListarEveTipoZona(ref CLS_EveProgramacion_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            dt = obj_Service.Listar("dbo.SP_SELECCIONAR_eve_TipoZona");

            return dt;

        }

        public DataTable FiltrarEveTipoZona(ref CLS_EveProgramacion_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            DT = obj_service.Filtrar("dbo.SP_Filtrar_eve_TipoZona", "@i_PK_idTipoZona", SqlDbType.Int, Filtro);

            return DT;

        }

    }
}
