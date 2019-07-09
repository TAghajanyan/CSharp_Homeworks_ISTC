using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Inheritance.Homework
{
    class Rabbit : Herbivore
    {
        private string[][] species = new string[4][];
        private static int maxAge = 12;

        public Rabbit() : base(maxAge, "Hair")
        {
            species[0] = new string[1] { "Small => (2 to 6 pounds; 0.9 to 2.7 kilograms)\n" };
            species[1] = new string[1] { "Medium => (6 to 9 pounds; 2.7 to 4.1 kilograms)\n" };
            species[2] = new string[1] { "Large (9 to 11 pounds; 4.1 to 5 kilograms)\n" };
            species[3] = new string[1] { "Giant (more than 11 pounds; more than 5 kilograms)\n" };
        }

        public void AboutRabbit()
        {
            Console.WriteLine("Rabbits are small, furry, mammals with long ears, short fluffy tails, and strong, large hind legs.\n"+
                              "They have 2 pairs of sharp incisors(front teeth), one pair on top and one pair on the bottom.\n"+
                              "They also have 2 peg teeth behind the top incisors.\n"+
                              "Their teeth are specifically adapted for gnawing and grow continuously throughout their lives.\n") ;
        }

        public void MoveInfo()
        {
            Console.WriteLine(" They have 4 toes on their hind feet that are long and webbed to keep them from spreading apart as they jump.\n"+
                              " Some species of rabbit can reach speeds of 35 to 45 miles per hour (55 to 70 kilometers per hour).\n" + 
                              " Young rabbits seem to walk instead of hop.\n");
        }

        public void SkinColorsInfo()
        {
            Console.WriteLine("Colors for the Rabbit skin vary but usually include a mix of: brown, black, white and gray. \n");
        }

        public string GetBreeds()
        {

            Console.WriteLine("Please input 'small' / 'medium' / 'large' / 'giant' / 'exit'");
            string s = Console.ReadLine();
            switch (s)
            {
                case "small":
                    {
                        Console.WriteLine(species[0][0]);
                        return GetBreeds();
                    }
                case "medium":
                    {
                        Console.WriteLine(species[1][0]);
                        return GetBreeds();
                    }
                case "large":
                    {
                        Console.WriteLine(species[2][0]);
                        return GetBreeds();
                    }
                case "giant":
                    {
                        Console.WriteLine(species[3][0]);
                        return GetBreeds();
                    }
                case "exit":
                    {
                        return null;
                    }

                default:
                    Console.WriteLine("\nWrong word!");
                    return GetBreeds();
            }
        }
    }
}
