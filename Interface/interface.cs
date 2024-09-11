using System;

interface Iexample
{
    int Add(int a, int b);
    int Mul(int a, int b);
}

class Test : Iexample
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Mul(int a, int b)
    {
        return a * b;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Test obj = new Test();
        Iexample iadd = (Iexample)obj;

        int add = iadd.Add(2, 2);

        int mul = iadd.Mul(2, 8);

        Console.WriteLine(" Addition : {0} ",add);
        Console.WriteLine(" Multiplication : {1} ", add, mul);
        Console.ReadLine();

    }
}


class Program1
{
    interface Icsharp
    {
        void Start();
    }

    class First : Icsharp
    {
        public virtual void Start()
        {
            Console.WriteLine("It is Base class");
        }
    }
    class Second : First
    {
        public override void Start()
        {
            Console.WriteLine("It is from class second");
        }
    }

    static void Main1()
    {
        Second member = new Second();
        member.Start();

        ((First)member).Start();
        ((Icsharp)member).Start();
    }
}
// o/p-
// It is from class second
// It is from class second
// It is from class second

class TestClass: ITestInterface
{
    static void Main()
    {
       TestClass tc = new TestClass ();
        tc.TestMethod ();
    }

    public void TestMethod ()
    {
        Console.WriteLine("TestMethod () called.");
    }
}

class Program2
{
    static void Main2(string[] args)
    {
        Car swift = new Car();

        string result = swift.GetModelNumber(2012);

        Console.WriteLine(result);
        Console.Read();
    }
}

interface Ivehicle
{
    string GetModelNumber(int year);
}

public class Car : Ivehicle
{
    public string GetModelNumber(int year)
    {
        return "Manufacturing  year = " + year;
    }
}
// o/p-
// Manufacturing  year = 2012