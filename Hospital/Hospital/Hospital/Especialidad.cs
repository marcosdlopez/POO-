using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Especialidad:IComparable
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private float ganancia  ;

        public float Ganancia
        {
            get { return ganancia; }
        
        }

        private int pacientes   ;

        public int Pacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }


        public void AgregarEstudio(Estudio est)
        {
            ganancia += est.Costo;
        }

        public int CompareTo(object obj)
        {
            return ganancia.CompareTo(obj);
        }

        private List<Estudio> estudios = new List<Estudio>();

        public List<Estudio> Estudios
        {
            get { return estudios; }
         
        }


    }
}