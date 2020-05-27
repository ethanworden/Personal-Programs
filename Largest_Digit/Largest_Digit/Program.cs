using System;

class Program
{

    public static void Main(String[] args)
    {
        Console.Write("Please enter a number: ");
        int n = Int32.Parse(Console.ReadLine());
        Digits(n);
    }


    static void Digits(int n)
    {
        int largest = 0;

        while (n != 0)
        {
            int r = n % 10;
            largest = Math.Max(r, largest);
            n = n / 10;
        }
        Console.WriteLine($"The largest digit is: {largest}");
    }
}