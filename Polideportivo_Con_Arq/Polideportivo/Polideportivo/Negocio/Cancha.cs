using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Cancha
    {
        private float valor;

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private EnumTipo tipo;

        public EnumTipo Tipo
        {
            get { return tipo; }
            set { 
                  tipo = value;
                
            }
        }


        private int cantidadAlquilada;

        public int CantidadAlquilada
        {
            get { return cantidadAlquilada; }
       
        }


        private float recaudacion;

        public float Recaudacion
        {
            get { return recaudacion; }

        }

        public void AumentarAlquiler()
        {
            cantidadAlquilada++;
        }

        public void IncrementarRecaudacion(float monto)
        {
            recaudacion += monto;
        }
    }
}