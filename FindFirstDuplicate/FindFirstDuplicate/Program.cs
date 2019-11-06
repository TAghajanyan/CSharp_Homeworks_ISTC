using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFirstDuplicate
{
    class Program
    {
        static int FirstDuplicate(params int[] arr)
        {
            int[] temp = new int[arr.Max() + 1];
            
            foreach (int item in arr)
            {
                if (temp[item] == 0)
                {
                    temp[item] = item;
                }
                else
                {
                    return item;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FirstDuplicate(1, 2, 3, 4, 50000, 6, 8, 6, 3)); // output 6
        }
    }
}
