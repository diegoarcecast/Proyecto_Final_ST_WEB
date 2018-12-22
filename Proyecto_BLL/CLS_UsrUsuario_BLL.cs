using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_DAL;
using System.Data;

namespace Proyecto_BLL
{
    public class CLS_UsrUsuario_BLL
    {
        public bool InsertarUsrUsuario(ref CLS_UsrUsuario_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idUsuario", "1", obj_DAL.IDUsuario1);
            dtParametros.Rows.Add("@vc_nombreUsuario", "2", obj_DAL.NombreUsuario1);
            dtParametros.Rows.Add("@vc_cedulaUsuario", "2", obj_DAL.CedulaUsuario1);
            dtParametros.Rows.Add("@vc_telefonoUsuario", "2", obj_DAL.TelefonoUsuario1);
            dtParametros.Rows.Add("@vc_correoUsuario", "2", obj_DAL.CorreoUsuario1);
            dtParametros.Rows.Add("@vc_claveUsuario", "2", obj_DAL.ClaveUsuario1);
            dtParametros.Rows.Add("@b_activoUsuario", "2", obj_DAL.ActivoUsuario1);



            obj_service.InsertarNonQuery("dbo.SP__INSERTAR_usr_Usuario", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }


        public bool ModificarUsrUsuario(ref CLS_UsrUsuario_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idUsuario", "1", obj_DAL.IDUsuario1);
            dtParametros.Rows.Add("@vc_nombreUsuario", "2", obj_DAL.NombreUsuario1);
            dtParametros.Rows.Add("@vc_cedulaUsuario", "2", obj_DAL.CedulaUsuario1);
            dtParametros.Rows.Add("@vc_telefonoUsuario", "2", obj_DAL.TelefonoUsuario1);
            dtParametros.Rows.Add("@vc_correoUsuario", "2", obj_DAL.CorreoUsuario1);
            dtParametros.Rows.Add("@vc_claveUsuario", "2", obj_DAL.ClaveUsuario1);
            dtParametros.Rows.Add("@b_activoUsuario", "2", obj_DAL.ActivoUsuario1);



            obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_Usr_Usuario", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }


        public DataTable ListarUsrUsuario(ref CLS_UsrUsuario_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            dt = obj_Service.Listar("dbo.SP_Seleccionar_Usr_Usuario");

            return dt;

        }

        public DataTable FiltrartipoEvento(ref CLS_UsrUsuario_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            DT = obj_service.Filtrar("dbo.SP_Filtrar_Usr_Usuario", "@i_PK_idUsuario", SqlDbType.Int, Filtro);

            return DT;
        } }


        }
    }
