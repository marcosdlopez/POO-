using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase3
{
    public class Zoologico
    {

        private List<Animal> animales = new List<Animal>();

        private Alimentacion carnivoro;
        private Alimentacion herbivoro;

        public Zoologico()
        {
            carnivoro = new Alimentacion();
            carnivoro.Tipo = "Carnivoro";

            herbivoro = new Alimentacion();
            herbivoro.Tipo = "Herbivoro";
        }

        public Alimentacion Carnivoro
        {
            get
            {
                return carnivoro;
            }
        }

        public Alimentacion Herbivoro
        {
            get
            {
                return herbivoro;
            }
        }

        public List<Animal> Animales
        {
            get { return animales; }

        }


        public void Agregar(Animal animal)
        {

            animales.Add(animal);
        }

        public void Quitar(Animal animal)
        {
            animales.Remove(animal);
        }

        public List<Animal> DevolverPorTipo(Alimentacion tipo)
        {
            List<Animal> tipos = new List<Animal>();

            foreach (Animal anim in animales)
            { 
                if(anim.Alimentacion == tipo)
                {
                    tipos.Add(anim);
                }
            }

            return tipos;
        }

    }
}