using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Inheritance.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            do
            {
                Console.WriteLine(new string('-', 25));
                Console.WriteLine("Please input type number: \nHerbivore -> 1 \nCarnivore -> 2 \nOmnivore -> 3 \nFor exit -> 0\n" + new string('-', 25));
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: // Herbivore
                        {
                            Rabbit rabbit = new Rabbit();

                            Console.WriteLine("You selected herbivore type.\n" + new string('-', 25));

                            do
                            {
                                Console.WriteLine("\nInput\n1 -> TypeInfo\n2 -> Rabbit\n0 -> exit");
                                int input1 = int.Parse(Console.ReadLine());

                                switch (input1)
                                {
                                    case 1: // TypeInfo
                                        {
                                            Console.WriteLine(new string('-', 25));
                                            rabbit.TypeInfo();
                                            break;
                                        }

                                    case 2: // Rabbit
                                        {
                                            do
                                            {
                                                Console.WriteLine(new string('-', 25));
                                                Console.WriteLine("   Input \n   1 -> AboutRabbit \n   2 -> MoveInfo \n   3 -> SkinColorsInfo \n   4 -> Breeds \n   5 -> MaxAge \n   6 -> Gender \n   7 -> Type \n   8 -> Skin \n   0 -> exit.");
                                                int input1_2 = int.Parse(Console.ReadLine());

                                                switch (input1_2)
                                                {
                                                    case 1: // AboutRabbit
                                                        {
                                                            rabbit.AboutRabbit();
                                                            break;
                                                        }

                                                    case 2: // MoveInfo
                                                        {
                                                            rabbit.MoveInfo();
                                                            break;
                                                        }

                                                    case 3: // SkinColorsInfo 
                                                        {
                                                            rabbit.SkinColorsInfo();
                                                            break;
                                                        }

                                                    case 4: // Breeds
                                                        {
                                                            Console.WriteLine(rabbit.GetBreeds());
                                                            break;
                                                        }

                                                    case 5: // MaxAge
                                                        {
                                                            Console.WriteLine("Max age: " + rabbit.MaxAge);
                                                            break;
                                                        }

                                                    case 6: // Gender
                                                        {
                                                            Console.WriteLine("Gender: " + Animal.Gender);
                                                            break;
                                                        }

                                                    case 7: // Type
                                                        {
                                                            Console.WriteLine("Type: " + rabbit.Type);
                                                            break;
                                                        }

                                                    case 8: // Skin
                                                        {
                                                            Console.WriteLine("Skin: " + rabbit.Skin);
                                                            break;
                                                        }

                                                    case 0: // exit
                                                        {
                                                            b = false;
                                                            break;
                                                        }

                                                    default:
                                                        {
                                                            Console.WriteLine("Wrong number!");
                                                            break;
                                                        }
                                                }

                                            } while (b);

                                            b = true;
                                            break;
                                        }

                                    case 0: // exit
                                        {
                                            b = false;
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("Wrong number please input 1 or 2 or 0");
                                            break;
                                        }
                                }

                            } while (b);
                            b = true;
                            break;
                        }

                    case 2: // Carnivore
                        {
                            do
                            {
                                Carnivore carnivore = new Lion();

                                Console.WriteLine("Input\n1 -> TypeInfo \n2 -> Lion \n3 -> Hyena \n0 -> Exit");
                                int input2 = int.Parse(Console.ReadLine());
                                switch (input2)
                                {
                                    case 1: // TypeInfo
                                        {
                                            carnivore.TypeInfo();
                                            break;
                                        }

                                    case 2: // Lion
                                        {
                                            Lion lion = new Lion();
                                            do
                                            {
                                                Console.WriteLine(new string('-', 25));
                                                Console.WriteLine("   Input \n   1 -> AboutLion \n   2 -> MoveInfo \n   3 -> SkinColorsInfo \n   4 -> GetType \n   5 -> GetMaxAge \n   6 -> GetSkin \n   7 -> GetGender \n   0 -> Exit");
                                                int input2_1 = int.Parse(Console.ReadLine());
                                                switch (input2_1)
                                                {
                                                    case 1: // AboutLion
                                                        {
                                                            lion.AboutLion();
                                                            break;
                                                        }
                                                    case 2: // MoveInfo
                                                        {
                                                            lion.MoveInfo();
                                                            break;
                                                        }
                                                    case 3: // SkinColorsInfo
                                                        {
                                                            lion.SkinColorsInfo();
                                                            break;
                                                        }
                                                    case 4: // GetType
                                                        {
                                                            Console.WriteLine("Lion type: " + lion.Type);
                                                            break;
                                                        }
                                                    case 5: // GetMaxAge
                                                        {
                                                            Console.WriteLine("Lion max age: " + lion.MaxAge);
                                                            break;
                                                        }
                                                    case 6: // GetSkin
                                                        {
                                                            Console.WriteLine("Lion skin: " + lion.Skin);
                                                            break;
                                                        }
                                                    case 7: // GetGender
                                                        {
                                                            Console.WriteLine("Lion gender: " + Lion.Gender);
                                                            break;
                                                        }
                                                    case 0: // Exit
                                                        {
                                                            b = false;
                                                            break;
                                                        }

                                                    default:
                                                        {
                                                            Console.WriteLine("Wrong number!");
                                                            break;
                                                        }
                                                }

                                            } while (b);
                                            b = true;
                                            break;
                                        }

                                    case 3: // Hyena
                                        {
                                            Hyena hyena = new Hyena();
                                            do
                                            {
                                                Console.WriteLine(new string('-', 25));
                                                Console.WriteLine("   Input \n   1 -> AboutHyena \n   2 -> MoveInfo \n   3 -> SkinColorsInfo \n   4 -> GetType \n   5 -> GetMaxAge \n   6 -> GetSkin \n   7 -> GetGender \n   0 -> Exit");
                                                int input2_2 = int.Parse(Console.ReadLine());

                                                switch (input2_2)
                                                {

                                                    case 1: // AboutHyena
                                                        {
                                                            hyena.AboutHyena();
                                                            break;
                                                        }
                                                    case 2: // MoveInfo
                                                        {
                                                            hyena.MoveInfo();
                                                            break;
                                                        }
                                                    case 3: // SkinColorsInfo
                                                        {
                                                            hyena.SkinColorsInfo();
                                                            break;
                                                        }
                                                    case 4: // GetType
                                                        {
                                                            Console.WriteLine("Hyena type: " + hyena.Type);
                                                            break;
                                                        }
                                                    case 5: // GetMaxAge
                                                        {
                                                            Console.WriteLine("Hyena max age: " + hyena.MaxAge);
                                                            break;
                                                        }
                                                    case 6: // GetSkin
                                                        {
                                                            Console.WriteLine("Hyena skin: " + hyena.Skin);
                                                            break;
                                                        }
                                                    case 7: // GetGender
                                                        {
                                                            Console.WriteLine("Hyena gender: " + Lion.Gender);
                                                            break;
                                                        }
                                                    case 0: // Exit
                                                        {
                                                            b = false;
                                                            break;
                                                        }

                                                    default:
                                                        {
                                                            Console.WriteLine("Wrong number!");
                                                            break;
                                                        }
                                                }

                                            } while (b);
                                            b = true;
                                            break;
                                        }

                                    case 0: // Exit
                                        {
                                            b = false;
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("Wrong word!");
                                            break;
                                        }
                                }

                            } while (b);
                            b = true;
                            break;
                        }

                    case 3: // Omnivore
                        {
                            Man man = new Man();

                            Console.WriteLine("You selected omnivore type.\n" + new string('-', 25));

                            do
                            {
                                Console.WriteLine("\nInput\n1 -> TypeInfo\n2 -> Man\n0 -> exit");
                                int input1 = int.Parse(Console.ReadLine());

                                switch (input1)
                                {
                                    case 1: // TypeInfo
                                        {
                                            Console.WriteLine(new string('-', 25));
                                            man.TypeInfo();
                                            break;
                                        }

                                    case 2: // man
                                        {
                                            do
                                            {
                                                Console.WriteLine(new string('-', 25));
                                                Console.WriteLine("   Input \n   1 -> AboutMan \n   2 -> GetFullName \n   3 -> ChangeFirstName \n   4 -> ChangeLastName \n   5 -> ChangeAge \n " +
                                                                  "  6 -> ChangeGender \n   7 -> GetMaxAge \n   8 -> GetGender \n   9 -> GetType \n   10 -> GetSkin \n   11 -> GetAge \n   0 -> exit.");
                                                int input1_2 = int.Parse(Console.ReadLine());

                                                switch (input1_2)
                                                {
                                                    case 1: // AboutMan
                                                        {
                                                            man.AboutMan();
                                                            break;
                                                        }
                                                    case 2: // FullName
                                                        {
                                                            Console.WriteLine("Full name: " + man.GetFullName());
                                                            break;
                                                        }

                                                    case 3: // ChangeFirstName
                                                        {
                                                            Console.Write("Input new first name: ");
                                                            man.ChangeFirstName(Console.ReadLine());
                                                            break;
                                                        }
                                                    case 4: // ChangeLastName
                                                        {
                                                            Console.Write("Input new last name: ");
                                                            man.ChangeLastName(Console.ReadLine());
                                                            break;
                                                        }
                                                    case 5: // ChangeAge
                                                        {
                                                            Console.Write("Input new age: ");
                                                            man.ChangeAge(int.Parse(Console.ReadLine()));
                                                            break;
                                                        }
                                                    case 6: // ChangeGender
                                                        {
                                                            Console.Write("Input new gender: ");
                                                            man.ChangeGender(Console.ReadLine());
                                                            break;
                                                        }

                                                    case 7: // MaxAge
                                                        {
                                                            Console.WriteLine("Max age: " + man.MaxAge);
                                                            break;
                                                        }

                                                    case 8: // Gender
                                                        {
                                                            Console.WriteLine("Gender: " + man.Gender);
                                                            break;
                                                        }

                                                    case 9: // Type
                                                        {
                                                            Console.WriteLine("Type: " + man.Type);
                                                            break;
                                                        }

                                                    case 10: // Skin
                                                        {
                                                            Console.WriteLine("Skin: " + man.Skin);
                                                            break;
                                                        }

                                                    case 11: // Age
                                                        {
                                                            Console.WriteLine("Age: " + man.Age);
                                                            break;
                                                        }

                                                    case 0: // exit
                                                        {
                                                            b = false;
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            Console.WriteLine("Wrong number!");
                                                            break;
                                                        }
                                                }

                                            } while (b);

                                            b = true;
                                            break;
                                        }

                                    case 0: // exit
                                        {
                                            b = false;
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("Wrong number please input 1 or 2 or 0");
                                            break;
                                        }
                                }

                            } while (b);
                            b = true;
                            break;
                        }

                    case 0: // Exit
                        {
                            Console.WriteLine("Bye~");
                            b = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nWrong choice");
                            break;
                        }
                }
            } while (b);

            Console.ReadKey();
        }
    }
}
