using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_DAL;
using System.Data;


namespace Proyecto_BLL
{
   public class CLS_EventoLugar_BLL
    {
        CLS_Evento_DAL obj_DAL = new CLS_Evento_DAL();
        public bool InsertarEventoLugar(ref CLS_EventoLugar_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idLugar", "1", obj_DAL.IDLugar1);
            dtParametros.Rows.Add("@vc_nombreLugar", "2", obj_DAL.NombreLugar1);
            dtParametros.Rows.Add("@vc_ubicacionLugar", "2", obj_DAL.UbicacionLugar1);
            dtParametros.Rows.Add("b_activoLugar", "1", obj_DAL.ActivoLugar1);

            //obj_service.InsertarNonQuery("dbo.SP__INSERTAR_eve_Lugar", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public bool ModificarEventoLugar(ref CLS_EventoLugar_DAL obj_DAL, ref string sMsjError)

        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idLugar", "1", obj_DAL.IDLugar1);
            dtParametros.Rows.Add("@vc_nombreLugar", "2", obj_DAL.NombreLugar1);
            dtParametros.Rows.Add("@vc_ubicacionLugar", "2", obj_DAL.UbicacionLugar1);
            dtParametros.Rows.Add("b_activoLugar", "1", obj_DAL.ActivoLugar1);

            //obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_eve_Lugar", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public DataTable ListarEventoLugar(ref CLS_EventoLugar_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            //dt = obj_Service.Listar("dbo.SP_SELECCIONAR_eve_Lugar");

            return dt;

        }

        public DataTable FiltrarEvento(ref CLS_Evento_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            //DT = obj_service.Filtrar("dbo.SP_Filtrar_eve_Lugar", "@i_PK_idLugar", SqlDbType.Int, Filtro);

            return DT;

        }



    }
}

