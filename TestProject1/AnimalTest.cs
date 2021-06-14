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
            var carnivore1 = new Animal(AnimalType.Carnivore, Grotes.large);
            var carnivore2 = new Animal(AnimalType.Carnivore, Grotes.large);

            var ret = carnivore1.CheckIfCompatible(carnivore2);
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void CheckIfCompatible_SmallCarnivore_BigHerbivore()
        {
            var carnivore1 = new Animal(AnimalType.Carnivore, Grotes.small);
            var carnivore2 = new Animal(AnimalType.Herbivore, Grotes.large);

            var ret = carnivore1.CheckIfCompatible(carnivore2);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void CheckIfCompatible_BigCarnivore_SmallHerbivore()
        {
            var carnivore1 = new Animal(AnimalType.Herbivore, Grotes.small);
            var carnivore2 = new Animal(AnimalType.Carnivore, Grotes.large);

            var ret = carnivore1.CheckIfCompatible(carnivore2);
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void CheckIfCompatible_TwoHerbivore()
        {
            var carnivore1 = new Animal(AnimalType.Herbivore, Grotes.large);
            var carnivore2 = new Animal(AnimalType.Herbivore, Grotes.large);

            var ret = carnivore1.CheckIfCompatible(carnivore2);
            Assert.IsTrue(ret);
        }
    }
}
