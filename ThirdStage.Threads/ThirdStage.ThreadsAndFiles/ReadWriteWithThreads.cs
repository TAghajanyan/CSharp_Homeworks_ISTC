using System.IO;
using System.Text;
using System.Threading;

namespace ThirdStage.ThreadsAndFiles
{
    class ReadWriteWithThreads
    {
        string path1;
        string path2;
        string path3;


        public ReadWriteWithThreads(string path1, string path2, string context1, string context2)
        {
            this.path1 = path1;
            this.path2 = path2;

            FileStream file1 = new FileStream(path1, FileMode.OpenOrCreate);
            FileStream file2 = new FileStream(path2, FileMode.OpenOrCreate);

            byte[] buffer1 = GetBuffer(context1 + "\n");
            byte[] buffer2 = GetBuffer(context2 + "\n");
            file1.Write(buffer1, 0, buffer1.Length);
            file2.Write(buffer2, 0, buffer2.Length);

            file1.Close();
            file2.Close();
        }

        public ReadWriteWithThreads(string path1, string path2, string path3, string context1, string context2, string context3) : this(path1, path2, context1, context2)
        {
            this.path3 = path3;

            FileStream file3 = new FileStream(path3, FileMode.OpenOrCreate);

            byte[] buffer3 = GetBuffer(context3 + "\n");
            file3.Write(buffer3, 0, buffer3.Length);

            file3.Close();
        }

        private void ReadFiles(object path)
        {
            StreamReader reader;
            lock (this)
            {
                reader = new StreamReader((string)path);
                System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }

            if (Thread.CurrentThread.ManagedThreadId == 3)
            {
                Thread.Sleep(1);
            }

            lock (this)
            {
                System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                WriteFile(reader.ReadToEnd());
                reader.Close();
            }
        }

        private void WriteFile(string context)
        {
            System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            File.AppendAllText(path3, context);
            System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        private byte[] GetBuffer(string context)
        {
            return Encoding.UTF7.GetBytes(context);
        }

        public void Threads()
        {
            Thread thread1 = new Thread(ReadFiles);
            thread1.Start(path1);

            Thread thread2 = new Thread(ReadFiles);
            thread2.Start(path2);
            //thread2.Join();
        }

    }
}
