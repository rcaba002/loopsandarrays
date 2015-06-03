using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int actualNumber = rand.Next(1, 10);

            Console.Write("What number am I thinking of? ");

            for (int i = 2; i >= 0; i--)
            {
                string guessString = Console.ReadLine();
                int guess;
#if DEBUG
                Console.WriteLine("DEBUG: 1 == {0}", i);
#endif

                bool result = int.TryParse(guessString, out guess);
                if (!result)
                {
                    Console.Write("That was not a number. Try again. ");
                    i++;
                    continue;
                }

                if (guess == actualNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                    break;
                }

                if (i == 0)
                {
                    Console.Write("You lose. The number is " + actualNumber + ".");
                }
                else Console.Write("No! You've got {0} guesses left. ", i);
            }

            Console.ReadLine();
        }
    }
}
