using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Inheritance.Homework
{
    //    Շակալ
    class Hyena : Carnivore
    {
        private static int maxAge = 25;


        public Hyena() : base(maxAge, "Hair")
        {
        }

        public void AboutHyena()
        {
            Console.WriteLine("Although hyenas appear similar to dogs, they are actually more closely related to cats.\n" +
                              "They live throughout much of Africa and eastwards through Arabia to India.\n" +
                              "Spotted hyenas live together in large groups called clans that may include up 80 individuals and are led by females");
        }

        public void MoveInfo()
        {
            Console.WriteLine("These African animals are less skilled at stalking than cats and instead rely on their speed and stamina to run down their prey.\n"+
                              "They can sprint at 60 km / h and keep up a speed of 40 to 50 km / h over 5 km.\n"+
                              "They kill their prey by biting chunks out of it and targeting major blood vessels as it runs.");
        }

        public void SkinColorsInfo()
        {
            Console.WriteLine("They are members of the family Hyaenidae.\n" +
                              "The pelt can be light to dark-brown on brown hyenas, while the color can be gray,\n" +
                              "sometimes nearly white on striped hyenas Aardwolves have a warm, sand-colored coat,\n" +
                              "while the coats of spotted hyenas can range from dark-brown fur to amber and reddish in color");
        }
    }
}
