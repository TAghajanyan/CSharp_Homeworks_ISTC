using System.Threading;

namespace ThirdStage.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            Thread thread = new Thread(myClass.Method);
            thread.Start();
            //thread.Join();
            Thread.Sleep(50);

            myClass.Print();
        }
    }
}
