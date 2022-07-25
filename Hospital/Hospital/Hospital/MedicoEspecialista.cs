using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class MedicoEspecialista : Medico
    {
        private List<Especialidad> especialidades = new List<Especialidad>();

        public List<Especialidad> Especialidades
        { 
        get { return especialidades; }
        }

        public override float Costo {
            get {
                float valor = this.costo;
                foreach(Especialidad esp in Especialidades)
                {
                    valor += (costo * 15) / 100;

                }

                return valor;
            }
            set => base.Costo = value; }

    }
}