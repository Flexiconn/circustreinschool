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

        public IEnumerable<Wagon> GetTreinList() {
            return Wagons;
        }

        public void CreateWagon() {
            Wagons.Add(new Wagon());
        }

        public void AddAnimalToWagon(int index)
        {
            Wagons[index].addAnimal(new Animal());
        }

        public void TreinAddAtIndex(int index, Animal animal) {
            Wagons[index].addAnimal(animal);
        }

        public void fill(List<Animal> animals) {
            animals = animals.OrderByDescending(o => o.grote).ToList();
            foreach (Animal animal in animals.ToList()) {
                if (animal.carnivore == true) {
                    Wagons.Add(new Wagon());
                    Wagons[Wagons.Count - 1].addAnimal(animal);
                    animals.Remove(animal);
                }
            }

            animals = animals.OrderByDescending(o => o.grote).ToList();
            foreach (Animal Animal in animals.ToList())
            {
                foreach (var wagon in Wagons.ToList())
                {
                    if (wagon.getcarnivore().grote >= Animal.grote)
                    {
                        continue;
                    }else if (10 - wagon.ReturnPlaats() >= Animal.grote)
                    {
                        wagon.addAnimal(Animal);
                        animals.Remove(Animal);
                        break;
                    }
                }
            }

            animals = animals.OrderByDescending(o => o.grote).ToList();
            foreach (Animal animal in animals.ToList())
            {
                foreach (Wagon wagon in Wagons.ToList())
                {
                    if (wagon.getcarnivore() != null && wagon != Wagons[Wagons.Count - 1]) {
                        continue;
                    }
                    if (10 - wagon.ReturnPlaats() >= animal.grote && wagon.getcarnivore() == null)
                    {
                        wagon.addAnimal(animal);
                        animals.Remove(animal);
                        break;
                    }
                    else
                    {
                        if (10 - Wagons[Wagons.Count - 1].ReturnPlaats() >= animal.grote && wagon.getcarnivore() == null)
                        {

                            Wagons[Wagons.Count - 1].addAnimal(animal);
                            animals.Remove(animal);
                        }
                        else {

                            Wagons.Add(new Wagon());
                            Wagons[Wagons.Count - 1].addAnimal(animal);
                            animals.Remove(animal);
                        }
                        break;
                    }
                }
            }
        }
    }
}
