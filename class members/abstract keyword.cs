// A method can be abstract. A class can be abstract. An abstract method has no implementation.
// We use an abstract class to create a base template for derived classes.Abstract methods cannot have bodies. 
// When you create a derived class like Example1 or Example2, you must provide override methods for all abstract methods in the abstract class.
// Abstract method-
// An Abstract method is a method without a body. The implementation of an abstract method is done by a derived class. 
// When the derived class inherits the abstract method from the abstract class, it must override the abstract method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class Test
{
	public int _a;
	public abstract void A();
}

class Example1 : Test
{
	public override void A()
	{
		Console.WriteLine("techfunda");
		base._a++;
	}
}
class Example2 : Test
{
	public override void A()
	{
		Console.WriteLine("dotnetfunda");
		base._a--;
	}
}

class Program
{
	static void Main()
	{

		Test test1 = new Example1();
		test1.A();


		Test test2 = new Example2();
		test2.A();
	}
}
// o/p-
// techfunda
// dotnetfunda

abstract class Base
{
	//class members here
	public abstract void DOWork(string id);
}
class Derived : Base
{

	public override void DOWork(string id)
	{
		//do some work here
	}
}
// If derived classes do not have implementation abstract method, the compiler throws the following error:
// Code CS0534 : ‘Derived’ does not implemented inherited abstract member ‘Base.DoWork(string id)’

public abstract class Parent
{
	public abstract void Print();
}
public class Child : Parent
{
	public override void Print()
	{
		Console.WriteLine("I'm a Child Class");
	}
}
class Program1
{
	static void Main1(string[] args)
	{
		Parent parObj = new Child();
		parObj.Print();
		Console.Read();
	}
}
// In above example, when you run the program, at compile time the type of parObj is Parent but it will still call the child class’s override method because at the runtime, the type of the parObj object refers to is Child.

// When you execute following code,it produces the following result:

// I'm a Child Class


namespace ConsoleApplication14
{
	abstract class test1
	{
		public int add(int i, int j)
		{
			return i + j;
		}
		public abstract int mul(int i, int j);
	}
	class test2 : test1
	{
		public override int mul(int i, int j)
		{
			return i * j;
		}
	}
	class test3 : test1
	{
		public override int mul(int i, int j)
		{
			return i - j;
		}
	}
	class test4 : test2
	{
		public override int mul(int i, int j)
		{
			return i + j;
		}
	}
	class myclass
	{
		public static void main(string[] args)
		{
			test2 ob = new test4();
			int a = ob.mul(2, 4);
			test1 ob1 = new test2();
			int b = ob1.mul(4, 2);
			test1 ob2 = new test3();
			int c = ob2.mul(4, 2);
			Console.Write("{0},{1},{2}", a, b, c);
			Console.ReadLine();
		}
	}
}