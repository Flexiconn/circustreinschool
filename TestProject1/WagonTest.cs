using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using circustrein;

namespace TestProject1
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void GetCarnivore_CarnivorePresent() {
            Wagon wagon = new Wagon(new Animal(AnimalType.Carnivore, Grotes.large));

            var ret = wagon.getcarnivore();
            Assert.IsNotNull(ret);
        }

        [TestMethod]
        public void GetCarnivore_HerbivorePresent()
        {
            Wagon wagon = new Wagon(new Animal(AnimalType.Herbivore, Grotes.large));

            var ret = wagon.getcarnivore();
            Assert.IsNull(ret);
        }

        [TestMethod]
        public void GetPlaats_AnimalPresent()
        {
            Wagon wagon = new Wagon(new Animal(AnimalType.Herbivore, Grotes.large));

            var ret = false;
            if (wagon.ReturnPlaats() > 0) {
                ret = true;
            }
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void GetPlaats_AnimalNotPresent()
        {
            Wagon wagon = new Wagon();

            var ret = false;
            if (wagon.ReturnPlaats() > 0)
            {
                ret = true;
            }
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TryAddingAnimalToEmptyWagon()
        {
            Wagon wagon = new Wagon();

            var ret = wagon.TryAddingAnimal(new Animal(AnimalType.Carnivore, Grotes.medium));
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void TryAddingAnimalToFullWagon()
        {
            Wagon wagon = new Wagon();
            wagon.TryAddingAnimal(new Animal(AnimalType.Herbivore, Grotes.large));
            wagon.TryAddingAnimal(new Animal(AnimalType.Herbivore, Grotes.large));
            var ret = wagon.TryAddingAnimal(new Animal(AnimalType.Carnivore, Grotes.medium));
            Assert.IsFalse(ret);
        }
    }
}
