using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAL
{
  public class CLS_FacArticulo_DAL
    {

        private int IDArticulo;
        private int IDEvento;
        private int IDZona;
        private int IDProgramacion;
        private decimal Precio_Articulo;

        public int IDArticulo1
        {
            get
            {
                return IDArticulo;
            }

            set
            {
                IDArticulo = value;
            }
        }

        public int IDEvento1
        {
            get
            {
                return IDEvento;
            }

            set
            {
                IDEvento = value;
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

        public int IDProgramacion1
        {
            get
            {
                return IDProgramacion;
            }

            set
            {
                IDProgramacion = value;
            }
        }

        public decimal Precio_Articulo1
        {
            get
            {
                return Precio_Articulo;
            }

            set
            {
                Precio_Articulo = value;
            }
        }
    }
}
