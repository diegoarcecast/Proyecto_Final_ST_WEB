using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_DAL;


namespace Proyecto_BLL
{
   public class CLS_FacArticulo_BLL
    {
        public bool InsertarFacArticulo(ref CLS_FacArticulo_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idArticulo", "1", obj_DAL.IDArticulo1);
            dtParametros.Rows.Add("@i_FK_idEvento", "1", obj_DAL.IDEvento1);
            dtParametros.Rows.Add("@i_FK_idZona", "1", obj_DAL.IDZona1);
            dtParametros.Rows.Add("@i_FK_idProgramacion", "1", obj_DAL.IDProgramacion1);
            dtParametros.Rows.Add("@dec_precioArticulo", "2", obj_DAL.Precio_Articulo1);

            obj_service.InsertarNonQuery("dbo.SP__INSERTAR_fac_Articulo", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }


        public bool ModificarFacArticulo(ref CLS_FacArticulo_DAL obj_DAL, ref string sMsjError)
        {
            DataTable dtParametros = new DataTable("Parametros");

            dtParametros.Columns.Add("NombreParametro");
            dtParametros.Columns.Add("TipoDato");
            dtParametros.Columns.Add("ValorParametro");

            dtParametros.Rows.Add("@i_PK_idArticulo", "1", obj_DAL.IDArticulo1);
            dtParametros.Rows.Add("@i_FK_idEvento", "1", obj_DAL.IDEvento1);
            dtParametros.Rows.Add("@i_FK_idZona", "1", obj_DAL.IDZona1);
            dtParametros.Rows.Add("@i_FK_idProgramacion", "1", obj_DAL.IDProgramacion1);
            dtParametros.Rows.Add("@dec_precioArticulo", "2", obj_DAL.Precio_Articulo1);

            obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_fac_Articulo", dtParametros, ref sMsjError);

            if (sMsjError == string.Empty)

            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public DataTable ListarFacArticulo(ref CLS_FacArticulo_DAL obj_DAL)
        {
            DataTable dt = new DataTable();

            dt = obj_Service.Listar("dbo.SP_SELECCIONAR_fac_Articulo");

            return dt;

        }

        public DataTable FiltrarFacArticulo(ref CLS_FacArticulo_DAL obj_DAL, string Filtro)
        {
            DataTable DT = new DataTable();
            DT = obj_service.Filtrar("dbo.SP_Filtrar_fac_Articulo", "@i_PK_idArticulo", SqlDbType.Int, Filtro);

            return DT;

        }


    }
}
