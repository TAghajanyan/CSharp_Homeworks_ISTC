using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 6, 8, 4, 3, 9, 7, 2, 0 };
            BubbleSorting.RecursiveSorting(ref array, array.Length);
            //BubbleSorting.Sorting(ref array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
