using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Inheritance.Homework
{
    //    Բուսակեր
    class Herbivore : Animal
    {
        public Herbivore(int maxAge, string skin) : base("Herbivore", maxAge, skin)
        {
        }

        public void TypeInfo()
        {
            Console.WriteLine("Herbivores are animals that only eat plants.\n"+
                              "They are herbivorous animals including humans.\n"+
                              "Humans are omnivores, because they eat meat as well as vegetable matter.\n");
        }
    }
}
