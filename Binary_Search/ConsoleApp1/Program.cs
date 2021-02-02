/* Program uses binary search to guess a number that you think of.
 * You input the max number of guesses that the program has.
 * The program will then give you a range of numbers to pick from (it is users job to stay within the range...)
 * Enter "yes", "higher", or "lower" for the program to continue.
 */

using System;
using System.Collections.Generic;
using System.IO;


class Solution
{
    static int guessed = 0;

    static double[] binarysearch(double[] arr)
    {
        guessed++;
        Console.Write($"Is the number {arr[arr.Length / 2-1]}, higher, or lower: ");
        string resp = Console.ReadLine();

        if (resp == "yes")
        {
            Console.WriteLine($"Hurray!! Guessed the number in {guessed} guesses");
            return arr;
        }
        else if (resp == "higher")
        {


            double[] adjust = new double[arr.Length / 2];
            for (int i = 0; i < arr.Length / 2; i++)
            {
                adjust[i] = arr[arr.Length / 2 + i];
            }
            return binarysearch(adjust);


        }
        else if (resp == "lower")
        {
            double[] adjust = new double[arr.Length / 2];
            for (int i = 0; i < arr.Length / 2; i++)
            {
                adjust[i] = arr[i];
            }

            return binarysearch(adjust);


        }
        else
        {
            Console.WriteLine($"Error... unknown response..");
            guessed--;
            return binarysearch(arr);
        }
    }
    
    static void Main(String[] args)
    {
        Console.Write("Enter a number of guesses the bot gets: ");
        double power = Convert.ToInt64(Console.ReadLine());
        double highest = Math.Pow(2, power);

        Console.WriteLine($"Think of a number between 1 and {highest-1}......");

        
        List<double> range = new List<double>();



        for(double i = 1; i <= highest; i++)
        {
            range.Add(i);
        }

        double[] arr = range.ToArray();


        binarysearch(arr);




        

    }
}
