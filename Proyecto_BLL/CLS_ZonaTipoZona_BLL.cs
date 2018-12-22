using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_DAL;

namespace Proyecto_BLL
{
  public class CLS_ZonaTipoZona_BLL
    {
        public bool InsertarZonaTipoZona(ref CLS_ZonaTipoZona_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idZonaTipo", "1", obj_DAL.IDZonaTipo1);
            dtParametros.Rows.Add("@i_FK_idZona", "1", obj_DAL.IDZona1);
            dtParametros.Rows.Add("@i_FK_idTipoZona", "1", obj_DAL.IDTipoZona1);
          



            //obj_service.InsertarNonQuery("dbo.SP__INSERTAR_eve_Zona_TipoZona", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public bool ModificarZonaTipoZona(ref CLS_ZonaTipoZona_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idZonaTipo", "1", obj_DAL.IDZonaTipo1);
            dtParametros.Rows.Add("@i_FK_idZona", "1", obj_DAL.IDZona1);
            dtParametros.Rows.Add("@i_FK_idTipoZona", "1", obj_DAL.IDTipoZona1);




            //obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_eve_Zona_TipoZona", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public DataTable ListarZonaTipoZona(ref CLS_ZonaTipoZona_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            //dt = obj_Service.Listar("dbo.SP_SELECCIONAR_eve_Zona_TipoZona");

            return dt;

        }

        public DataTable FiltrartipoEvento(ref CLS_ZonaTipoZona_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            //DT = obj_service.Filtrar("dbo.Filtrar_eve_Zona_TipoZona", "@i_PK_idZonaTipo", SqlDbType.Int, Filtro);

            return DT;
        }
    }


}

