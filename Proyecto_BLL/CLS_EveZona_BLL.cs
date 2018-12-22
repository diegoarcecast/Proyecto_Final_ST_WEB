using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_DAL;
using Proyecto_BLL.svc_specialticket;
using System.ServiceModel;

namespace Proyecto_BLL
{
   public class CLS_EveZona_BLL
    {

        //public bool InsertarEveZona(ref CLS_EveZona_DAL obj_DAL, ref string sMsjError)
        //{
        //    DataTable dtParametros = new DataTable("Parametros");

        //    dtParametros.Columns.Add("NombreParametro");
        //    dtParametros.Columns.Add("TipoDato");
        //    dtParametros.Columns.Add("ValorParametro");

        //    dtParametros.Rows.Add("@i_PK_idZona", "1", obj_DAL.IDZona1);
        //    dtParametros.Rows.Add("@vc_nombreZona", "2", obj_DAL.NombreZona1);
        //    dtParametros.Rows.Add("@i_FK_idTipoZona", "2", obj_DAL.TipoZona1);

        //    //Obj_WCF.("dbo.SP__INSERTAR_eve_Zona", dtParametros, ref sMsjError);

        //    if (sMsjError == string.Empty)

        //    {

        //        return true;

        //    }
        //    else
        //    {

        //        return false;

        //    }
        //}


        //public bool ModificarEveZona(ref CLS_EveZona_DAL obj_DAL, ref string sMsjError)
        //{
        //    DataTable dtParametros = new DataTable("Parametros");

        //    dtParametros.Columns.Add("NombreParametro");
        //    dtParametros.Columns.Add("TipoDato");
        //    dtParametros.Columns.Add("ValorParametro");

        //    dtParametros.Rows.Add("@i_PK_idZona", "1", obj_DAL.IDZona1);
        //    dtParametros.Rows.Add("@vc_nombreZona", "2", obj_DAL.NombreZona1);
        //    dtParametros.Rows.Add("@i_FK_idTipoZona", "2", obj_DAL.TipoZona1);

        //    //obj_service.InsertarNonQuery("dbo.SP_ACTUALIZAR_eve_Zona", dtParametros, ref sMsjError);

        //    if (sMsjError == string.Empty)

        //    {

        //        return true;

        //    }
        //    else
        //    {

        //        return false;

        //    }
        //}

        public DataTable ListarEveZona(ref CLS_EveZona_DAL obj_DAL)
        {
            svc_specialticket.BDClient Obj_WCF = new BDClient();

            DataTable dt = new DataTable();
            dt = Obj_WCF.ListarDatosZona("SP_LISTAR_ZONA");

            return dt;

        }

        //public DataTable FiltrarEveZona(ref CLS_EveZona_DAL obj_DAL, string Filtro)
        //{
        //    DataTable DT = new DataTable();
        //    //DT = obj_service.Filtrar("dbo.SP_Filtrar_eve_Zona", "@i_PK_idZona", SqlDbType.Int, Filtro);

        //    return DT;

        //}



    }
}
