using System;
using System.IO;

namespace ThirdStage.FileTree
{
    class Program
    {
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

            FileTree fileTree = new FileTree();

            Console.WriteLine(path);
            fileTree.PrintFolders(directory);

            Console.WriteLine("Files count: {0}\nFolders count: {1}", fileTree.FileCount, fileTree.FolderCount);
            Console.ReadKey();
        }
    }
}
