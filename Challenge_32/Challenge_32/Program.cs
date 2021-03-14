using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Guess the Number.");
            Console.Write("Pick a difficulty level (1, 2, or 3): ");
            int.TryParse(Console.ReadLine(), out int diff1);
            MainGame game = new MainGame();
            game.difficulty = diff1;
            game.ChooseDifficulty();

            Console.ReadLine();
        }
    }
}
