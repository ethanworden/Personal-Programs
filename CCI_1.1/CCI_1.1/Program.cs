/*
Using book "Cracking the Coding Interview" Page 90 #1.1
*/

using System;

namespace CCI_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string test = Console.ReadLine();
            Console.WriteLine($"the string: {test} has all unique characters: {unique(test)}");
            Console.WriteLine($"using the answer code: {answer(test)}");
            
        }

        static bool unique(string arg) //My option off the top of my head. Big-O= O(n^2)
        {
            arg.ToCharArray();
            char temp;
            Console.WriteLine(arg.Length);
            for(int i=0; i < arg.Length; i++)
            {
                temp = arg[i];
                for(int j = i+1; j < arg.Length; j++)
                {
                    Console.WriteLine($"temp: {temp} arg[j]: {arg[j]}");
                    if (temp == arg[j])
                    {
                        return false;
                    }
                    j++;
                }
                i++;
            }
            return true;
            


        }

        static bool answer(string arg)
        {
            if (arg.Length > 128) return false;
            bool[] char_set = new bool[128];
            for(int i =0; i < arg.Length; i++)
            {
                int val = arg[i];
                if (char_set[val])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
