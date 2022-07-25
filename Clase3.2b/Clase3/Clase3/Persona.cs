using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Persona
    {


        public Persona(DateTime d)
        {
            fn = d;
        }

        public Persona(DateTime d, string n)
        {
            fn = d;
            nombre = n;
        }

        private DateTime fn ;

        public DateTime Fn
        {
            get
            {
                return fn;

            }

        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Etiqueta
        {
            get { return nombre + ": " + fn.ToString(); }

        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


    }
}
