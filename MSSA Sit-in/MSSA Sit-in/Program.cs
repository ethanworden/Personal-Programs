using System;

namespace MSSA_Sit_in
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 10, 5, 22, 7, 30, 3, 1, 8, -2};
            // bubble_sort(input);
            selection_sort(input);
            printArray(input);

        }

        static void bubble_sort(int[] arr) //O(n^2) analysis
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])    //two adjacent numbers our of sequence
                    {                           //Swap them
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
            }
        }   

        static void selection_sort(int[] arr)
        {
            for (int j = 0; j < arr.Length-1; j++)
            {

                int hand = j; //stores position of smallest value
                for (int i = j+1; i < arr.Length; i++) //traverse array, O(n)
                {
                    if (arr[i] < arr[hand])
                    {
                        hand = i;
                    }
                }
                int temp = arr[hand];
                arr[hand] = arr[j];
                arr[j] = temp;
            }

        }



        static void printArray(int[] arr)
        {
            foreach(int value in arr)
            {
                Console.Write(" " + value);
            }
        }

    }
}
