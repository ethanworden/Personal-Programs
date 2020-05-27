/*Source:https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions#code-try-2
 * Summary: Shows the formatting of Lambda expressions
 */
using System;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x; //lambda expression format
            Console.WriteLine(square(5));
            
        }
    }
}
/*Output:
25
*/