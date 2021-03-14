using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_32
{
    class MainGame
    {
        public int difficulty { get; set; }
        public int valueOfMax { get; set; }
        public int valueOfMin { get; set; }
        public void ChooseDifficulty()
        {
            Random rand = new Random();
            if (difficulty == 1)
            {
                valueOfMax = 10;
                Game(rand.Next(1, valueOfMax));
            }

            else if (difficulty == 2)
            {
                valueOfMax = 100;
                Game(rand.Next(1, valueOfMax));
            }
            else if (difficulty == 3)
            {
                valueOfMax = 1000;
                Game(rand.Next(1, valueOfMax));
            }
        }

        private void Game(int v)
        {
            Console.Write("I have my number. What's your guess? ");
            int number = int.Parse(Console.ReadLine());
            int guess = 1;
            Findingnum(number, v, guess);
            Console.WriteLine("number was: " + v);
        }

        private void Findingnum(int number, int v, int guess)
        {
            
            if(number.Equals(v))
            {
                Console.WriteLine("You got it in " + guess + " guesses!\n");
                ResultOfAnswer(guess);
            }
            else if(number > v)
            {
                guess++;
                valueOfMax = number;

                Console.WriteLine(valueOfMin + " - " + valueOfMax);
                Console.Write("Too high. Guess again: ");
                int n1 = int.Parse(Console.ReadLine());
                n1 = Alert.CheckNumber(valueOfMin, n1, valueOfMax);
                Findingnum(n1, v, guess);
            }
            else if(number < v)
            {
                guess++;
                valueOfMin = number;
                
                Console.WriteLine(valueOfMin + " - " + valueOfMax);
                Console.Write("Too low. Guess again: ");
                int n1 = int.Parse(Console.ReadLine());
                n1 = Alert.CheckNumber(valueOfMin, n1, valueOfMax);
                Findingnum(n1, v, guess);
            }
        }

        private void ResultOfAnswer(int guess)
        {
            if(guess.Equals(1))
                Console.WriteLine(guess + " guess. You’re a mind reader!”");
            else if(guess >= 2 && guess <= 4)
                Console.WriteLine(guess + " guess. Most impressive.");
            else if(guess >= 3 && guess <= 6)
                Console.WriteLine(guess + " guess. You can do better than that.");
            else
                Console.WriteLine(guess + " guess. Better luck next time");

            Console.Write("Play Again? ");
            ConsoleKeyInfo key = Console.ReadKey();
            PlayAgainOrNot(key);
        }

        private void PlayAgainOrNot(ConsoleKeyInfo key)
        {
            switch(key.Key)
            {
                case ConsoleKey.Y:
                    {
                        Console.WriteLine("\nLet's play Guess the Number.");
                        Console.Write("Pick a difficulty level (1, 2, or 3): ");
                        int.TryParse(Console.ReadLine(), out int diff1);
                        MainGame game = new MainGame();
                        game.difficulty = diff1;
                        game.ChooseDifficulty();
                        break;
                    }
                default:
                    Console.WriteLine("\nGoodbye");
                    break;
            }
        }
    }
}
