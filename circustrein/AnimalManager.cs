using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class AnimalManager
    {
        public List<Animal> AnimalList()
        {
            List<Animal> AnimalList = new List<Animal>();

            AnimalList.Add(new Animal(AnimalType.Carnivore, Grotes.large));
            AnimalList.Add(new Animal(AnimalType.Herbivore, Grotes.large));
            AnimalList.Add(new Animal(AnimalType.Herbivore, Grotes.large));
            AnimalList.Add(new Animal(AnimalType.Herbivore, Grotes.large));
            AnimalList.Add(new Animal(AnimalType.Carnivore, Grotes.small));
            AnimalList.Add(new Animal(AnimalType.Carnivore, Grotes.medium));
            AnimalList.Add(new Animal(AnimalType.Carnivore, Grotes.small));


            return AnimalList;
        }
    }
}
