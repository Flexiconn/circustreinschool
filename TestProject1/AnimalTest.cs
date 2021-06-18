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
    public class AnimalTest
    {
        [TestMethod]
        public void CheckIfCompatible_TwoCarnivore() {
            var animal1 = new Animal(AnimalType.Carnivore, Grotes.large);
            var animal2 = new Animal(AnimalType.Carnivore, Grotes.large);

            var ret = animal1.CheckIfCompatible(animal2);
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void CheckIfCompatible_SmallCarnivore_BigHerbivore()
        {
            var animal1 = new Animal(AnimalType.Carnivore, Grotes.small);
            var animal2 = new Animal(AnimalType.Herbivore, Grotes.large);

            var ret = animal1.CheckIfCompatible(animal2);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void CheckIfCompatible_BigCarnivore_SmallHerbivore()
        {
            var animal1 = new Animal(AnimalType.Herbivore, Grotes.small);
            var animal2 = new Animal(AnimalType.Carnivore, Grotes.large);

            var ret = animal1.CheckIfCompatible(animal2);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void CheckIfCompatible_TwoHerbivore()
        {
            var animal1 = new Animal(AnimalType.Herbivore, Grotes.large);
            var animal2 = new Animal(AnimalType.Herbivore, Grotes.large);

            var ret = animal1.CheckIfCompatible(animal2);
            Assert.IsTrue(ret);
        }
    }
}
