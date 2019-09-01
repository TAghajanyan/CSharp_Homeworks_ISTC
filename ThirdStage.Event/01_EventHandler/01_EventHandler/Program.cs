using System;
using System.Threading;

namespace _01_EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEvent eventHandler = new MyEvent();
            eventHandler.AddMethods();

            do
            {

                DateTime time = DateTime.Now;
                eventHandler.InvokeEvent(time);
                Thread.Sleep(10000);

            } while (true);

        }
    }
}
