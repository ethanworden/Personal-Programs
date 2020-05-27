using System;
using System.Collections;

namespace MyLinkedList
{
    class MyLinkedList
    {
        private ListNode Head; //Pointer to the beginning of the list

        public class ListNode
        {
            public int data;
            public ListNode next;

            //Constructor
            public ListNode(int value)
            {
                data = value;
                next = null;
            }
        }

        public MyLinkedList(int element) //Constructor
        {
            Head = new ListNode(element);
        }

        //Method to return length of the list
        public int Length()
        {
            ListNode Ptr;
            int size = 1;
            Ptr = Head.next;
            while (Ptr != null)
            {
                Ptr = Ptr.next;
                size = size + 1;
            }
            Console.WriteLine("Length of list: " + size);
            return size;
        }

        public void Append(int value)
        //Traverse the list until you come to the end and then 
        //create a new list node
        {
            ListNode Ptr;
            Ptr = Head;
            while (Ptr.next != null)
            {
                Ptr = Ptr.next;
            }
            Ptr.next = new ListNode(value);
        }

        //Print all elements of the list
        public void PrintAll()
        {
            ListNode Ptr;
            Ptr = Head;
            Console.Write("Elements: ");
            while (Ptr != null)
            {
                Console.Write(Ptr.data + ", ");
                Ptr = Ptr.next;
            }
            Console.WriteLine();
        }

        public void Reverse()
        {
            Stack s = new Stack();
            ListNode Node;
            Node = Head;
            //Traverse the list and put all nodes but the 
            //last one on the stack.
            while (Node.next != null)
            {
                s.Push(Node);
                Node = Node.next;
            }
            //Last Node of the list is now the 
            //head of the reversed list.
            Head = Node;
            //Popping the nodes off the stack gives the
            //the reverse order in which they were pushed on.
            while (s.Count > 0)
            {
                Node.next = (ListNode)s.Pop();
                Node = Node.next;
            }
            //The former first node is now the 
            //last -> next filed=NULL
            Node.next = null;
        }
    }


    class Program
    {
        static void Main()
        {
            MyLinkedList mylist = new MyLinkedList(0);
            mylist.Append(1);
            mylist.Append(2);
            mylist.Append(3);
            mylist.Append(4);
            mylist.Append(5);
            mylist.Length();
            mylist.PrintAll();
            mylist.Reverse();
            mylist.PrintAll();
            Console.ReadKey();
        }
    }
}
