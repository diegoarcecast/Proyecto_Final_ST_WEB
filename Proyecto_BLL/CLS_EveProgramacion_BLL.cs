using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_DAL;

namespace Proyecto_BLL
{
  public class CLS_EveProgramacion_BLL
    {
        public bool InsertarEveProgramacion(ref CLS_EveProgramacion_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idProgramacion", "1", obj_DAL.IDProgramacion1);
            dtParametros.Rows.Add("@dt_fechaProgramacion", "2", obj_DAL.FechaProgramacion1);
            dtParametros.Rows.Add("@dt_horaProgramacion", "2", obj_DAL.HoraProgramacion1);
            dtParametros.Rows.Add("@i_FK_idLugar", "1", obj_DAL.IDLugar1);

            obj_service.InsertarNonQuery("dbo.SP__INSERTAR_eve_Programacion", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public bool ModificarEveProgramacion(ref CLS_EveProgramacion_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idProgramacion", "1", obj_DAL.IDProgramacion1);
            dtParametros.Rows.Add("@dt_fechaProgramacion", "2", obj_DAL.FechaProgramacion1);
            dtParametros.Rows.Add("@dt_horaProgramacion", "2", obj_DAL.HoraProgramacion1);
            dtParametros.Rows.Add("@i_FK_idLugar", "1", obj_DAL.IDLugar1);

            obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_eve_Programacion", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public DataTable ListarEveProgramacion(ref CLS_EveProgramacion_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            dt = obj_Service.Listar("dbo.SP_SELECCIONAR_eve_Programacion");

            return dt;

        }

        public DataTable FiltrarEveProgramacion(ref CLS_Evento_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            DT = obj_service.Filtrar("dbo.SP_Filtrar_eve_Programacion", "@i_PK_idProgramacion", SqlDbType.Int, Filtro);

            return DT;

        }


    }
}
