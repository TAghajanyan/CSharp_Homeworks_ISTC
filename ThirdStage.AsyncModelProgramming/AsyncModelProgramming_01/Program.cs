using System;
using System.IO;
using System.Text;

namespace AsyncModelProgramming_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream stream = new FileStream("File.txt", FileMode.OpenOrCreate, FileAccess.Read);

            byte[] array = new byte[stream.Length];

            IAsyncResult asyncResult = stream.BeginRead(array, 0, array.Length, null, null);

            Console.WriteLine("Reading file . . . ");

            stream.EndRead(asyncResult);

            foreach (char item in ASCIIEncoding.UTF8.GetChars(array))
                Console.Write(item);

            stream.Close();

            Console.ReadKey();
        }
    }
}
