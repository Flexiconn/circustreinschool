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
    public class TreinTest
    {
        [TestMethod]
        public void FillWagons() {
            trein trein = new trein();
            trein.FillWagons(new List<Animal>() {
                new Animal(AnimalType.Carnivore, Grotes.large),
                new Animal(AnimalType.Carnivore, Grotes.medium),
                new Animal(AnimalType.Carnivore, Grotes.small),
                new Animal(AnimalType.Herbivore, Grotes.large),
                new Animal(AnimalType.Herbivore, Grotes.medium),
                new Animal(AnimalType.Herbivore, Grotes.small),

            });
            var ret = trein.GetTreinList();
            Assert.IsNotNull(ret);
        }
    }
}
