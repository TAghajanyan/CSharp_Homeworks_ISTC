using System.IO;
using System.Threading;

namespace ThirdStage.ThreadsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.WriteAllText("File1.txt", "fdsfbsdafbdsfn");
            //File.WriteAllText("File2.txt", "fdsfbsdafbdsfn");

            ReadWriteWithThreads readWrite = new ReadWriteWithThreads("File1.txt", "File2.txt", "File3.txt", "File1Context", "File2Context", "File3Context");
            readWrite.Threads();
            Thread.Sleep(2000);
        }
    }
}
