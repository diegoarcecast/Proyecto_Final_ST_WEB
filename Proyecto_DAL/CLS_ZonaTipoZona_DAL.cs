using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAL
{
    public class CLS_ZonaTipoZona_DAL
    {

        private int IDZonaTipo;
        private int IDZona;
        private int IDTipoZona;

        public int IDZonaTipo1
        {
            get
            {
                return IDZonaTipo;
            }

            set
            {
                IDZonaTipo = value;
            }
        }

        public int IDZona1
        {
            get
            {
                return IDZona;
            }

            set
            {
                IDZona = value;
            }
        }

        public int IDTipoZona1
        {
            get
            {
                return IDTipoZona;
            }

            set
            {
                IDTipoZona = value;
            }
        }
    }
}
