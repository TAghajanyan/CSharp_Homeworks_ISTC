using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Semaphore
{
    class Program
    {
        static Semaphore semaphore;

        static void Method()
        {
            semaphore.WaitOne();
            Console.WriteLine("Start[CurrentThread ID: {0}]\n", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1200);
            Console.WriteLine("Finish[CurrentThread ID: {0}]\n", Thread.CurrentThread.ManagedThreadId);
            semaphore.Release(1);
        }

        static void Main(string[] args)
        {
            semaphore = new Semaphore(6,11);

            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Method);
                thread.Start();
            }
        }
    }
}
