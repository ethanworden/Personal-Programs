/*Source:https://www.w3resource.com/csharp-exercises/file-handling/csharp-file-handling-exercise-4.php
 * Summary: Creates a file and writes into it
 */
using System;
using System.IO;
using System.Text;

class filexercise2
{
    public static void Main()
    {
        string fileName = @"mytest.txt";

        try
        {
            // Delete the file if it exists.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write("\n\n Create a file with content in the disk :\n");
            Console.Write("---------------------------------------------\n");
            // Create the file.
            using (StreamWriter fileStr = File.CreateText(fileName))
            {
                fileStr.WriteLine(" Hello and Welcome");
                fileStr.WriteLine(" It is the first content");
                fileStr.WriteLine(" of the text file mytest.txt");
                Console.WriteLine(" A file created with content name mytest.txt\n\n");
            }
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}
/*Outcome:
 A file created with content name mytest.txt
 */