using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Orden
    {
        private Medico medico;

        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        private Estudio estudio;

        public Estudio Estudio
        {
            get { return estudio; }
            set { estudio = value; }
        }
        private string diagnostico;

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        private string resultado;

        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }


    }
}