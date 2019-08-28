using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_02_ParallelClass
{
    class Program
    {
        static void Method1()
        {
            int ID = Thread.CurrentThread.ManagedThreadId;

            Console.WriteLine("Start Method1. Thread ID: " + ID);
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(300);
                Console.Write("1 ");
            }
            Console.WriteLine("End Method1. Thread ID: " + ID);
        }

        static void Method2()
        {
            int ID = Thread.CurrentThread.ManagedThreadId;

            Console.WriteLine("Start Method2. Thread ID: " + ID);
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(300);
                Console.Write("2 ");
            }
            Console.WriteLine("End Method2. Thread ID: " + ID);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start Main.");

            ParallelOptions options = new ParallelOptions();

            options.MaxDegreeOfParallelism = 4;

            Console.WriteLine("Logical processors count: " + Environment.ProcessorCount);

            Thread.Sleep(2000);

            Parallel.Invoke(options, Method1, Method2, Method1, Method2);
        }
    }
}
