using System;
using System.IO;

namespace _01_EventHandler
{
    class Handlers
    {
        public void Handler1(DateTime time, StreamWriter writer)
        {
            writer.WriteLine("Handler1: Time_{0}", time);
            Console.WriteLine("Handler1: Time_{0}", time);
        }

        public void Handler2(DateTime time, StreamWriter writer)
        {
            writer.WriteLine("Handler2: Time_{0}", time);
            Console.WriteLine("Handler2: Time_{0}", time);
        }

        public void Handler3(DateTime time, StreamWriter writer)
        {
            writer.WriteLine($"Handler3: Time_{time} {Environment.NewLine}{new string('-', 30)}");
            Console.WriteLine("Handler3: Time_{0}\n{1}", time, new string('-', 30));
        }
    }
}
