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
        private int plaats { get { return 10; } }

        public Wagon()
        {
            Animals = new List<Animal>();
        }

        public Animal getcarnivore() 
        {
            foreach (var t in Animals) 
            {
                if (t.GetAnimalType() == AnimalType.Carnivore)
                    return t;
                else
                    return null;
            }
            return null;
        }

        public int ReturnPlaats() {
            int plaats = 0;
            foreach (Animal animal in Animals) {
                plaats += (int)animal.GetSize();
            }
            return plaats;
        }

        public bool TryAddingAnimal(Animal animal) {
            if ((plaats - ReturnPlaats()) >= (int)animal.GetSize())
            {
                foreach (Animal animalTest in Animals)
                {
                    if (!animalTest.CheckIfCompatible(animal))
                    {
                        return false;
                    }
                }
                AddAnimal(animal);
                return true;
            }
            else {
                return false;

            }
        }

        private void AddAnimal(Animal animal) 
        {
            Animals.Add(animal);
        }

        public IEnumerable<Animal> GetAnimals() {
            return Animals;
        }

        public Wagon(Animal animal) {
            Animals = new List<Animal>();
            AddAnimal(animal);
        }
    }
}
