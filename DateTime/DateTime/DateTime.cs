/*Source:
 * Summary: Prints a date and time in different formats
 */
using System;
public class Example1
{
    public static void Main()
    {
        DateTime dt1 = new DateTime(2019, 12, 9, 12, 00, 36);
        Console.WriteLine("Complete date: " + dt1.ToString());

        // Get date-only portion of date, without its time.
        DateTime dateOnly = dt1.Date;

        Console.WriteLine("Short Date: " + dateOnly.ToString("d"));

        Console.WriteLine("Display date using 24-hour clock format:");

        Console.WriteLine(dateOnly.ToString("g"));
        Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
    }
}