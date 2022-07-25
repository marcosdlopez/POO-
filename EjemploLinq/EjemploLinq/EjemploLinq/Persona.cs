using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLinq
{
    class Persona:IComparable,ICloneable,IDisposable
    {
        public Persona(string n, int e)
        {
            nombre = n;
            edad = e;

        }

      
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public override string ToString()
        {
            return nombre + " " + edad.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            else
            {
                Persona p = (Persona)obj;

                if (p.edad < this.edad)
                {

                    return 1;
                }
                else if (p.edad == this.edad)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }

            }


        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }



        private bool desechando = false;

        private void Desechar()
        {
            if (!desechando)
            {
                desechando = true;
                GC.SuppressFinalize(this);
                //Liberar todos los recursos
                //En especial los no administrados
            }

        }

        public void Dispose()
        {
            Desechar();  
        }
    }
}
