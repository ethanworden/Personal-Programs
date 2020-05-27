using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine($"The output is: \n{replace(input)}");
            Console.ReadLine();
        }

        static string replace(string input)
        {
            string output = input.Trim();
            output = output.Replace(" ", "%20");
            return output;
        }

    }
}
