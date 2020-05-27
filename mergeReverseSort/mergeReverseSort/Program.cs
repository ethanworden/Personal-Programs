using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace mergeReverseSort
{
    class Sort
    {

        static void Main(string[] args)
        {
           

            string[] arr = System.IO.File.ReadAllLines("input.txt");
            int size = arr.Length;
            /*  Console.WriteLine("\n\n     Unsorted------------"); 
             foreach (string i in arr)
              {
                  Console.WriteLine(i);
              }
            */

            Console.WriteLine("\n\n     Built-In Sort------------");
            //The built-in "arr.Sort" sorts "in-place", 
            //i.e. it destroys the original unsorted arr.
            //We need to make a temporary copy of the original.
            string[] temp = new string[size];
            Array.Copy(arr, temp, size);
            Stopwatch s = new Stopwatch(); // start the stopwatch
            s.Start();
            Array.Sort(temp);
            Array.Reverse(temp);
            s.Stop();   //stop the Stopwatch and print the elapsed time
            Console.WriteLine("     It took {0} to sort {1} numbers\n\n", s.Elapsed, size);
           // for (int i = 0; i < size; i++) { Console.WriteLine("     " + temp[i]); }          //prints out the sorted file

            Console.WriteLine("\n\n     MergeReversesort------------");
            s.Start();
            mergeReverseSort(arr, 0, size - 1);
            s.Stop();   //stop the Stopwatch and print the elapsed time
            Console.WriteLine("     It took mergeReverseSort {0} to sort {1} numbers\n\n", s.Elapsed, size);
            //for (int i = 0; i < size; i++) { Console.WriteLine("     " + arr[i]); }             //prints out the sorted file

            Console.ReadKey();

        }




        static void mergeReverseSort(string[] A, int l, int r)
        {
            if (l < r)
            {
                int midpoint = (l + r) / 2;  //keep in mind this is integer division
                mergeReverseSort(A, l, midpoint);
                mergeReverseSort(A, midpoint + 1, r);
                merge(A, l, midpoint, r);
            }

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

