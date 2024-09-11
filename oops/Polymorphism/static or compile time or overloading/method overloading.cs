using System;

class BaseClass
{
    public virtual string YourCity()
    {
        return "Hyderabad";
    }
}

class DerivedClass : BaseClass
{
    public override string YourCity()
    {
        return "Delhi";
    }
}

class Program
{

    static void Main(string[] args)
    {
        DerivedClass obj = new DerivedClass();
        string city = obj.YourCity();
        Console.WriteLine(city);
        Console.Read();
    }
}
// o/p-
// Delhi


namespace PolymorphismApplication
{
    class Printdata
    {
        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
        static void Main1(string[] args)
        {
            Printdata p = new Printdata();

            // Call print to print integer
            p.print(5);

            // Call print to print float
            p.print(500.263);

            // Call print to print string
            p.print("Hello C++");
            Console.ReadKey();
        }
    }
}
// o/p-
// Printing int: 5
// Printing float: 500.263
// Printing string: Hello C++

