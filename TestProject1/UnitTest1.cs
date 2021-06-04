using Microsoft.VisualStudio.TestTools.UnitTesting;
using circustrein;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FillWagonWithAnimals()
        {
            trein trein = new trein();
            AnimalManager managWer = new AnimalManager();
            trein.fill(new AnimalManager().AnimalList());

        }

        [TestMethod]
        public void FillWagonWithEmptyList()
        {
            trein trein = new trein();
            trein.fill(new List<Animal>());

        }

        [TestMethod]
        public void AddAnimal()
        {
            trein trein = new trein();
            trein.CreateWagon();
            trein.TreinAddAtIndex(0, new Animal());

        }

        [TestMethod]
        public void GetCarnivore()
        {
            Wagon wagon = new Wagon();
            wagon.addAnimal(new Animal() { carnivore = true, grote = 5 });
            wagon.getcarnivore();
        }

        [TestMethod]
        public void ReturnPlaats()
        {
            Wagon wagon = new Wagon();
            wagon.addAnimal(new Animal() { carnivore = true, grote = 5 });
            wagon.ReturnPlaats();
        }

        [TestMethod]
        public void GetAnimals()
        {
            Wagon wagon = new Wagon();
            wagon.addAnimal(new Animal() { carnivore = true, grote = 5 });
            wagon.GetAnimals();
        }

        [TestMethod]
        public void CreateWagon()
        {
            trein trein = new trein();
            trein.CreateWagon();
        }
    }
}
