using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
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

        private HistoriaClinica historia = new HistoriaClinica();

        public HistoriaClinica HistoriaClinica
        {
            get { return historia; }
            
        }

        public List<Item> CalcularCostosTratamiento()
        {
            List<Item> items = new List<Item>();

            foreach(TurnoOrden t in HistoriaClinica.ObtenerTurnoOrden())
            {
                Item item = new Item();
                item.Especialidad = t.Especialidad.Nombre;
                item.Costo = t.Orden.Estudio.Costo;
                items.Add(item);
            }

            return items;
        }

        public List<Atencion> ListarxEspecialidad(Especialidad e)
        {

            return (from Atencion at in historia.Registros
                    where at is AtencionProgramada &&
                          ((AtencionProgramada)at).Turno is TurnoOrden &&
                          ((TurnoOrden)((AtencionProgramada)at).Turno).Especialidad == e
                    select at).ToList();

        }
    }
}