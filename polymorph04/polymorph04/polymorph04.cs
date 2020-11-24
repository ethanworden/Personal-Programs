// SOURCE: taken from https://www.youtube.com/watch?v=4a_iTOtGhM8 
//     Part 23 - C# Tutorial - Polymorhpism in c#.avi
// Text version of the video at http://csharp-video-tutorials.blogspot.com/...
//     /2012/06/part-23-c-tutorial-polymorphism.html
// AUTHOR: kudvenkat
// PUBDATE: Jun 9, 2012
// STUDENT: Dan Bahrt
// DOWNOLOAD: Mar 29, 2019
// SYNOPSIS: abstract class example (cannot create base class object)
//     everything else is full-blown polymorphic

using System;

//==========
public class Program
{

    //----------
    public static void Main()
    {
      
        Employee[] employees = new Employee[5];
        employees[0] = new FullTimeEmployee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new TemporaryEmployee();
        employees[3] = new InternEmployee();
        // employee class is now abstract...
        // so we cannot instantiate an object from it
        // it gives us a compile-time error
        // employees[4] = new Employee();

  
        foreach (Employee e in employees)
        {
            if (e == null)
            {
                continue;
            }
            e.PrintFullName();
        }
    }
}

//Employee class now abstract
public abstract class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

   
    public abstract void PrintFullName(); 
}


public class FullTimeEmployee : Employee
{

   
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " Full Time");
    }
}


public class PartTimeEmployee : Employee
{


    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " Part Time");
    }
}


public class TemporaryEmployee : Employee
{

    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " Temporary");
    }
}


public class InternEmployee : Employee
{


    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " Intern");
    }
}


/* SAMPLE OUTPUT:
FN LN Full Time
FN LN Part Time
FN LN Temporary
FN LN Intern
*/
