// SOURCE: taken from https://www.youtube.com/watch?v=4a_iTOtGhM8 
//     Part 23 - C# Tutorial - Polymorhpism in c#.avi
// Text version of the video at http://csharp-video-tutorials.blogspot.com/...
//     /2012/06/part-23-c-tutorial-polymorphism.html
// AUTHOR: kudvenkat
// SYNOPSIS: full blown polymorphism (virtual methods in base class; overriding
//     virtual methods in derived class; intentionally hiding virtual method
//     in base class; unintentionally hiding virtual method in base class;
//     inheriting base class method)

using System;

public class Program
{

    public static void Main()
    {
 
        Employee[] employees = new Employee[5];

        employees[0] = new FullTimeEmployee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new TemporaryEmployee();
        employees[3] = new InternEmployee();
        employees[4] = new Employee();

        //PrintFullName for everything in employees array
        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }
    }
}


public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    
    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " base default");
    }
}

//Each class below inherits the Employee class
public class FullTimeEmployee : Employee
{
    //prints Full Time instead of base default
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


}


/* Output:
FN LN Full Time
FN LN base default
FN LN base default
FN LN base default
FN LN base default
*/
