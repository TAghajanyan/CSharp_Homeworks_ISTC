using System;
using System.IO;

namespace ThirdStage.FileTree
{
    class Program
    {
        static int folderCount = 0;
        static int fileCount = 0;

        static void PrintFolders(DirectoryInfo directory, int pos = 0)
        {
            if (directory.FullName == string.Empty)
                return;

            PrintFiles(directory.FullName, pos + 3);

            pos += 3;

            if (directory.GetDirectories().Length != 0)
            {
                for (int i = 0; i < directory.GetDirectories().Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', pos) + directory.GetDirectories()[i].Name);
                    folderCount++;
                    Console.ForegroundColor = ConsoleColor.Gray;

                    try
                    {
                        PrintFolders(directory.GetDirectories()[i], pos);
                    }
                    catch (PathTooLongException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(e.Message);
                    }catch(UnauthorizedAccessException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        static void PrintFiles(string filePath, int pos)
        {
            DirectoryInfo directory = new DirectoryInfo(filePath);

            if (directory.GetFiles() == null)
                return;

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (FileInfo item in directory.GetFiles())
            {
                Console.WriteLine(new string(' ', pos) + item.Name);
                fileCount++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main(string[] args)
        {
            string path = @"C:\";
            DirectoryInfo directory = new DirectoryInfo(path);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green -> Folder");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red -> File");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(path);
            PrintFolders(directory);

            Console.WriteLine("Files count: {0}\nFolders count: {1}", fileCount, folderCount);
            Console.ReadKey();
        }
    }
}
