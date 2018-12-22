using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAL
{
   public class CLS_FacCompra_DAL
    {
        private int IDCompra;
        private int IDUsuario;
        private int IDArticulo;
        private int CantidadCompra;
        private decimal MontoCompra;
        private DateTime FechaCompra;

        public int IDCompra1
        {
            get
            {
                return IDCompra;
            }

            set
            {
                IDCompra = value;
            }
        }

        public int IDUsuario1
        {
            get
            {
                return IDUsuario;
            }

            set
            {
                IDUsuario = value;
            }
        }

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

        public int CantidadCompra1
        {
            get
            {
                return CantidadCompra;
            }

            set
            {
                CantidadCompra = value;
            }
        }

        public decimal MontoCompra1
        {
            get
            {
                return MontoCompra;
            }

            set
            {
                MontoCompra = value;
            }
        }

        public DateTime FechaCompra1
        {
            get
            {
                return FechaCompra;
            }

            set
            {
                FechaCompra = value;
            }
        }
    }
}
