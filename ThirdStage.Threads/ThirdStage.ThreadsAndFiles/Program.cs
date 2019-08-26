using System.IO;
using System.Threading;

namespace ThirdStage.ThreadsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWriteWithThreads readWrite = new ReadWriteWithThreads
                ("File1.txt", "File2.txt", "File3.txt", "File1Context", "File2Context", "File3Context");
            readWrite.Threads();

        }
    }
}
