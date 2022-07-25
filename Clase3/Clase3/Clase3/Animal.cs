using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    public class Animal
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Alimentacion alimentacion;
        public Alimentacion Alimentacion
        {
            get { return alimentacion; }
            set
            {
                alimentacion = value;
            }
        }
    }
}
