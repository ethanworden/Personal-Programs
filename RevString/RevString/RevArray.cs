/*Source:https://www.sanfoundry.com/csharp-programs-reverse-string-predefined-function/
 *Summary: User sets array size, array elements, and program reverses the users input order
 */
using System;
class linSearch
{
    public static void Main()
    {
        Console.WriteLine("Enter Number of Elements you Want to Hold in the Array? ");
        //retrieve users input and conver into an int, and make an array
        string s = Console.ReadLine();
        int x = Int32.Parse(s);
        int[] a = new int[x];

        //Place values in each element of array with user's input
        Console.WriteLine("\n Enter Array Elements : ");
        for (int i = 0; i < x; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = Int32.Parse(s1);
        }
        
        //reverses the array and prints it out
        Array.Reverse(a);
        Console.WriteLine("Reversed Array : ");
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("Element {0} is {1}", i + 1, a[i]);
        }
        Console.Read();
    }
}
/*Outcome:
Enter Number of Elements you Want to Hold in the Array?
5

 Enter Array Elements :
21
45
96
123
65
Reversed Array :
Element 1 is 65
Element 2 is 123
Element 3 is 96
Element 4 is 45
Element 5 is 21
*/