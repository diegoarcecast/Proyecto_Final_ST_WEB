using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAL
{
   public class CLS_EveProgramacion_DAL
    {

        private int IDProgramacion;
        private DateTime FechaProgramacion;
        private DateTime HoraProgramacion;
        private int IDLugar;

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

        public DateTime FechaProgramacion1
        {
            get
            {
                return FechaProgramacion;
            }

            set
            {
                FechaProgramacion = value;
            }
        }

        public DateTime HoraProgramacion1
        {
            get
            {
                return HoraProgramacion;
            }

            set
            {
                HoraProgramacion = value;
            }
        }

        public int IDLugar1
        {
            get
            {
                return IDLugar;
            }

            set
            {
                IDLugar = value;
            }
        }
    }
}
