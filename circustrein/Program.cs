using System;
using System.Collections.Generic;
using System.Linq;

namespace circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            trein train = new trein() { Naampie = "choo choo" };
            train.fill(new AnimalManager().AnimalList());
            foreach (var t in train.GetTreinList())
            {
                Console.WriteLine("inhoud: " +  "(" + t.ReturnPlaats() + ")");
                foreach (var i in t.GetAnimals())
                {
                    Console.WriteLine(i.grote + " is carnivore: " + i.carnivore);
                }
            }

            while (true)
            {

            }
        }
    }
}
