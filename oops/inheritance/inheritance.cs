

using System;
namespace InheritanceApplication
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // Derived class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setWidth(5);
            Rect.setHeight(7);

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}

class A
{
    public A(int a)
    {
        a++;
        Console.WriteLine("a: " + a);
    }
}
class B : A
{
    public B(int a, int b) : base(a)
    {
        Console.WriteLine("a:{0},b:{1}", a, b);
    }
}

class Program2
{
    static void Main2(string[] args)
    {
        B ob = new B(2, 3);
    }
}

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent Constructor.");
    }

    public void print()
    {
        Console.WriteLine("I'm a Parent Class.");
    }
}

public class ChildClass : ParentClass
{
    public ChildClass()
    {
        Console.WriteLine("Child Constructor.");
    }
}

class Program1
{
    static void Main1(string[] args)
    {
        ChildClass objChild = new ChildClass();

        //Child class don't have print() method but we inherited from "ParentClass" class
        objChild.print();

        Console.Read();
    }
}
// o/p-
// Parent Constructor.
// Child Constructor.
// I'm a Parent Class.