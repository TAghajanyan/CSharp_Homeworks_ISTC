using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdStage.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomCollection collection = new CustomCollection();

            collection.Add("Smok");
            collection.Add("Read");
            collection.Add("Drink");
            collection.Add("Write");
            collection.Add("Run");

            Console.WriteLine($"Prop Count: {collection.Count}");
            Console.WriteLine($"Prop IsFixedSize: {collection.IsFixedSize}");
            Console.WriteLine($"Prop IsReadOnly: {collection.IsReadOnly}");
            Console.WriteLine($"Prop IsSynchronized: {collection.IsSynchronized}");
            Console.WriteLine($"Prop SyncRoot: {collection.SyncRoot}\n");

            Console.WriteLine($"Method Contains(Read): {collection.Contains("Read")}");
            Console.WriteLine($"Method IndexOf(Drink): {collection.IndexOf("Drink")}\n");

            Console.WriteLine("Method Remove(Write)");
            collection.Remove("Write");
            Console.WriteLine($"Count: { collection.Count}\n");

            Console.WriteLine("Method RemoveAt(1) [Read]");
            collection.RemoveAt(1);
            Console.WriteLine($"Count: { collection.Count}\n");

            Console.WriteLine("Method CopyTo(array, 0)");
            Custom[] array = new Custom[100];
            collection.CopyTo(array, 0);

            foreach (Custom item in array)
            {
                if (item == null)
                    break;
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("\nMethod Insert(1, Walk)");
            collection.Insert(1, "Walk");

            foreach (Custom custom in collection)
            {
                Console.WriteLine(custom.Value);
            }

            Console.WriteLine("\nMethod Clear()");
            collection.Clear();


            #region MyForeach

            IEnumerable enumerable = collection as IEnumerable;

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Custom item = enumerator.Current as Custom;

                Console.WriteLine($"Value: {item.Value}");
            }

            collection.Reset();

            #endregion

        }
    }
}
