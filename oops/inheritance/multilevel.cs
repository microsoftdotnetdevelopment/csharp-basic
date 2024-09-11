using System;
class A
{
    public A()
    {
        Console.WriteLine("i am a");
    }
    ~A()
    {
        Console.WriteLine("destrucor of a");
    } }
    class B : A
    {
        public B()
        {
            Console.WriteLine("I m b");
        }
        ~B()
        {
            Console.WriteLine("des b");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("i m c");
        }
        ~C()
        {
            Console.WriteLine("des c");
        }
    }
    class D : C
    {
        public D()
        {
            Console.WriteLine("i m d");
        }
        ~D()
        {
            Console.WriteLine("des d");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            D ob = new D();

        }
    }