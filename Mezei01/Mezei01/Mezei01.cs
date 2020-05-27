/*Source: Class with Dr.Mezei
 * Summary: Creating objects, arrays, printing values our, structures of classes, 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC200_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            Console.WriteLine(arr);

            //Customer[] listOfCustomers;
            Customer cust = new Customer();
            Console.WriteLine(cust);

            cust.SetName("Bob");
            cust.PrintName();
            cust.age = 72;

            Console.WriteLine(cust);

            int[] myVals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArray(myVals);
            PrintArray2(myVals);
            PrintEverySecondValueInArray(myVals);

            DisplayNumTimes(44);

            PrintDivisors(12);
            PrintDivisors(132);
            PrintDivisors(2019);

            Console.WriteLine(ComputeSeries(2019));
            Console.WriteLine(ComputeSeries(20));


            int d = 7;
            int e = d;
            d = 8;
            Console.WriteLine(e);


            int x = 10;
            AddOne(x);
            //AddOneByRef(ref x);
            Console.WriteLine(x);

            int[] yy = { 11, 22, 33 };
            AddOne(yy);
            Console.WriteLine(yy[0]);

            int[] myvals = InputArray();
            foreach (int value in myvals)
            {
                Console.WriteLine(value);
            }

        }

        public static int[] InputArray()
        {
            //ask the user for the length of the array
            Console.Write("please enter the length: ");
            string str = Console.ReadLine();
            int length = Convert.ToInt32(str);

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("a[{0}] = ", i);
                string num = Console.ReadLine();
                arr[i] = Convert.ToInt32(num);
            }

            return arr;
        }

        public static void AddOne(int x)
        {
            x = x + 1;
        }

        public static void AddOne(int[] x)
        {
            x[0] = x[0] + 1;
        }

        public static void AddOneByRef(ref int x)
        {
            x = x + 1;
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void PrintArray2(int[] arr)
        {
            foreach (int val in arr)
                Console.Write(val + " ");
            Console.WriteLine();
        }

        public static void PrintEverySecondValueInArray(int[] arr)
        {
            for (int i = 1; i < arr.Length; i = i + 2)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void DisplayNumTimes(int num)
        {
            for (int i = 0; i < num; i++)
                Console.WriteLine("Hello World!");
        }

        public static void PrintDivisors(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                //check if i divides num ... if so, display it
                if (num % i == 0)//i.e. i divides num
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static int ComputeSeries(int num)
        {
            int total = 0;

            for (int i = 1; i <= num; i++)
            {
                total = total + i * i * i * i;
            }

            return total;
        }
    }

    class Customer
    {
        //data
        private string name;
        public int age;

        //methods
        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return String.Format("{0} is {1} years old, {2}", name, age, "Happy Holidays!");
        }
        //ctor
        public Customer()
        {
            name = "Unknown";
            age = -1;
        }

    }
}
/*Output:
System.Int32[]
Unknown is -1 years old, Happy Holidays!
Bob
Bob is 72 years old, Happy Holidays!
1 2 3 4 5 6 7 8 9 10
1 2 3 4 5 6 7 8 9 10
2 4 6 8 10
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
Hello World!
1 2 3 4 6 12
1 2 3 4 6 11 12 22 33 44 66 132
1 3 673 2019
1636266322
722666
7
10
12
please enter the length: 4
a[0] = 1
a[1] = 2
a[2] = 3
a[3] = 4
1
2
3
4
*/