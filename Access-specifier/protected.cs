
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protected_Specifier
{
    class access
    {
        // String Variable declared as protected
        protected string name;
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
            // raise error because of its protection level
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();
        }
    }
}


namespace Protected_Specifier2
{
    class access
    {
        // String Variable declared as protected
        protected string name;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }

    class Program : access // Inherit access class
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Enter your name:\t");
            p.name = Console.ReadLine(); // No Error!!
            p.print();
            Console.ReadLine();
        }
    }
}