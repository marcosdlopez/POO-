using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Polideportivo
    {
        private List<Cancha> canchas = new List<Cancha> ();

        private List<Persona> jueces = new List<Persona>();

        private List<Alquiler> alquileres = new List<Alquiler>();

        public List<Alquiler> Alquileres
        { 
        get { return alquileres; }
        }
        public List<Cancha> Canchas
        {
            get { return canchas ; }
            
        }

        public List<Persona> Jueces
        {
            get { return jueces; }
        }

        private float recaudacion;
        private float costos;

        public float Recaudacion
        {
            get { return recaudacion; }            
        }


        public float ObtenerGananciaTotal()
        {
            ClaseAmiga amiga = new ClaseAmiga();

            return recaudacion - costos;
        }

        internal ClaseAmiga DevolverAmiga()
        {
            return new ClaseAmiga();

        }


        private bool VerificarDisponibilidad(Alquiler alquiler)
        {
            bool ok = true;
            if (alquileres.Count >0)
            { 
                int c = 0;
                do
                {
                    if (alquileres[c].Cancha == alquiler.Cancha)
                    {
                        //fecha inicio y fin este por fuera de la reserva minima

                        if (alquileres[c].Fecha >= alquiler.FechaFin)
                        {
                            ok = true;
                        }
                        else if (alquileres[c].FechaFin <= alquiler.Fecha)
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }                        
                    
                    }
                    c++;
                } while (c < alquileres.Count && ok);

            }
            return ok;
        }

        private bool VerificarDisponibilidadPersona(AlquilerArbitro alquiler, Persona persona)
        {
            bool ok = true;
            if (alquileres.Count > 0)
            {
           
                foreach (Alquiler alq in alquileres)
                { 
                    if(alq is AlquilerArbitro)
                    {
                        if (!(alq.Fecha >= alquiler.FechaFin)|| (alq.FechaFin <= alquiler.Fecha))  
                        {
                            ok = ok && !((AlquilerArbitro)alq).ComprobarPersona(persona);
                           
                        }               

                    }
                }                          
                           

            }

            return ok;
        }


        public bool Alquilar(Alquiler alquiler)
        {
            bool ok = true;
            //Verificar si no esta ocupada
            ok = VerificarDisponibilidad(alquiler);

            if(ok && alquiler is AlquilerArbitro)
            {
                ok = VerificarDisponibilidadPersona( (AlquilerArbitro)alquiler, ((AlquilerArbitro)alquiler).Arbitro) ;

                if (ok && alquiler is AlquilerJuezLinea)
                {
                    ok = VerificarDisponibilidadPersona((AlquilerArbitro)alquiler, ((AlquilerJuezLinea)alquiler).JuezLinea1);
                    ok = ok && VerificarDisponibilidadPersona((AlquilerArbitro)alquiler, ((AlquilerJuezLinea)alquiler).JuezLinea2);
                }

           }
            if (ok)
            {
                recaudacion+= alquiler.ObtenerRecaudacion();
                if (alquiler is AlquilerArbitro)
                {
                    costos = ((AlquilerArbitro)alquiler).ObtenerCostos();
                    ((AlquilerArbitro)alquiler).PagarSueldos();
                }
                alquileres.Add(alquiler);
            }

            return ok;
        }


        public Cancha ObtenerCanchaMasAlquilada()
        {
            Cancha canchatmp = null;

            foreach (Cancha cancha in canchas)
            {
                if(canchatmp == null || canchatmp.CantidadAlquilada < cancha.CantidadAlquilada)
                {
                    canchatmp = cancha;   
                }
            }
            return canchatmp;
        }

        public Cancha ObtenerCanchaMasRecaudacion()
        {
            Cancha canchatmp = null;

            foreach (Cancha cancha in canchas)
            {
                if (canchatmp == null || canchatmp.Recaudacion < cancha.Recaudacion)
                {
                    canchatmp = cancha;
                }
            }
            return canchatmp;
        }

        public Persona ObtenerJuezMasRecaudacion()
        {
            Persona jueztmp = null;

            foreach (Persona juez in jueces)
            {
                if (jueztmp == null || jueztmp.Recaudacion < juez.Recaudacion )
                {
                    jueztmp = juez ;
                }
            }
            return jueztmp;
        }

        public Persona ObtenerJuezMasPartidos()
        {
            Persona jueztmp = null;

            foreach (Persona juez in jueces)
            {
                if (jueztmp == null || jueztmp.PartidosDirigidos < juez.PartidosDirigidos)
                {
                    jueztmp = juez;
                }
            }
            return jueztmp;
        }
    }
}