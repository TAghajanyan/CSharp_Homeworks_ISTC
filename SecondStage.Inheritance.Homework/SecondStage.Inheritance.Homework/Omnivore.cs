using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Inheritance.Homework
{
    //    Գիշատիչ և բուսակեր
    class Omnivore : Animal
    {
        public Omnivore(int maxAge, string skin) : base("Omnivore", maxAge, skin)
        {
        }

        public void TypeInfo()
        {
            Console.WriteLine("An omnivore is a kind of animal that eats either other animals or plants.\n"+
                              "Some omnivores will hunt and eat their food, like carnivores, eating herbivores and other omnivores.\n"+
                              "Some others are scavengers and will eat dead matter. Many will eat eggs from other animals.\n");
        }
    }
}
