using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int legajo;

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }


        private float recaudacion;

        public float Recaudacion
        {
            get { return recaudacion; }

        }
        public void Cobrar(float dinero)
        {
            recaudacion += dinero;

        }



        private float partidosdirigidos;

        public float PartidosDirigidos
        {
            get { return partidosdirigidos; }

        }
        public void IncremetarPartidos()
        {
            partidosdirigidos++;

        }

        public override string ToString()
        {
            return nombre + "  " + apellido;
        }

    }
}