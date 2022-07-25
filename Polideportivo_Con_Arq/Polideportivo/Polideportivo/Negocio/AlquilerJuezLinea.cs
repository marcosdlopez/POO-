using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class AlquilerJuezLinea : AlquilerArbitro
    {
        private Persona juez1;

        public Persona JuezLinea1
        {
            get { return juez1; }
            set { juez1 = value; }
        }
        private Persona juez2;

        public Persona JuezLinea2
        {
            get { return juez2; }
            set { juez2 = value; }
        }

        public override float ObtenerRecaudacion()
        {
            return base.ObtenerRecaudacion() + (90 * duracion);
        }
        public override void PagarSueldos()
        {
            base.PagarSueldos();
            juez1.IncremetarPartidos();
            juez2.IncremetarPartidos();
            juez1.Cobrar(35 * duracion);
            juez2.Cobrar(35 * duracion);
        }

        public override float ObtenerCostos()
        {
            return base.ObtenerCostos() + (70 * duracion);
        }

        public override bool ComprobarPersona(Persona p)
        {
            return base.ComprobarPersona(p) || juez1 == p || juez2 == p;
        }

    }
}