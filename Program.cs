using System;

namespace EpicGame
{
     
    public class Program
    {
       
      
        public static void Main(string[] args)
        {
            Game newGame = new Game(); 
            newGame.Beginning();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
