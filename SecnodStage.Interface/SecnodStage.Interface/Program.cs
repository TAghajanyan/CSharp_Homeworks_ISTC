using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecnodStage.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable operation1 = null;
            IRecodable operation2 = null;
            string oper;
            bool t = true;
            Console.Write("Please press '1' for playing music or press '2' for recording: ");

            AAA:
            int press = Convert.ToInt32(Console.ReadLine());
            switch (press)
            {
                case 1:
                    {
                        operation1 = new Player();
                        break;
                    }
                case 2:
                    {
                        operation2 = new Player();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please press '1' or '2'");
                        goto AAA;
                    }
            }

            do
            {
                if (operation1 != null)
                {
                    Console.WriteLine("Please input operation (play, pouse, stop)  for exit input (exit): ");
                    BBB:
                    oper = Console.ReadLine();
                    switch (oper)
                    {
                        case "play":
                            {
                                operation1.Play();
                                break;
                            }
                        case "pouse":
                            {
                                operation1.Pouse();
                                break;
                            }
                        case "stop":
                            {
                                operation1.Stop();
                                break;
                            }
                        case "exit":
                            {
                                t = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong operation! Please input (play | pouse | stop)  for exit input (exit)");
                                goto BBB;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Please input operation (Record, pouse, stop)  for exit input (exit): ");
                    CCC:
                    oper = Console.ReadLine();
                    switch (oper)
                    {
                        case "record":
                            {
                                operation2.Record();
                                break;
                            }
                        case "pouse":
                            {
                                operation2.Pouse();
                                break;
                            }
                        case "stop":
                            {
                                operation2.Stop();
                                break;
                            }
                        case "exit":
                            {
                                t = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong operation! Please input (record | pouse | stop)  for exit input (exit)");
                                goto CCC;
                            }
                    }
                }
            } while (t);
        }
    }
}
