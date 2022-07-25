using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class HistoriaClinica
    {
        private Persona paciente;

        public Persona Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        private List<Atencion> registros = new List<Atencion>();

        public List<Atencion> Registros
        {
            get {
                registros.Sort();
                return registros; }
         
        }


        public  List<TurnoOrden>ObtenerTurnoOrden()
        {
            List<TurnoOrden> lista = new List<TurnoOrden>();

            foreach(Atencion at in Registros)
            {
                if (at is AtencionProgramada)
                {
                    if (((AtencionProgramada)at).Turno is TurnoOrden)
                    {
                        lista.Add((TurnoOrden)((AtencionProgramada)at).Turno);
                    }
                
                }


            }

            return lista;

        }


    }
}