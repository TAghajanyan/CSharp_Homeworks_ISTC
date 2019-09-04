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
                new MyClass{Field1 = 1, Field2 = 2, Field3 = 3,},
                new MyClass{Field1 = 4, Field2 = 5, Field3 = 6,},
                new MyClass{Field1 = 7, Field2 = 8, Field3 = 9,}
            };

            var myCollection = myClasses.Where(x => x.Field1 % 2 != 0 || x.Field2 % 2 != 0).Select(x => x.Field3);

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
