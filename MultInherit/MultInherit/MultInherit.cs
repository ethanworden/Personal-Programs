/*Source:https://www.sanfoundry.com/csharp-program-multilevel-inheritance/
 *Summary:Demonstrates Multilevel Inheritance with vehicles
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Inherit
{
    class inheri : vehicle //vehicles in general
    {
        public void Noise()
        {
            Console.WriteLine("All Vehicles Creates Noise !! ");
        }
        static void Main(string[] args)
        {
            inheri obj = new inheri();
            obj.mode();
            obj.feature();
            obj.Noise();
            Console.Read();
        }
    }
    class Mode //Mode in general
    {
        public void mode()
        {
            Console.WriteLine("There are Many Modes of Transport !!");
        }
    }
    class vehicle : Mode //when vehicle inherits Mode
    {
        public void feature()
        {
            Console.WriteLine("They Mainly Help in Travelling !!");
        }
    }
}
/*Outcome:
There are Many Modes of Transport !!
They Mainly Help in Travelling !!
All Vehicles Creates Noise !!
*/