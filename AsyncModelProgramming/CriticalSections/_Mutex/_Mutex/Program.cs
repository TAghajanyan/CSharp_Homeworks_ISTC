using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _Mutex
{
    class Program
    {

        //static Mutex mutex = new Mutex(); //all app work simultaneously
        static Mutex mutex = new Mutex(false, "Mutex1"); //all app work sequence

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(Method);
                //Thread.Sleep(500);
                threads[i].Start();
            }
        }

        static void Method()
        {
            mutex.WaitOne();

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "\n");

            mutex.ReleaseMutex();
        }
    }
}
