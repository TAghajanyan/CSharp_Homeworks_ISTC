using System.IO;
using System.Threading;

namespace ThirdStage.ThreadsAndFiles
{
    class ReadWriteWithThreads
    {
        FileStream file1;
        FileStream file2;
        FileStream file3;

        string path1, path2, path3;


        public ReadWriteWithThreads(string path1, string path2, string context1, string context2)
        {
            this.path1 = path1;
            this.path2 = path2;

            file1 = new FileStream(path1, FileMode.OpenOrCreate);
            file2 = new FileStream(path2, FileMode.OpenOrCreate);
            //try
            //{
                File.WriteAllText(path1, context1);
                File.WriteAllText(path2, context2);
            //}
            //catch { }
        }

        public ReadWriteWithThreads(string path1, string path2, string path3, string context1, string context2, string context3) : this(path1, path2, context1, context2)
        {
            this.path3 = path3;

            file3 = new FileStream(path3, FileMode.OpenOrCreate);
            //try
            //{
                File.WriteAllText(path3, context3);
            //}
            //catch { }
        }

        private void ReadFiles(object path)
        {
            try
            {
                lock (new object())
                {
                    StreamReader reader = new StreamReader((string)path);
                    System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

                    //Thread.CurrentThread.Join();
                    System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    WriteFile(reader.ReadToEnd());
                }

            }
            catch { }
        }

        private void WriteFile(string context)
        {
            System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            File.AppendAllText(path3, context);
            //Thread.CurrentThread.Join();
            System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        public void Threads()
        {
            Thread thread1 = new Thread(ReadFiles);
            thread1.Start(path1);

            Thread thread2 = new Thread(ReadFiles);
            thread2.Start(path2);
            thread2.Join();
        }

    }
}
