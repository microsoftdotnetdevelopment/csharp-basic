
//Ex-1:-
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protected_Internal
{
    class access
    {
        // String Variable declared as protected internal
        protected internal string name;
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
            // Accepting value in protected internal variable
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();
        }
    }
}