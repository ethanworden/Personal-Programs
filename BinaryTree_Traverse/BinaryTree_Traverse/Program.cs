using System;

namespace BinaryTree_Traverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            Console.WriteLine($"Is this Tree Empty? {myTree.IsEmpty()}\n");

            myTree.Insert("F");
            myTree.Insert("B");
            myTree.Insert("G");
            myTree.Insert("A");
            myTree.Insert("D");
         //   myTree.Insert("");
            myTree.Insert("I");
           // myTree.Insert("");
           // myTree.Insert("");
            myTree.Insert("C");
            myTree.Insert("E");
            myTree.Insert("H");

            Console.WriteLine($"Is this Tree Empty? {myTree.IsEmpty()}\n");
            myTree.PrintPreOrder(); //Print Pre Orders
            myTree.PrintInOrder();
            myTree.PrintPostOrder();



        }


    }

    class Node
    {
        public string letter; //data
        public Node left, right;
        public Node(string str) //O(1)
        {
            letter = str; //stores letter into str

        }
    }

    class Tree
    {
        Node root;
        public Boolean IsEmpty()
        {
            return root == null;
        }

        public void Insert(string letter)
        {
            Node newNode = new Node(letter);
            Insert(newNode);
        }


        public void Insert(Node newNode)
        { 
            if (IsEmpty()) //checks to see if the tree is empty O(1)
            {
                root = newNode;
            }
            else
            {
                Node finger = root; //finger is set to root
                while (true)
                {
                    if (newNode.letter.CompareTo(finger.letter) < 1) 
                    {
                        if (finger.left != null) //if there is a left child
                        {
                            finger = finger.left; //it will move left 
                        }
                        else
                        {
                            finger.left = newNode; //link the new node to the left
                            return;
                        }
                    }
                    else
                    {
                        if (finger.right != null) //if there is a right child
                        {
                            finger = finger.right; //it will move right
                        }
                        else
                        {
                            finger.right = newNode; //link node to the right
                            return;
                        }
                    }
                }
            }
        }


        public void PrintPreOrder() //O(1)
        {
            Console.WriteLine("PREORDER Printed: ");
            PrintPreOrderHelper(root); //calls the printpreorderhelper 
            Console.WriteLine();
        }
        public void PrintPreOrderHelper(Node finger) //O(n)
        {
            if (finger != null) //if finger is present
            {
                Console.WriteLine(finger.letter);//prints info
                PrintPreOrderHelper(finger.left); //left
                PrintPreOrderHelper(finger.right);//right
            }
        }

        public void PrintInOrder() //O(1)
        {
            Console.WriteLine("INORDER Printed: ");
            PrintInOrderHelper(root); //calls upon InOrderHelper
            Console.WriteLine();
        }
        public void PrintInOrderHelper(Node finger) //O(n)
        {
            if (finger != null) //if finger is present
            {
                PrintInOrderHelper(finger.left); //left
                Console.WriteLine(finger.letter); //prints info
                PrintInOrderHelper(finger.right);//right
            }
        }

        public void PrintPostOrder() //O(1)
        {
            Console.WriteLine("POSTORDER Printed: ");
            PrintPostOrderHelper(root); //calls PostOrderHelper
            Console.WriteLine();
        }
        public void PrintPostOrderHelper(Node finger) //O(n)
        {
            if (finger != null) //if finger is present
            {
                PrintPostOrderHelper(finger.left); //left
                PrintPostOrderHelper(finger.right); //right
                Console.WriteLine(finger.letter); //prints info
            }
        }


    }



}
