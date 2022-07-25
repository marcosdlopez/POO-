using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo1
{
    public class AireAcondicionado
    {
        public string Marca;
        public string Color;
        public int Frigorias ;

        public int Temperatura = 24;

        public int TempMax =30;
        public int TempMin =17;
       
     
        public bool Encendido = false;

        public void Encender()
        {

            Encendido = !Encendido;
     
        }


        public void Subir()
        {
            if (Encendido && Temperatura +1 <= TempMax)
            { 
                Temperatura++;
            }
        }

        public void Bajar()
        {
            if (Encendido && Temperatura - 1 >= TempMin)
            {
                Temperatura--;
            }
        }



    }
}