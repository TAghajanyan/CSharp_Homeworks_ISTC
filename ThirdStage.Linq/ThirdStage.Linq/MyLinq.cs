using System;
using System.Collections.Generic;

namespace ThirdStage.Linq
{
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
}
