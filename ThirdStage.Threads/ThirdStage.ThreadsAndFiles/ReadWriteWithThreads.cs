using System;
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

            byte[] buffer1 = GetBuffer(context1);
            byte[] buffer2 = GetBuffer(context2);

            using (FileStream file1 = new FileStream(path1, FileMode.OpenOrCreate))
            {
                using (FileStream file2 = new FileStream(path2, FileMode.OpenOrCreate))
                {
                    file1.Write(buffer1, 0, buffer1.Length);
                    file2.Write(buffer2, 0, buffer2.Length);

                    file1.Close();
                    file2.Close();
                }
            }
        }

        public ReadWriteWithThreads(string path1, string path2, string path3, string context1, string context2, string context3) : this(path1, path2, context1, context2)
        {
            this.path3 = path3;

            byte[] buffer3 = GetBuffer("561651658");
            using (FileStream file3 = new FileStream(path3, FileMode.OpenOrCreate))
            {
                file3.Write(buffer3, 0, buffer3.Length);
                file3.Close();
            }
        }

        private void ReadFiles(object path)
        {
            using (StreamReader reader = new StreamReader((string)path))
            {
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
        }

        private void WriteFile(string context)
        {
            System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            File.AppendAllText(path3, context);
            System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        private byte[] GetBuffer(string context)
        {
            return Encoding.UTF8.GetBytes(context + Environment.NewLine);
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
