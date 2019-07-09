using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Inheritance.Homework
{
    //    Գիշատիչ
    class Carnivore : Animal
    {
        public Carnivore(int maxAge, string skin) : base("Carnivore", maxAge, skin)
        {
        }

        public void TypeInfo()
        {
            Console.WriteLine("A carnivore is an animal that gets food from killing and eating other animals.\n" +
                              "Carnivores generally eat herbivores, but can eat omnivores, and occasionally other carnivores.\n");
        }

    }
}
