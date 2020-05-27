/* Source: Ethan Worden
 * 12/5/19
 * Summary: This code will generate numbers,
 * print out the numbers,
 * sort the numbers from lowest to highest,
 * print the sorted numbers,
 * and finally display how long the computer took to 
 * process the program.
 */


using System;
using System.Diagnostics;

namespace NumberSorting
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();                
            stopWatch.Start();                               
            double[] numberArray = new double[10];
            Generate(numberArray);                              
            Sort(numberArray);                                  
            stopWatch.Stop();
            TimeDisplay(stopWatch.Elapsed);
        }


        //Formats the time and displays it
        static void TimeDisplay(TimeSpan ts)                
        {
            
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("Time to complete: " + elapsedTime);
        }


        //Generates number of doubles in an array and displays them.
        static void Generate(double[] arr)
        {
            Random rnd = new Random();
            Console.WriteLine("Generating random numbers...");
            for (int i = 0; i < arr.Length; i++)                
            {
                arr[i] = rnd.NextDouble();
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Random numbers generated.");
        }


        //Sorts the array and displays the array
        static void Sort(double[] arr)
        {
            Console.WriteLine("Sorting numbers...");
            Array.Sort(arr);                                
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);  

            }
        }

    }
}


/*
Part of the output:
Generating random numbers...
0.5147677583223058
0.30690784114734637
0.5808829598039775
0.664314274054167
0.8945732530646833
0.8431697193734207
0.2462304887577102
0.24537151877087146
0.6258196558923552
0.4036883331852445
Random numbers generated.
Sorting numbers...
0.24537151877087146
0.2462304887577102
0.30690784114734637
0.4036883331852445
0.5147677583223058
0.5808829598039775
0.6258196558923552
0.664314274054167
0.8431697193734207
0.8945732530646833
Time to complete: 00:00:00.04
*/
