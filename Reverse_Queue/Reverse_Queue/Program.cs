using System;
using System.Collections.Generic;

namespace Reverse_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> input = new Queue<int>();
            input.Enqueue(1);
            input.Enqueue(2);
            input.Enqueue(3);
            input.Enqueue(4);
            input.Enqueue(5);
            input.Enqueue(6);
            printQueue(input);
            reverseQueue(input);
            printQueue(input);

        }

        static void printQueue(Queue<int> input)
        {
            foreach (int element in input)
            {
                Console.Write(element);
                
            }
            Console.WriteLine();

        }

        static void reverseQueue(Queue<int> input)
        {
            int qlength = input.Count;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < qlength; i++)
            {
              //  Console.WriteLine(input.Count);
                stack.Push(input.Dequeue());
                //printQueue(input);
            }


            int slength = stack.Count;

            for(int i=0;i<slength; i++)
            {
                input.Enqueue(stack.Peek());
                stack.Pop();
            }
        }
    }
}
