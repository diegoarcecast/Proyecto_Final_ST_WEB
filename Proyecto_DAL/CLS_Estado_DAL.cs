using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAL
{
   public  class CLS_Estado_DAL
    {

        private int IDEstado;
        private string NombreEstado;

        public int IDEstado1
        {
            get
            {
                return IDEstado;
            }

            set
            {
                IDEstado = value;
            }
        }

        public string NombreEstado1
        {
            get
            {
                return NombreEstado;
            }

            set
            {
                NombreEstado = value;
            }
        }
    }
}
