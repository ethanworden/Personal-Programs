/*Source:Ethan Worden
 * Summary: Uses locks to allow a "producer" add and a "consumer" to take away without
 * producers or consumers being out of order within themselves
 */

using System;
using System.Threading;

class ProducerConsumer
{

    static int buffer_size = 6;        // size of buffer
    static int[] buffer = new int[6];  //buffer holds 6 cells 0-5
    static Random rand = new Random();
    static int counter = 0;
    static readonly object lockCounter = new object();


    static void Main()
    {
        Thread Pro = new Thread(Producer);
        Thread Con = new Thread(Consumer);
        Pro.Start();
        Con.Start();
    }


    static void Producer()
    {
        int i = 0;
        int randTime;
        int nextProduced = 1;
        do
        {

            while (counter == buffer_size) { }
            buffer[i] = nextProduced++;
            Console.WriteLine("Producer entered: " + (nextProduced - 1) + "  in cell:" + i);
            i = (i + 1) % buffer_size;
            randTime = rand.Next(0, 40);
            Thread.Sleep(randTime);
            lock (lockCounter)
            {
                counter = counter + 1; // one buffer entry has been produced (added)
            }
        } while (nextProduced <= 100);
    }


    static void Consumer()
    {
        int o = 0;
        int randTime;
        int nextConsumed;
        do
        {
            while (counter == 0) { }
            nextConsumed = buffer[o];
            Console.WriteLine("                        Consumer consumed: " + nextConsumed + " from cell: " + o);
            o = (o + 1) % buffer_size;
            randTime = rand.Next(0, 43);
            Thread.Sleep(randTime);
            lock (lockCounter)
            {
                counter = counter - 1; // one buffer entry has been consumed  
            }
        } while (true);
    }
}
/*Outcome:
Producer entered: 1  in cell:0
Producer entered: 2  in cell:1
                        Consumer consumed: 1 from cell: 0
                        Consumer consumed: 2 from cell: 1
Producer entered: 3  in cell:2
Producer entered: 4  in cell:3
                        Consumer consumed: 3 from cell: 2
Producer entered: 5  in cell:4
Producer entered: 6  in cell:5
                        Consumer consumed: 4 from cell: 3
Producer entered: 7  in cell:0
Producer entered: 8  in cell:1
                        Consumer consumed: 5 from cell: 4
Producer entered: 9  in cell:2
                        Consumer consumed: 6 from cell: 5
Producer entered: 10  in cell:3
                        Consumer consumed: 7 from cell: 0
Producer entered: 11  in cell:4
                        Consumer consumed: 8 from cell: 1
Producer entered: 12  in cell:5
Producer entered: 13  in cell:0
                        Consumer consumed: 9 from cell: 2
Producer entered: 14  in cell:1
                        Consumer consumed: 10 from cell: 3
Producer entered: 15  in cell:2
*/
