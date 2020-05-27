using System;

namespace MyArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList arrlist = new MyArrayList(10);
            arrlist.printAll();
            arrlist.isEmpty();
            arrlist.addFront(10);
            arrlist.Insert(1, 5);
            arrlist.Insert(2,15);
            arrlist.Insert(3, 20);
            arrlist.Sort();
            arrlist.printAll();
            arrlist.addFront(1);
            arrlist.addBack(30);
            arrlist.printAll();
            arrlist.contains(20);
            arrlist.Sort();
            arrlist.printAll();
            arrlist.Clear();

          
            Console.WriteLine( $"The size of 'arrlist' is: {arrlist.size()} elements");


        }
    }

    class MyArrayList
    {
        private int[] arr;
        private int maxSize;
        private int LastElementList;
        public MyArrayList(int size) //Constructor
        {
            arr = new int[size];
            maxSize = size;
        }

        public int size() //Method
        {
            return arr.Length;
        }

        public void addBack(int value) 
        {

            if (LastElementList == maxSize)
            {
                Console.WriteLine("Array is full. Cannot add to list... :(");
            }
            else
            {
                arr[LastElementList] = value;
                LastElementList++;
            }
        }

        public void printAll()
        {
            for(int i = 0; i< arr.Length; i++) 
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.WriteLine();
        }

        public void isEmpty()
        {
            int numEmpty = 0;
            for(int i =0; i<arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    numEmpty++;
                }
            }
            Console.WriteLine($"There are {numEmpty} empty cells");
        }

        public void isFull()
        {
            int numFull = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    numFull++;
                }
            }
            Console.WriteLine($"There are {numFull} full cells");

        }

        public void addFront(int val)
        {
            

            for(int i = arr.Length; i<0;i--)
            {
                if(arr[i] != 0) 
                { 
                arr[i+1] = arr[i];
                }
            }
            arr[0] = val;

        }

        public void Insert(int index, int val)
        {
            arr[index] = val;

        }

        public void deleteBack()
        {
            arr[LastElementList] = 0;
        }
        public void deleteFront()
        {
            arr[0] = 0;
        }

        public void deleteIndex(int index) 
        {
            arr[index] = 0;
        }

        public void contains(int val)
        {
            Console.Write($"Indexes with the value {val}: ");
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i] == val)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine();
        }


        public void Clear()
        {
            Array.Clear(arr, 0, arr.Length);
        }

        public void Sort()
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i =0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    break;
                }
                Array.Sort(arr, 0, i);
            }
        }
    }
}
