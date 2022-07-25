using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo
{
    public class ControlRemoto
    {
        public void Encender(Televisor unaTele)
        {
            unaTele.Encender();
        }

        public void SubirCanal(Televisor unaTele)
        {
            if (!unaTele.encendido)
            {
                this.Encender(unaTele);
            }
            unaTele.SubirCanal();
        }
        public void Bajar(Televisor unaTele)
        {
            if (!unaTele.encendido)
            {
                this.Encender(unaTele);
            }
            unaTele.BajarCanal();
        }

    }
}