using System;

namespace EpicGame
{
     
    public class Program
    {
       
        public static Game newGame = new Game();
        public static void Main(string[] args)
        {
            newGame.Beginning();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
