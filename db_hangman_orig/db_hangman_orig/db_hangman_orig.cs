/* SOURCE: https://www.sanfoundry.com/csharp-programs-gaming-hangman/
     AUTHOR: Manish Bhojasia, a technology veteran with 20+ years @ Cisco &
     Wipro, [along with consultancies at IBM, Brocade, Quantum, etc.]
     is Founder and CTO at Sanfoundry. He is Linux Kernel Developer and
     SAN Architect and is passionate about competency development....
     He lives in Bangalore ....
This is a basic hangman game
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hangman!!!!!!!!!!");

            //creates an array with all of the possible words that can be guessed
            string[] listwords = new string[10];
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";

            Random randGen = new Random();
            //picks random word
            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];

            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");

            //places * for the number of characters of the word
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';

            //retrieves users guess, and shows the letter if guess is correct
            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
            }
        }
    }
}
/*
 * Output:
 Welcome to Hangman!!!!!!!!!!
Please enter your guess: a
**a***
e
**a**e
i
**a**e
o
o*a**e
u
o*a**e
r
ora**e
n
oran*e
g
orange
*/