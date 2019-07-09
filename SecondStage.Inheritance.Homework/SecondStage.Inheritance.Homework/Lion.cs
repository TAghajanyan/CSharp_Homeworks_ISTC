using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Inheritance.Homework
{
    class Lion : Carnivore
    {
        private static int maxAge = 15;


        public Lion() : base(maxAge, "Hair")
        {
        }

        public void AboutLion()
        {
            Console.WriteLine("Unlike other cats, lions are very social animals. They live in groups, called prides, of around 30 lions.\n" +
                              "A pride consists of up to three males, a dozen related females, and their young.\n" +
                              "The size of the pride is determined by the availability of food and water.");
        }

        public void MoveInfo()
        {
            Console.WriteLine("Lions can run 50 mph. These awesome cats can run as fast as 50 mph and leap up to 36 feet.\n" +
                              "Because of their lack of stamina, lions can only reach top speeds in short bursts");
        }

        public void SkinColorsInfo()
        {
            Console.WriteLine("Lions range in color from nearly white to tawny yellow, ash brown, ochre, and deep orange-brown");
        }


    }
}
