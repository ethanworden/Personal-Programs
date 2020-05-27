using System;
using System.IO;
using System.Collections;

namespace Reverse_file_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "input.txt";
            string output = "output.txt";

            reverse(input,output);
        }

        static void reverse(string input, string output)
        {

            Stack stack = new Stack();
            if (!File.Exists(input))
            {
                Console.WriteLine("File does not exist...");
            }
            else
            {
                string[] lines = File.ReadAllLines(input);

                foreach(string s in lines)
                {
                    Console.WriteLine(s);
                    stack.Push(s);
                 
                }


                string[] returnArray = new string[lines.Length];

                Console.WriteLine("\n       reversing the order of the file....\n\n");
                for(int i = 0; i< returnArray.Length;i++)
                {
                    string lineReturn = Convert.ToString(stack.Peek());
                    returnArray[i] = lineReturn;
                    Console.WriteLine(returnArray[i]);
                    stack.Pop();
                }

                Console.WriteLine($"\n      Writing reverse order to {output}\n");

                File.WriteAllLines(output, returnArray);






            }


        }

    }
}
