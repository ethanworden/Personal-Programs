using System;
using System.Diagnostics;

namespace BubbleSort
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            Stopwatch creating = new Stopwatch();
            Stopwatch sorting = new Stopwatch();

            Console.Write("please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();

            creating.Start();
            int[] array = new int[num];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
             //   Console.WriteLine(array[i]);
            }
            creating.Stop();

            sorting.Start();
            BubbleSort(array);
            sorting.Stop();

            Console.WriteLine($"Creating time: {creating.Elapsed}");
            Console.WriteLine($"Sorting time: {sorting.Elapsed}");
        }
        static void BubbleSort(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])    
                    {                           
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                       // PrintArray(arr);
                    }
                }
            }
        

            Console.WriteLine("Done sorting");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            for(int i = 0;i< arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine();

        }
    }
}