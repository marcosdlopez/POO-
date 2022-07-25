using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo1
{
    public class ControlRemoto
    {

        public void Subir(AireAcondicionado unAire)
        {
            unAire.Subir();
        }
        public void Bajar(AireAcondicionado unAire)
        {
            unAire.Bajar();
        }

        public void Encender(AireAcondicionado unAire)
        {
            unAire.Encender();
        }

    }
}