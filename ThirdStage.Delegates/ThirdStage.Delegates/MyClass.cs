using System.Collections;

namespace ThirdStage.Delegates
{
    class MyClass : IMethods
    {
        public string Method1()
        {
            return "MyClass.Method1()";
        }

        public IEnumerable Method2(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                yield return $"MyClass.Method2({numbers[i]})";
            }
        }

        public string Method3(int number)
        {
            return $"MyClass.Method3({number})";
        }
    }
}
