using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase3
{
    public class Alimentacion
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public override string ToString()
        {
            return tipo;
        }
    }
}