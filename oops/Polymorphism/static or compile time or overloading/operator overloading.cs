
using System;
namespace binary_overload
{
    class complexNumber
    {
        int x;
        double y;
        public complexNumber(int real, double imagnary)
        {
            x = real;
            y = imagnary;
        }
        // public complexNumber(){}
        //   public static complexNumber operator + (complexNumber c1, complexNumber c2)
        //     {
        //         complexNumber c = new complexNumber();
        //         c.x=c1.x+c2.x;
        //         c.y=c1.x-c2.y;
        //         return c;
        //     }
        public void show()
        {
            Console.Write(x);
            Console.Write("+j" + y);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            complexNumber p, q, r;
            p = new complexNumber(10, 2.0);
            q = new complexNumber(20, 15.5);
            // r = p + q;
            Console.Write("p=");
            p.show();
            Console.Write("q=");
            q.show();
            Console.Write("r=");
            // r.show();
            Console.ReadLine();
        }
    }
}

namespace OperatorOvlApplication
{
    class Box
    {
        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

    }

    class Tester
    {
        static void Main1(string[] args)
        {
            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            Box Box3 = new Box();   // Declare Box3 of type Box
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // box 2 specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            Box3 = Box1 + Box2;

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();
        }
    }
}

class calc
{
    public int a;
    public calc(int num)
    {
        this.a = num;
    }

    public static calc operator +(calc c1, calc c2)
    {
        calc c3 = new calc(0);
        c3.a = c1.a + c2.a;
        return c3;
    }
}
class th
{
    static void Main2(string[] args)
    {
        calc ob1 = new calc(2);
        calc ob2 = new calc(3);
        calc ob3 = ob1 + ob2;
        Console.WriteLine(ob3.a);
    }
}

public class ComplexNum
{
    public int real;
    public int imaginary;
    public ComplexNum(int real, int imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }
    // Syntax of Operator Overloading 
    public static ComplexNum operator +(ComplexNum n1, ComplexNum n2)
    {
        return new ComplexNum(n1.real + n2.real, n1.imaginary + n2.imaginary);
    }
    // Override the ToString method to display an complex number in the suitable format:
    public override string ToString()
    {
        return (String.Format("{0} + {1}i", real, imaginary));
    }
    public static void Main3()
    {
        ComplexNum cnum1 = new ComplexNum(4, 5);
        ComplexNum cnum2 = new ComplexNum(5, 6);
        // Add two Complex objects (num1 and num2) through the
        ComplexNum addition = cnum1 + cnum2;
        // Print the numbers 
        Console.WriteLine("First complex number:  {0}", cnum1);
        Console.WriteLine("Second complex number: {0}", cnum2);
        Console.WriteLine("RESULT :The sum of the two numbers: {0}", addition);
        // Hault the output screen
        Console.Read();
    }
}

public class Employee : IComparable
{
    public Employee(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    int IComparable.CompareTo(object obj)
    {
        Employee emp2 = (Employee)obj;
        if (this.id > emp2.id)
            return (1);
        if (this.id < emp2.id)
            return (-1);
        else
            return (0);
    }
    public static bool operator <(Employee emp1, Employee emp2)
    {
        IComparable icomp = (IComparable)emp1;
        return (icomp.CompareTo(emp2) < 0);
    }
    public static bool operator >(Employee emp1, Employee emp2)
    {
        IComparable icomp = (IComparable)emp1;
        return (icomp.CompareTo(emp2) > 0);
    }
    public static bool operator <=(Employee emp1, Employee emp2)
    {
        IComparable icomp = (IComparable)emp1;
        return (icomp.CompareTo(emp2) <= 0);
    }
    public static bool operator >=(Employee emp1, Employee emp2)
    {
        IComparable icomp = (IComparable)emp1;
        return (icomp.CompareTo(emp2) >= 0);
    }

    public override string ToString()
    {
        return (name + ":" + id);
    }

    string name;
    int id;
}
class Test
{
    public static void Main4()
    {
        Employee a = new Employee("A", 1);
        Employee b = new Employee("B", 2);
        Employee c = new Employee("C", 4);
        Employee d = new Employee("D", 3);

        Console.WriteLine("a < b: {0}", a < b);
        Console.WriteLine("c >= d: {0}", c >= d);
    }
}
// a < b: True
// c >= d: True

public class Chair
{
    public int Length { get; set; }
    public int Width { get; set; }
    public Chair()
    {
    }
    public Chair(int length, int width)
    {
        Length = length;
        Width = width;
    }
    public static Chair operator +(Chair C1, Chair C2)
    {
        Chair CFinal = new Chair();
        CFinal.Length = C1.Length + C2.Length;
        CFinal.Width = C1.Width + C2.Width;
        return CFinal;
    }
}
class Program
{
    static void Main5(string[] args)
    {
        Chair c1 = new Chair(2, 3);
        Chair c2 = new Chair(4, 5);
        Chair CFinal = c1 + c2;
        Console.WriteLine("Final Chair Dimension is Length = {0}, Width = {1}", CFinal.Length, CFinal.Width);
        Console.Read();
    }
}
// When the above code is compiled and executed, it produces the following result:

// Final Chair Dimension is Length = 6, Width = 8

