/*Source:https://www.sanfoundry.com/csharp-program-check-given-number-even-odd/
 *Summary:Checks whether the Entered Number is Even or Odd
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace check1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            //if number divided by 2 has no remainder
            if (i % 2 == 0) 
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
/*Output:
Enter a Number : 10
Entered Number is an Even Number
 */
