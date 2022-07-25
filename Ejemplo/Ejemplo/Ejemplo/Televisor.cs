using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo
{
    public class Televisor
    {
        public string Marca;
        public string Color;

        public bool encendido = false;

        public int canalactual =2;
        public int canalMax=10;
        public int canalMin=2;

        public void Encender()
        {
            encendido = !encendido;

        }

        public bool SubirCanal()
        {
            bool resultado = false;
            if (encendido)
            {
                canalactual = (canalactual + 1 > canalMax) ? canalMin : canalactual + 1;
                resultado = true;
            }
            return resultado;
        }
        public bool BajarCanal()
        {
            bool resultado = false;
            if (encendido)
            {

                canalactual = (canalactual-1 < canalMin) ? canalMax : canalactual-1;

                resultado = true;
            }
            return resultado;
        }



    }
}