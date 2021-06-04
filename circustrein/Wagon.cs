using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Wagon
    {
        private List<Animal> Animals { get; set; }

        public Wagon()
        {
            Animals = new List<Animal>();
        }
        public Animal getcarnivore() 
        {
            foreach (var t in Animals) 
            {
                if (t.carnivore == true)
                    return t;
                else
                    return null;
            }
            return null;
        }

        public int ReturnPlaats() {
            int plaats = 0;
            foreach (Animal animal in Animals) {
                plaats += animal.grote;
            }
            return plaats;
        }

        public void addAnimal(Animal animal) 
        {
            Animals.Add(animal);
        }

        public IEnumerable<Animal> GetAnimals() {
            return Animals;
        }
    }
}
