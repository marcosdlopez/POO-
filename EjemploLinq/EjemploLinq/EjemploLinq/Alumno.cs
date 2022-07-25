using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLinq
{
    class Alumno:Persona
    {
        public Alumno(string n, int e):base(n,e)
        { }
        public override string ToString()
        {
            return "Alumno " + base.ToString() ;
        }
    }
}
