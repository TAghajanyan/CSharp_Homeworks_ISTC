using System;
using System.Collections.Generic;

namespace ThirdStage.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyClass> myClasses = new List<MyClass>
            {
                new MyClass{Filed1 = 1, Filed2 = 2, Filed3 = 3,},
                new MyClass{Filed1 = 4, Filed2 = 5, Filed3 = 6,},
                new MyClass{Filed1 = 7, Filed2 = 8, Filed3 = 9,}
            };

            var myCollection = myClasses.Where(x => x.Filed1 % 2 != 0 || x.Filed2 % 2 != 0).Select(x => x.Filed3);

            int i = 0;
            foreach (var item in myCollection)
            {
                Console.WriteLine($"Item{++i}: {item}" );
            }

            var firstOrDefault = myCollection.FirstOrDefault();
            Console.WriteLine("FirstOrDefault: " + firstOrDefault);
        }
    }
}
