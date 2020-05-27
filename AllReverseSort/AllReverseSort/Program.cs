using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AllReverseSort
{
    class Program
    {
        public class Global
        {
            public static int counter;
        }


        static void Main(string[] args)
        {

            string[] arr = System.IO.File.ReadAllLines("input.txt");
            int size= arr.Length;
              //Console.WriteLine("\n\n     Unsorted------------"); 
            // foreach (string i in arr) { Console.WriteLine(i); }
            

            
            string[] arr1 = new string[size];
            string[] arr2 = new string[size];
            string[] arr3 = new string[size];
            Array.Copy(arr, arr1, size);
            Array.Copy(arr, arr2, size);
            Array.Copy(arr, arr3, size);


            Stopwatch s = new Stopwatch(); // start the stopwatch


            Console.WriteLine("\n\n     Built-In Sort------------");
            s.Start();
            Array.Sort(arr1);
            Array.Reverse(arr1);
            s.Stop();   //stop the Stopwatch and print the elapsed time
            Console.WriteLine("     It took {0} to sort {1} numbers\n\n", s.Elapsed, size);
        //     for (int i = 0; i < size; i++) { Console.WriteLine("     " + arr1[i]); }          //prints out the sorted file




            Console.WriteLine("\n\n     Selection Reverse Sort-----");
            selectionReverseSort(arr2);
        //    for (int i = 0; i < size; i++) { Console.WriteLine("     " + arr2[i]); }         //prints out sorted file





            Console.WriteLine("\n\n     Merge Reverse Sort------------");
            mergeReverseSortMain(arr3, 0, size - 1);
        //     for (int i = 0; i < size; i++) { Console.WriteLine("     " + arr3[i]); }             //prints out the sorted file
        }





        static void selectionReverseSort(string[] arr)
        {
            string min;
            int min_index;
            string temp;
            int size = arr.Length;
            long count = 0;

            Stopwatch s = new Stopwatch(); // start the stopwatch
            s.Start();

            for (int i = 0; i < size; i++)
            {
                min = arr[i];
                min_index = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[j].CompareTo(min) > 0) { min = arr[j]; min_index = j; }
                }
                // the smallest element smaller than the current head of the list (if there is one)
                // is swapped with the current head of list.
                if (min_index != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min_index];
                    arr[min_index] = temp;
                    count++;
                }

            }
            s.Stop();   //stop the Stopwatch and print the elapsed time

            Console.WriteLine("     It took {0} to sort {1} words, and did {2} comparisons\n\n", s.Elapsed, size, count);          
        }

        static void mergeReverseSortMain(string[] arr, int l, int r)
        {
            int size = arr.Length;
            Global.counter = 0;
            Stopwatch x = new Stopwatch(); // start the stopwatch
            x.Start();
            mergeReverseSort(arr, l, r);
            x.Stop();
              Console.WriteLine("     It took {0} seconds to sort {1} words, and did {2} comparisons \n\n", x.Elapsed, size, Global.counter);
        }


        static void mergeReverseSort(string[] arr, int l, int r)
        {
            if (l < r)
            {
                int midpoint = (l + r) / 2;  //keep in mind this is integer division
                mergeReverseSort(arr, l, midpoint);
                mergeReverseSort(arr, midpoint + 1, r);
                merge(arr, l, midpoint, r);
            }
            Global.counter++;
        }





        static void merge(string[] A, int l, int midpoint, int r)
        // Merges two subarrays of A[]. 
        // First subarray is A[l..m] 
        // Second subarray is A[m+1..r] 
        {
            int i, j, k;
            int n1 = midpoint - l + 1;
            int n2 = r - midpoint;

            /* create temp arrays */
            string[] L = new string[n1];
            string[] R = new string[n2];

            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
            {
                L[i] = A[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = A[midpoint + 1 + j];
            }

            /* Merge the temp arrays back into arr[l..r]*/
            i = 0; // Initial index of first subarray 
            j = 0; // Initial index of second subarray 
            k = l; // Initial index of merged subarray 
            while (i < n1 & j < n2)
            {
                if (L[i].CompareTo(R[j]) >= 0)
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy the remaining elements of L[], if there 
               are any */
            while (i < n1)
            {
                A[k] = L[i];
                i++;
                k++;
            }

        }
    }
}