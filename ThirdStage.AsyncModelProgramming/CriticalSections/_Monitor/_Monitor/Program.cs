using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _Monitor
{
    class Program
    {
        static object obj = new object();

        static void Method()
        {
            Monitor.Enter(obj);
            Console.WriteLine("Start[CurrentThread ID: {0}]", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1200);
            Console.WriteLine("Finish[CurrentThread ID: {0}]", Thread.CurrentThread.ManagedThreadId);
            Monitor.Exit(obj);

            // Or-------------------------------

            //lock (obj)
            //{
            //    Console.WriteLine("Start[CurrentThread ID: {0}]", Thread.CurrentThread.ManagedThreadId);
            //    Thread.Sleep(1200);
            //    Console.WriteLine("Finish[CurrentThread ID: {0}]", Thread.CurrentThread.ManagedThreadId);
            //}
        }

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Method);
                threads[i].Start();
            }

            Console.ReadKey();
        }
    }
}
