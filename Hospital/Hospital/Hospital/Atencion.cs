using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Atencion:IComparable
    {
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Medico medico;

        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        public float CalcularCosto()
        {
            float total = 0;


            return total;
        }

        public int CompareTo(object obj)
        {
            return fecha.CompareTo(obj);
        }
    }
}