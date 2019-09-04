using System;
using System.Collections.Generic;

namespace ThirdStage.Linq
{

    class MyClass
    {
        public int Filed1 { get; set; }
        public int Filed2 { get; set; }
        public int Filed3 { get; set; }
    }

    static class MyLinq
    {
        public static IEnumerable<object> Select<TTtpe>(this IEnumerable<TTtpe> source, Func<TTtpe, object> func)
        {
            foreach (TTtpe item in source)
            {
                yield return func.Invoke(item);
            }
        }

        public static IEnumerable<TType> Where<TType>(this IEnumerable<TType> source, Func<TType, bool> func)
        {
            foreach (TType item in source)
            {
                if (func.Invoke(item))
                    yield return item;
            }
        }

        public static object FirstOrDefault<TType>(this IEnumerable<TType> source)
        {
            IEnumerator<TType> enumerator = source.GetEnumerator();

            if (enumerator.MoveNext())
                return enumerator.Current;
            else
                return default(TType);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<MyClass> myClasses = new List<MyClass>
            {
                new MyClass{Filed1 = 1, Filed2 = 2, Filed3 = 3,},
                new MyClass{Filed1 = 4, Filed2 = 5, Filed3 = 6,},
                new MyClass{Filed1 = 7, Filed2 = 8, Filed3 = 9,}
            };

            var myCollection = myClasses.Where(x => x.Filed1 % 2 != 0 || x.Filed2 % 2 != 0).Select(x => x.Filed3);

            int i = 0;
            foreach (var item in myCollection)
            {
                Console.WriteLine($"Item{++i}: {item}" );
            }

            var firstOrDefault = myCollection.FirstOrDefault();
            Console.WriteLine("FirstOrDefault: " + firstOrDefault);
        }
    }
}
