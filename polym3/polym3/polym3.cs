// source: https://www.tutorialspoint.com/csharp/csharp_polymorphism.htm
// summary: Uses Polymorphism to be able to distinguish between a triangle
//          and a rectangle, and calculate area accordingly

using System;

namespace PolymorphismApplication
{
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        //calculation for a general shape
        public virtual int area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }
    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7); //dimenstions for an instantiated rectangle
            Triangle t = new Triangle(10, 5);   //dimenstions for an instantiated triangle

            c.CallArea(r);
            c.CallArea(t);
            Console.ReadKey();
        }
    }
}
/*Outcome:
Rectangle class area :
Area: 70
Triangle class area :
Area: 25
*/