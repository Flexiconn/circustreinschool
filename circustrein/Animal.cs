using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Animal
    {
        private AnimalType type { get; set; }
        private Grotes grote { get; set; }

        public bool CheckIfCompatible(Animal animal) 
        {
            if (this.type == AnimalType.Carnivore)
            {
                if (animal.grote > this.grote)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return true;
            }
        }

        public Grotes GetSize() {
            return grote;
        }

        public AnimalType GetAnimalType() {
            return type;
        }

        public Animal(AnimalType type, Grotes grote) {
            this.grote = grote;
            this.type = type;
        }
    }
}
