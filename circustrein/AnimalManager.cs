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

            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.small });
            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.small });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.small });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.small });
            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.small });
            AnimalList.Add(new Animal() { carnivore = true, grote = (int)grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.large });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.small });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.small });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = (int)grotes.small });

            return AnimalList;
        }
    }
}
