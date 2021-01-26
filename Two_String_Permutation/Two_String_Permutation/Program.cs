/* This program allows a user to input two strings and it will determine if one string is a permutation of the other*/

using System;

namespace Two_String_Permutation
{
    class Program
    {
        static bool permutation(string a, string b)
        {
            char[] word1= a.ToCharArray();
            char[] word2 = b.ToCharArray();

            if(word1.Length != word2.Length)
            {
                Console.WriteLine("Not permutation, not same length..");
                return false;
            }

            Array.Sort(word1);
            Array.Sort(word2);

            for(int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != word2[i])
                {
                    Console.WriteLine("different characters were inputted. not a permutation..");
                    return false;
                }
            }

            Console.WriteLine("These two strings are permutations.");
            return true;
               


        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first string: ");
            string first = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string second = Console.ReadLine();
            Console.WriteLine(permutation(first, second));
        }
    }
}
