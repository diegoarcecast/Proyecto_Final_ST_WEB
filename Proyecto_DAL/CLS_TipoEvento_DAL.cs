using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAL
{
   public class CLS_TipoEvento_DAL
    {
        private int IDTipoEvento;
        private string NombreTipoEvento;
        private string DescripcionTipoEvento;

        public int IDTipoEvento1
        {
            get
            {
                return IDTipoEvento;
            }

            set
            {
                IDTipoEvento = value;
            }
        }

        public string NombreTipoEvento1
        {
            get
            {
                return NombreTipoEvento;
            }

            set
            {
                NombreTipoEvento = value;
            }
        }

        public string DescripcionTipoEvento1
        {
            get
            {
                return DescripcionTipoEvento;
            }

            set
            {
                DescripcionTipoEvento = value;
            }
        }
    }
}
