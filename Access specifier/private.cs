
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Private_Access_Specifiers
{
    class access
    {
        // String Variable declared as private
        private string name;
        public void print() // public method
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            access ac = new access();
            // Console.Write("Enter your name:\t");
            // raise error because of its protection level
            // ac.name = Console.ReadLine();
            // ac.print();
            // Console.ReadLine();

            ExecuteRectangle vdf = new ExecuteRectangle();
            vdf.RectangleApplication();
        }
    }

    class Rectangle
    {
        //member variables
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
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
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
