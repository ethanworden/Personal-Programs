/*Source: Dr. Mezei
 * Summary: Overview of classes, Objects, arrays, methods
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC200_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.SetName("Alex");
            st1.SetGPA(2.4);
            st1.PrintStudent();

            //Console.WriteLine(st1.GetID());
            Student st2 = new Student();
            st2.PrintStudent();

            Student st3 = new Student();
            st3.PrintStudent();

            Student st4 = new Student();
            st4.PrintStudent();

            Student st5 = new Student("Bob", "bob@stmartin.edu", 4.0);
            st5.PrintStudent();

            ISinger st6 = new Student("Charlie", "charlie@stmartin.edu", 2.0);
            st6.Sing();

            ISinger t1 = new Teacher("David");
            t1.Sing();



            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(50);
            numbers.Add(3);
            numbers.Add(40);
            numbers.Add(200);
            numbers.Add(1000);
            numbers.Sort();
            foreach (var value in numbers)
                Console.WriteLine(value);


            List<Student> csc200class = new List<Student>();
            csc200class.Add(st1);
            csc200class.Add(st2);
            csc200class.Add(st3);
            csc200class.Add(st4);
            csc200class.Add(st5);
            //csc200class.Add((Student)st6);
            csc200class.Sort();
            foreach (var value in csc200class)
                value.PrintStudent();
        }

        public static void SomeMethod(ISinger singer)
        {
            singer.Sing();
        }
    }

    class Student : ISinger, IComparable
    {
        //data
        private string name;
        string email;
        int id;
        double gpa;
        public static int count;

        //methods
        public void Sing()
        {
            Console.WriteLine("{0} is singing ...", name);
        }
        public int GetID()
        {
            return id;
        }
        public void SetGPA(double val)
        {
            if (val > 0)
                gpa = val;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public void PrintStudent()
        {
            Console.WriteLine("Prining a student ...");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Email: {0}", email);
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("GPA: {0}", gpa);
            Console.WriteLine("======================");
        }

        public int CompareTo(object obj)
        {
            Student st2 = (Student)obj;
            Student st1 = this;

            return (st1.name).CompareTo(st2.name);
        }

        //ctors
        public Student()
        {
            name = "undeclared";
            email = "undecided@stmartin.edu";
            gpa = 0;

            count = count + 100;
            id = count;
        }

        public Student(string name2, string email, double gpa)
        {
            name = name2;
            this.email = email;
            this.gpa = gpa;

            count = count + 100;
            id = count;
        }
    }

    class Teacher : ISinger
    {
        string name;

        public Teacher(string name)
        {
            this.name = name;
        }

        public void Sing()
        {
            Console.WriteLine("Dr. {0} is singing", name);
        }
    }

    interface ISinger
    {
        void Sing();
    }
}
/*Outcome:
Prining a student ...
Name: Alex
Email: undecided@stmartin.edu
ID: 100
GPA: 2.4
======================
Prining a student ...
Name: undeclared
Email: undecided@stmartin.edu
ID: 200
GPA: 0
======================
Prining a student ...
Name: undeclared
Email: undecided@stmartin.edu
ID: 300
GPA: 0
======================
Prining a student ...
Name: undeclared
Email: undecided@stmartin.edu
ID: 400
GPA: 0
======================
Prining a student ...
Name: Bob
Email: bob@stmartin.edu
ID: 500
GPA: 4
======================
Charlie is singing ...
Dr. David is singing
3
40
50
100
200
1000
Prining a student ...
Name: Alex
Email: undecided@stmartin.edu
ID: 100
GPA: 2.4
======================
Prining a student ...
Name: Bob
Email: bob@stmartin.edu
ID: 500
GPA: 4
======================
Prining a student ...
Name: undeclared
Email: undecided@stmartin.edu
ID: 200
GPA: 0
======================
Prining a student ...
Name: undeclared
Email: undecided@stmartin.edu
ID: 300
GPA: 0
======================
Prining a student ...
Name: undeclared
Email: undecided@stmartin.edu
ID: 400
GPA: 0
======================
*/
