/*
    From "Cracking the Coding Interview" Page 90, #1.2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first string: ");
            string one= Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please enter the second string: ");
            string two = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{two} is a permutation of {one}: {premutate(one,two)}");
            Console.ReadLine();
        }


        static bool premutate(string one, string two)
        {
            char[] test1 = one.ToArray();
            char[] test2 = two.ToArray();
            Array.Sort(test1);
            Array.Sort(test2);


            Console.WriteLine(test1);
            Console.WriteLine(test2);

            if (test1.Length != test2.Length)
            {
                return false;
            }

            for(int i = 0; i < test1.Length; i++)
            {
                if (test1[i] != test2[i])
                {
                    return false;
                }
            }

            return true;



        }
    }
}




