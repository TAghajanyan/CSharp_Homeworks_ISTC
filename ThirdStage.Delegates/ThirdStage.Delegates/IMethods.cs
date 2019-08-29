using System.Collections;

namespace ThirdStage.Delegates
{
    interface IMethods
    {
        string Method1();
        IEnumerable Method2(params int[] numbers);
        string Method3(int number);
    }
}
