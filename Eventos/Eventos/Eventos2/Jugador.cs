using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventos2
{
    public class Jugador
    {
        Random rnd = new Random();

        public event delReaccionar Festejar;

        public event delReaccionar Insultar;


        public void Patear()
        {
            if (rnd.Next(0,2) == 0)
            {
                Insultar("Mi suegra y la....");

            }
            else
            {
                Festejar("Goooool");

            }



        }

    }
}