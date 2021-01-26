/*This program allows a user to input a string and it will determine if all the characters are unique or not */

using System;

namespace ConsoleApp2
{
    class Program
    {
        static bool isUnique(string s)
        {
            char[] arr = s.ToCharArray();

            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        Console.WriteLine($"Not all characters are unique!!! Repition with character: {arr[i]}");
                        return false;
                    }
                }
            }
            Console.WriteLine("All characters are unique.");
            return true;

        }
        static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            string response = Console.ReadLine();
            isUnique(response);
            
        }
    }
}
