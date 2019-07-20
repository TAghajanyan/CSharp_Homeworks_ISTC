using System;

namespace SecnodStage.Interface
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Music is playing.");
            Console.ResetColor();
        }
        public void Pouse()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Music is poused.");
            Console.ResetColor();
        }
        public void Stop()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Music is stoped.");
            Console.ResetColor();
        }
        public void Record()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Music is recording.");
            Console.ResetColor();
        }
        void IRecodable.Pouse()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Record is poused.");
            Console.ResetColor();
        }
        void IRecodable.Stop()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Record is stoped.");
            Console.ResetColor();
        }
    }
}
