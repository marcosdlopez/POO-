using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class TurnoTomado : TurnoSinTomar
    {
        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

    }
}