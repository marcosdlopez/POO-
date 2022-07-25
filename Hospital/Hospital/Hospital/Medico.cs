using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Medico : Persona
    {
        public event delInformarTurnoTomado InformarTurno;

        private string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        protected float costo ;

        public virtual float Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        List<TurnoSinTomar> agenda = new List<TurnoSinTomar>();
        public List<TurnoSinTomar> Agenda
        { 
            get
            {
                return agenda;

            }
        }

        public void CrearTurno(DateTime Fecha)
        {
            TurnoSinTomar turno = new TurnoSinTomar();
            turno.Fecha = Fecha;
            agenda.Add(turno);
        }

        public void CrearAgenda(int Año, int mes, int dia, int horaDesde, int MinutoDesde, int horaHasta, int MinutoHasta, int intervalo)
        {
            DateTime fechaDesde = new DateTime(Año, mes, dia, horaDesde, MinutoDesde, 0);
            DateTime fechaHasta = new DateTime(Año, mes, dia, horaHasta, MinutoHasta, 0);
            while (fechaDesde <= fechaHasta)
            {
                CrearTurno(fechaDesde);

                fechaDesde = fechaDesde.AddMinutes(intervalo);
            }
        }


        public bool AgendarTurno(Persona p, DateTime fecha)
        {
            bool ok = false;
            //validar que esa fecha se encuentre en la agenda
            TurnoSinTomar turno = (from TurnoSinTomar t in agenda
                                   where t.Fecha == fecha
                                   select t).FirstOrDefault();

            if(turno !=null)
            {
                if(turno is TurnoTomado)
                {
                    InformarTurno("El turno fue tomado por otro paciente");
                }
                else
                {
                    ok = true;
                    TurnoTomado turnoTomado = new TurnoTomado();
                    turnoTomado.Persona = p;
                    turnoTomado.Fecha = turno.Fecha;

                    agenda.Remove(turno);
                    agenda.Add(turnoTomado);
                }

            }
            else
            {
                InformarTurno("El turno no existe");

            }

            return ok;
        }


    }
}