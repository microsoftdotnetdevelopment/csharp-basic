
using System;
namespace destructorex
{
	class Program
	{
		~Program() // destructor define 
		{
			// clean up statement
		}
	}
}

class First
{
	~First()
	{
		System.Console.WriteLine("First's destructor is called");
	}
}
class Second : First
{
	~Second()
	{
		System.Console.WriteLine("Second's destructor is called");
	}
}
class Third : Second
{
	~Third()
	{
		System.Console.WriteLine("Third's destructor is called");
	}
}
class TestDestructors
{
	static void Main()
	{
		Third t = new Third();
	}
}

// third
// second
// first

namespace ConsoleApplication3
{
	class SampleA
	{
		// Constructor
		public SampleA()
		{
			Console.WriteLine("An  Instance  Created");
		}
		// Destructor
		~SampleA()
		{
			Console.WriteLine("An  Instance  Destroyed");
		}
	}

	class Program1
	{
		public static void Test()
		{
			SampleA T = new SampleA(); // Created instance of class
		}
		static void Main1(string[] args)
		{
			Test();
			GC.Collect();
			Console.ReadLine();
		}
	}
}
// When we run above program it will show output like as shown below

// Output
// An instance created
// An instance destroyed

class Program2
{
	static void Main2(string[] args)
	{
		Child child1 = new Child();
		Console.WriteLine("Child Object Created Suucessfully");
		Console.WriteLine("Press enter to Destroy it");
		Console.ReadLine();
		//child1 = null;
		Console.Read();
	}
}
class Base1
{
	public Base1()
	{
		Console.WriteLine("Creating Base1 object");
	}
	~Base1()
	{
		Console.WriteLine("Destroying Base1 object");
	}
}
class Base2 : Base1
{
	public Base2()
	{
		Console.WriteLine("Creating Base2 object");
	}
	~Base2()
	{
		Console.WriteLine("Destroying Base2 object");
	}
}
class Child : Base2
{
	public Child()
	{
		Console.WriteLine("Creating Child object");
	}
	~Child()
	{
		Console.WriteLine("Destroying Child object");
	}
}
// o/p-
// Creating Base1 object
// Creating Base2 object
// Creating Child object
// Child Object Created Suucessfully
// Press enter to Destroy it


// Destroying Child object
// Destroying Base2 object
// Destroying Base1 object