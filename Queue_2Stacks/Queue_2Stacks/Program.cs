using System;
using System.Collections.Generic;

namespace Queue_2Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            modQueue queue = new modQueue();
            queue.add(1);
            queue.print();
            queue.add(2);
            queue.print();
            queue.add(3);
            queue.print();
            queue.add(4);
            queue.print();
            queue.add(5);
            queue.print();


        }
    }

    class modQueue
    {
        Stack<int> main = new Stack<int>();
        Stack<int> secondary = new Stack<int>();

        public void add(int input)
        {
            while(main.Count > 0) {
                secondary.Push(main.Pop());
            }
            main.Push(input);

            while(secondary.Count > 0) {
                main.Push(secondary.Pop());
            }

        }

        public void print() { 
        
        foreach(int element in main)
            {
                Console.Write(element);

            }
            Console.WriteLine();
        }


    }

}



