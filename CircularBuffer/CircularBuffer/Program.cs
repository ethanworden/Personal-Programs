// C# Circular Buffer. Example of a circular buffer. In this example
// nothing is written into (or read from) the buffer. 
// It merely illustrates how to index the buffer in a circular 
// fashion.

using System;
using System.Text;

namespace CircularBuffer
{
    class Cbuffer
    {
        static int[] buffer = new int[6];
        static int buffer_size = 6;
        static int buffer_index=0;
        static int count;
        static void Main()
        {
            
            do
            {
                // Print the index just to see if the program works
                Console.Write("  " + buffer_index);
                // once you are at the end of the buffer you need to get back to the
                // beginning; hence the name circular buffer;



                buffer_index =  (buffer_index+1)% buffer_size;


                count++;

            } while (count < (3 * buffer_size));
            //go three times around the circular buffer

            Console.ReadKey();
        }
    }
}
