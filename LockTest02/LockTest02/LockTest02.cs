/*Source:Ethan Worden
 * Summary: Once a thread finishes, it will lock part of the code so that only
 * that specific thread can execute it.
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
        static readonly object lockThis = new object();


        static void Main()
        {

            Thread t1 = new Thread(Go);
            t1.Start("Child Thread 1");
            Thread t2 = new Thread(Go);
            t2.Start("Child Thread 2");


            Console.Read();
        }


        static void Go(object id)
        {
            lock (lockThis) // This is the critical section. 
                            // Notice that now only one Thread will be able
                            // to enter the region and set the done flag.
            {
                if (!done) { Console.WriteLine("Done Set By: " + id); done = true; }
                else { Console.WriteLine(id + " has finished"); };
            }
        }

    }
}
/*Outcome:
Done Set By: Child Thread 1
Child Thread 2 has finished
*/

