using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            vowelTotal();
            inputInt();
            Console.ReadLine();
        }


        public static void vowelTotal()
        {
            Console.Write("Please Type a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            int total = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine($"Total number of vowels: {total}");
        }


        public static void inputInt()
        {
            Console.Write("Please Enter a positive integer: ");
            int number = Int32.Parse(Console.ReadLine());
            
            if(number < 0)
            {
                Console.WriteLine("This is a negative number!!!");
                inputInt();
            }
            else
            {
                if(number % 3 == 0)
                {
                    Console.WriteLine("This number is divisible by 3!!!");
                }
                else
                {
                    Console.WriteLine("This number is not divisible by 3.... :(");
                }
              
            }




        }
    }
}
