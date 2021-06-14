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
        public void GetCarnivore_CarnivorePresent() {
            Wagon wagon = new Wagon(new Animal(AnimalType.Carnivore, Grotes.large));

            var ret = wagon.getcarnivore();
            Assert.IsNotNull(ret);
        }
    }
}
