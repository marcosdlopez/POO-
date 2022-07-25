using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
  public  class HOSPITAL
    {
        private List<Especialidad> especialidades = new List<Especialidad>() ;

        private List<Medico> Medicos = new List<Medico>();

        private List<Atencion> atenciones = new List<Atencion>();

        private float recaudacion;
        public List<Especialidad> Especialidades
        {
            get {
                especialidades.Sort();
                return especialidades; 
            }
            
        }

        public List<Especialidad> ListarEspecialidadesxPacientes()
        {
            return (from Especialidad e in especialidades
                    orderby e.Pacientes descending
                    select e).ToList();

        }

        public void AtenderEspontaneo(Medico medico,Persona p )
        {
            Atencion atencion = new Atencion();
            atencion.Fecha = DateTime.Now;
            atencion.Medico = medico;
            p.HistoriaClinica.Registros.Add(atencion);
            recaudacion += medico.Costo;
        }
        public void AtenderEspontaneo(Medico medico,TurnoTomado turno)
        {
            AtencionProgramada atencion = new AtencionProgramada();
            if (turno is TurnoOrden)
            {
                TurnoOrden TO = (TurnoOrden)turno;
                TO.Especialidad.AgregarEstudio(TO.Orden.Estudio);

            }
            else
            {
                recaudacion += medico.Costo;
            }
            atencion.Fecha = turno.Fecha;
            atencion.Turno = turno;
            turno.Persona.HistoriaClinica.Registros.Add(atencion);
        }



        public float CalcularGanacia()
        {
            float total = (from Especialidad e in especialidades
                           select e.Ganancia).Sum() ;

            total += recaudacion;

            return total;

        }


    }
}
