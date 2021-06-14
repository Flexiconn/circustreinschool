using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class trein
    {

        private List<Wagon> Wagons { get; set; }
        public string Naampie { get; set; }

        public trein() 
        {
            Wagons = new List<Wagon>();
        }

        public void FillWagons(List<Animal> animals)
        {
            animals = OrderAnimalList(animals);
            foreach (Animal animal in AddCarnivoreWagons(animals))
            {
                animals.Remove(animal);
            }

            animals = OrderAnimalList(animals);
            foreach (Animal animal in AddHerbivores(animals))
            {
                Console.WriteLine(animal.GetSize() + " " + animal.GetAnimalType());

                animals.Remove(animal);
            }
        }

        public IEnumerable<Wagon> GetTreinList() {
            return Wagons;
        }

        private List<Animal> AddCarnivoreWagons(List<Animal> animals)
        {
            List<Animal> AnimalsToRemove = new List<Animal>();
            foreach (Animal animal in animals) {
                if (animal.GetAnimalType() == AnimalType.Carnivore)
                    {
                    Wagons.Add(new Wagon(animal));
                    AnimalsToRemove.Add(animal);
                    }
                }
            return AnimalsToRemove;
        }

        private List<Animal> OrderAnimalList(List<Animal> animals) {
            return animals.OrderByDescending(o => o.GetSize()).ToList();
        }

        private List<Animal> AddHerbivores(List<Animal> animals) {
            List<Animal> AnimalsToRemove = new List<Animal>();
            foreach (Animal animal in animals) {
                bool added = false;
                foreach (var wagon in Wagons.ToList())
                {
                    if (wagon.TryAddingAnimal(animal))
                    {
                        added = true;
                        break;
                    }
                }
                if (added == false) {
                    Wagons.Add(new Wagon(animal));
                    AnimalsToRemove.Add(animal);
                }
            }
            return AnimalsToRemove;
        }

        
    }
}
