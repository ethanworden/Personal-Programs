/* SOURCE: taken from https://www.youtube.com/watch?v=4a_iTOtGhM8 
    Part 23 - C# Tutorial - Polymorhpism in c#.avi
    Text version of the video at http://csharp-video-tutorials.blogspot.com/...
    /2012/06/part-23-c-tutorial-polymorphism.html
    AUTHOR: kudvenkat
    About: simple inheritance; creating array that demonstrates
    simple polymorphism (treating derived class object as base class object)
*/
using System;


public class Program
{


    public static void Main()
    {
        // instantiate objects and shove reference pointers into 
        // array of base class objects.
        Employee[] employees = new Employee[5];
        employees[0] = new FullTimeEmployee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new TemporaryEmployee();
        employees[3] = new InternEmployee();
        employees[4] = new Employee();

        
        //PrintFullName for everything in the employees array
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

    //----------
    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " base default");
    }
}

//Each class below inherits and acts the same way as the Employee class
public class FullTimeEmployee : Employee
{
}


public class PartTimeEmployee : Employee
{
}


public class TemporaryEmployee : Employee
{
}


public class InternEmployee : Employee
{
}


/* Output:
FN LN base default
FN LN base default
FN LN base default
FN LN base default
FN LN base default
*/
