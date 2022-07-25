using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class TurnoOrden : TurnoTomado
    {
        private Orden orden;

        public Orden Orden
        {
            get { return orden; }
            set { orden = value; }
        }

        private Especialidad especialidad;

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }



    }
}