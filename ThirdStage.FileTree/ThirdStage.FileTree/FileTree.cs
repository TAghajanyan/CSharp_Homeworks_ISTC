using System;
using System.IO;

namespace ThirdStage.FileTree
{
    class FileTree
    {
        public int FolderCount { get; private set; }
        public int FileCount { get; private set; }

        public void PrintFolders(DirectoryInfo directory, int pos = 0)
        {
            if (directory.FullName == string.Empty)
                return;

            PrintFiles(directory.FullName, pos + 3);

            pos += 3;

            for (int i = 0; i < directory.GetDirectories().Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(new string(' ', pos) + directory.GetDirectories()[i].Name);
                FolderCount++;
                Console.ForegroundColor = ConsoleColor.Gray;

                try
                {
                    PrintFolders(directory.GetDirectories()[i], pos);
                }
                catch (Exception e) when(e is PathTooLongException || e is UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void PrintFiles(string filePath, int pos)
        {
            DirectoryInfo directory = new DirectoryInfo(filePath);

            if (directory.GetFiles().Length == 0)
                return;

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (FileInfo item in directory.GetFiles())
            {
                Console.WriteLine(new string(' ', pos) + item.Name);
                FileCount++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
