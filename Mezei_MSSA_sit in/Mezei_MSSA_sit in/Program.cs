using System;
using System.Threading.Tasks;
namespace Mezei_MSSA_sit_in
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            //arr.add   is not a thing...
            Node someNode = new Node(7);    //this is an instance
            Node anotherNode = new Node(11);
            anotherNode.Next = someNode;    //dot notation to get to property
            anotherNode.Method();           //dot notation to get to method

            linkedList mylist = new linkedList();
            mylist.Print();
            try
            {
                mylist.DeleteFirst();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            mylist.AddFirst(1);
            try
            {
                mylist.DeleteLast();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            mylist.AddFirst(2);
            mylist.AddFirst(3);
            mylist.Print();

            mylist.Append(10);
            mylist.Append(20);
            mylist.Append(30);
            mylist.Print();
            

            mylist.Insert(100,20);
            mylist.Print();

        }
        
        class linkedList
        {
            //data the only needed piece of info is the Head
            Node head;

            ////behavior
            //AddFirst     
            public void AddFirst(int val)
            {
                //create node
                Node newNode = new Node(val);

                //new node points to what head pointed to
                newNode.Next = head;

                //change head
                head = newNode;

            }


            //AddLast / Append
            public void Append(int val) //same as AddLast
            {
                AddLast(val);
            }
            public void AddLast(int val)
            {
                //create new node
                Node newNode = new Node(val);
                Node reference = head;

                if(head == null)    //this part is needed, see while loop a few lines below
                {
                    AddFirst(val);
                    return;         //does not continue the rest of the method
                }

                //traverse the linked list to get to the last node
                while(reference.Next != null)   //will crash if list is empty. head= null. null.Next which would crash
                {
                    reference = reference.Next;
                }
                //reference points to the last node
                //now link in the new node
                reference.Next = newNode;
            }
            //DeleteFirst
            public void DeleteFirst()
            {
                if (head == null){
                    throw new Exception("You can't DeleteFirst(); from an empty list");
                }
                head = head.Next;
            }


            //DeleteLast
            public void DeleteLast()
            {
                if (head.Next == null)
                {
                    head = null;
                }
                else
                if (head == null || head.Next == null)
                {
                    throw new Exception("You can't DeleteLast(); from an empty list");
                }else 
                {
                    Node reference = head;
                    while (reference.Next.Next != null)
                    {
                        reference = reference.Next;
                    }
                    reference.Next = null;
                }
            }
            //Insert
            public void Insert(int val, int index)
            {
                Node newNode = new Node(val);
                Node reference = head;

                //if list is null and position == 0
                if((index ==0) && (head == null))
                {
                    AddFirst(val);
                    return;
                }



                for(int pos = 0; pos<index-1; pos++  )
                {
                    if (reference == null)
                    {
                        Console.WriteLine("Error: reached end of list");
                        return;
                    }
                    reference = reference.Next;
                }
                newNode.Next = reference.Next;
                reference.Next = newNode;


            }
            //Delete
            public void Delete(int index)
            {
                if (index < 0)
                {
                    return;
                }
                if (index == 0)
                {
                    DeleteFirst();
                }
                else
                {
                    Node reference = head;
                    for (int pos = 0; pos < index; pos++)
                    {
                        if (reference == null)
                        {
                            Console.WriteLine("error");
                            return;
                        }
                        reference = reference.Next;
                    }
                    if (reference != null && reference.Next != null)
                    {
                        reference.Next = reference.Next.Next;
                    }

                }
            }

            //Print / traverse
            public void Print()
            {
                if(head == null)
                {
                    Console.WriteLine("The list is empty");
                }
                else
                {
                    Node finger = head;
                    while(finger != null)
                    {
                        Console.Write(finger.Value + " ");
                        finger = finger.Next; //move finger to the right
                        
                    }
                    Console.WriteLine();
                }

            }               

            //constructor
            public linkedList()
            {
                //head = null; default for C#


            }
        }

        class Node
        {
            //to store
            public int Value { get; set; }
            public Node Next { get; set; } 

            //constructor
            public Node(int someVal)
            {
                Value = someVal;
                //Next = null;  would be the default value. Do not need 
            }

            public void Method(){/*empty method*/}
        }
    
    }

}
