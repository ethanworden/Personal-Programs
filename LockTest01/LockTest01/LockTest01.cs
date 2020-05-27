
/*Source:Ethan Worden
 * Summary: Shows output of a program without a lock
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LockTest
{
    class ThreadTest
    {
        static bool done;    // Static fields are shared between all threads

        static void Main()
        {

            Thread t1 = new Thread(Go);
            t1.Start("Child Thread 1");
            Thread t2 = new Thread(Go);
            t2.Start("Child Thread 2");

            Console.WriteLine("Main program is done");
            Console.Read();
        }


        static void Go(object id)
        {
            if (!done) { Console.WriteLine("Done Set By: " + id); done = true; }
            else { Console.WriteLine(id + " has finished"); };

        }

    }
}
/*Outcome:
Done Set By: Child Thread 2
Main program is done
Done Set By: Child Thread 1
*/
