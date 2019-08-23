using System;
using System.Collections.Generic;
using System.Threading;

namespace ThirdStage._GC
{
    class Program
    {
        static void Main(string[] args)
        {
            long memory = GC.GetTotalMemory(false) / 1024;

            Console.WriteLine("Total memory in first: " + memory + "KB");

            for (int i = 0; i < 10; i++)
            { 
                Console.WriteLine(i+1 + new string('-',25));

                using (ResourceManager resource = new ResourceManager())
                {
                    resource.SetManagedResourceValue(out memory);
                    Console.Write("\nTotal Memory [SetManagedResource]: " + memory + "KB" + " | ");
                    Console.WriteLine("ManagedResource generation: " + GC.GetGeneration(resource.ManagedResource));

                    resource.SetUnmanagedResourceValue(out memory);
                    Console.Write("Total Memory [SetUnmanagedResource]: " + memory + "KB" + " | ");
                    Console.WriteLine("UnmanagedResource generation: " + GC.GetGeneration(resource.UnmanagedResource));

                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine($"\nGeneration 0 was scanned {GC.CollectionCount(0)} times");
            Console.WriteLine($"Generation 1 was scanned {GC.CollectionCount(1)} times");
            Console.WriteLine($"Generation 2 was scanned {GC.CollectionCount(2)} times");

            memory = GC.GetTotalMemory(false) / 1024;

            Console.WriteLine("\nTotal memory in end: " + memory + "KB");

        }
    }
}
