using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_CCI_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.AddFirst(1);
            ll.AddAfter(ll[1], 2);

        }


    }
}
