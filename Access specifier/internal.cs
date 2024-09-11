
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Internal_Access_Specifier
{
    class access
    {
        // String Variable declared as internal
        internal string name;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:\t");
            // Accepting value in internal variable
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();

            ExecuteRectangle ac1 = new ExecuteRectangle();
            ac1.RectangleApplication();
        }
    }

    class Rectangle
    {
        //member variables
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle
    {


        public void RectangleApplication()
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}


