using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //string secretWord = "";
            //Console.Write("Type a word: ");
            //ConsoleKeyInfo key;

            //do
            //{
            //    key = Console.ReadKey(true);

            //    if (key.Key != ConsoleKey.Backspace)
            //    {
            //        secretWord += key.KeyChar;
            //        Console.Write("*");
            //    }
            //    else Console.Write("\b");
            //} while (key.Key != ConsoleKey.Enter);

            //Console.WriteLine();
            //Console.WriteLine("The word has " + (secretWord.Length - 1) + " letters.");

            //for (int eachLetter = 0; eachLetter <= secretWord.Length - 1; eachLetter++)
            //{
            //    Console.Write("Pick a letter: ");
            //    char userLetter = Convert.ToChar(Console.ReadLine());
                
            //    if (userLetter == secretWord[eachLetter])
            //        Console.WriteLine("correct");
            //}
            ////        {
            ////            Console.WriteLine("Correct!");
            ////            correctTries++;
            ////        }
            ////        else
            ////        {
            ////            Console.WriteLine("Incorrect");
            ////            Console.WriteLine(guesses + " guesses left");
            ////            incorrectTries++;
            ////        }
            ////}

            ////Console.WriteLine("You lose!");

            int[] values = { 5, 14, 29, 49, 99, 150, 999 };

            for (int key = 0; key < values.Length; ++key)
                if (search <= values[key] && !stop)
                {
                    // set key to a variable
                }






            
            Console.ReadLine();
        }
    }
}
