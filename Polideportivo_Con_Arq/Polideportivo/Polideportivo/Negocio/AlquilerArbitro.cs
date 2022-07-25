using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class AlquilerArbitro : Alquiler
    {
        private Persona arbitro;

        public Persona Arbitro
        {
            get { return arbitro; }
            set { arbitro = value; }
        }

        public override float ObtenerRecaudacion()
        {
            return base.ObtenerRecaudacion() + (100 * this.duracion);
        }

        public virtual float ObtenerCostos()
        {
            return 50 * duracion;
        }

        public virtual void PagarSueldos()
        {
            arbitro.IncremetarPartidos();
            arbitro.Cobrar(50 * duracion);
        }


        public virtual bool ComprobarPersona(Persona p)
        {
            return p == this.arbitro;
        }
    }
}