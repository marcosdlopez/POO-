using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class AtencionProgramada : Atencion
    {
        private TurnoTomado turno;

        public TurnoTomado Turno
        {
            get { return turno; }
            set { turno = value; }
        }


    }
}