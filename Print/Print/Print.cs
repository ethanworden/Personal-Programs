/*
 * C# Program to Print Hello World Without using WriteLine
 */
using System;
class Program
{
    static void Main(string[] args)
    {
        //Another way of typing out Console.WriteLine("HelloWorld"); 
        if (System.Console.OpenStandardOutput().BeginWrite(new byte[] { 072, 101,
            108, 108, 111, 032, 087, 111, 114, 108, 100, 0 }, 0,
            12, null, null).AsyncWaitHandle.WaitOne())
        {
        }
        if (System.Console.ReadKey().Modifiers == 0)
        {
        }
    }
}
/*Output:
 Hello World
*/