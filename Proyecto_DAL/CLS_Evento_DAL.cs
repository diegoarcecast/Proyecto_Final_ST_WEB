using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAL
{
   public class CLS_Evento_DAL
    {
        private int IDEvento;
        private string NombreEvento;
        private int TipoEvento;
        private int IDEstado;

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

        public string NombreEvento1
        {
            get
            {
                return NombreEvento;
            }

            set
            {
                NombreEvento = value;
            }
        }

        public int TipoEvento1
        {
            get
            {
                return TipoEvento;
            }

            set
            {
                TipoEvento = value;
            }
        }

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
    }
}
