//In CSC340/CSC515 we will be primarily dealing with algorithms manipulating complex 
//data structures. In order to implement and test our algorithms we need to be able 
//to generate test cases. The following C# program provides a quick introduction 
//into generating random integers, random floating point numbers, or random strings. 
//These in turn can later be used to generate complex tree or graph structures.




using System;
using System.Text;

class RandomNumberSample
{
    static void Main(string[] args)
    {
        int min = 1;
        int max = 1000;
        int lngth = 25;

        RandomGenerator generator = new RandomGenerator();
        int rand = generator.RandomNumber(1, 500);
        Console.WriteLine($"Random number between {min} and {max} is " + rand);

        string str = generator.RandomString(lngth, true);
        Console.WriteLine($"Random string of {lngth} chars is {str}");

        Console.ReadKey();
    }
}



public class RandomGenerator
{
    // Generate a random number between two numbers    
    public int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    // Generate a random string with a given size    
    public string RandomString(int size, bool lowerCase)
    {
        StringBuilder builder = new StringBuilder();
        Random random = new Random();
        char ch;

        for (int i = 0; i < size; i++)
        {
            //Upper case letters are numercially in ASCII between 65 (A) and 90 (Z)
            //random.NextDouble() generates a real number greater or equal to 0.0 but smaller than 1.0
            //Math.Floor rounds down, i.e. Math.Floor(0.9) => 0 and Math.Floor(25.999) => 25

            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            builder.Append(ch);
        }
        if (lowerCase)
            return builder.ToString().ToLower();
        return builder.ToString();
    }
}

 