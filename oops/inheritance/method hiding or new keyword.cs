

using System;
class Car
{
    public void drive()
    {
        Console.WriteLine("Base Class : Drive Method");
    }
}

class MyCar : Car
{
    public new void drive() // Using new keyword here
    {
        Console.WriteLine("Derived Class : Drive Method");
    }
}

class Program
{

    static void Main(string[] args)
    {
        Car o1 = new Car();
        o1.drive(); // Output - Base Class : Drive Method

        MyCar o2 = new MyCar();
        o2.drive(); // Output - Derived Class : Drive Method

        Console.ReadKey();
    }
}