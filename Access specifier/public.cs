
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public_Access_Specifiers
{
    class access
    {
        // String Variable declared as public
        public string name;
        // Public method
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
            // Accepting value in public variable that is outside the class
            ac.name = Console.ReadLine();
            ac.print();

            Console.ReadLine();
        }
    }

    class Modifiers
    {
        static void AAA()          //private
        {
            Console.WriteLine("Modifiers AAA");
        }

        public static void BBB()
        {
            Console.WriteLine("Modifiers BBB");

        }
    }

    class Program1
    {
        public static void AccessModifiers()
        {
            Modifiers.BBB();
        }
    }

    class Modifiers1
    {
        static void AAA()          //private
        {
            Console.WriteLine("Modifiers AAA");
        }

        public static void BBB()
        {
            Console.WriteLine("Modifiers BBB");
            AAA();
        }
    }

    class Program2
    {
        public static void Main1()
        {
            Modifiers.BBB();
        }
    }

    class Program3
    {
        public static void AllModifiers()
        {
            B B1 = new B();
            B1.show();
        }
    }
    class A
    {
        private int x;
        protected int y;
        internal int z;
        public int p;
        protected internal int q;
    }
    class B : A
    {

        public void show()

        {

            //x=10;

            y = 20;

            z = 30;

            p = 40;

            q = 50;

            // Console.WriteLine(+x);          // Error x is not accessible

            Console.WriteLine(y);

            Console.WriteLine(z);

            Console.WriteLine(p);

            Console.WriteLine(q);

            Console.ReadLine();



        }

    }
}



