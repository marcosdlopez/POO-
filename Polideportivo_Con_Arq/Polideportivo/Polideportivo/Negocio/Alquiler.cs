using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Alquiler
    {
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        protected int duracion;

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }


        public DateTime FechaFin
        {
           get { return fecha.AddHours(duracion); }

        }

        protected Cancha cancha;

        public Cancha Cancha
        {
            get { return cancha; }
            set { cancha = value; }
        }

        public virtual float ObtenerRecaudacion()
        {
            return cancha.Valor *duracion;
        }

        public override string ToString()
        {
            return cancha.Tipo.ToString() + " " + fecha.ToLongDateString() ;
        }

    }
}