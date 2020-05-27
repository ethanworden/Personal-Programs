// SOURCE: taken from https://www.youtube.com/watch?v=4a_iTOtGhM8 
//     Part 23 - C# Tutorial - Polymorhpism in c#.avi
// Text version of the video at http://csharp-video-tutorials.blogspot.com/...
//     /2012/06/part-23-c-tutorial-polymorphism.html
// AUTHOR: kudvenkat
// SYNOPSIS: simple object instantiation; no inheritance; no polymorphism

using System;


public class Program
{

    public static void Main()
    {
        //creates Employee object
        Employee E = new Employee();
        E.PrintFullName(10, "name");

    }
}

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

 
    public void PrintFullName(int dummy1, string dummy2)
    {
        //with an int and string parameter, print FN and LN
        Console.WriteLine(FirstName + " " + LastName);
    }
}


/* Output:
FN LN
*/
