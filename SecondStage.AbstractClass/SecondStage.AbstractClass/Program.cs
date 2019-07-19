using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SecondStage.AbstractClass
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string format;
            AbstractHandler @object = null;
            Aaa:
            Console.Write("Please input file format (XML, TXT, DOC): ");
            bool t = false;
            do
            {
                format = Console.ReadLine();
                switch (format)
                {
                    case "XML":
                        {
                            @object = new XMLHandler();
                            t = true;
                            break;
                        }
                    case "TXT":
                        {
                            @object = new TXTHandler();
                            t = true;
                            break;
                        }
                    case "DOC":
                        {
                            @object = new DOCHandler();
                            t = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong format! Please input again (XML, TXT, DOC)");
                            t = false;
                            break;
                        }
                }
            } while (!t);

            Console.WriteLine("\nYou are selected {0} format", format);
            Console.WriteLine("\nYou can. open {0} file, creat {0} file, change {0} file and save {0} file", format);
            Console.Write("Please input your operation type. open | creat | chenge | save | exit for exit: ");

            do
            {
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "open":
                        {
                            @object.Open();
                            break;
                        }
                    case "create":
                        {
                            @object.Create();
                            break;
                        }
                    case "change":
                        {
                            @object.Change();
                            break;
                        }
                    case "save":
                        {
                            @object.Save();
                            break;
                        }
                    case "exit":
                        {
                            t = false;
                            break;
                        }
                    case "change format":
                        {
                            goto Aaa;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong operation! Please input again. (open, create, change, save)");
                            t = true;
                            break;
                        }
                }
                Console.WriteLine("If you want to change format type input (change format) ");
            } while (t);
        }
    }
}
