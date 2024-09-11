
using System;
namespace Constructor
{
	class paraconstrctor
	{
		public int a, b;
		public paraconstrctor(int x, int y)  // decalaring Paremetrized Constructor with int x,y parameter
		{
			a = x;
			b = y;
		}
	}
	class MainClass
	{
		static void Main()
		{
			paraconstrctor v = new paraconstrctor(100, 175);   // Creating object of Parameterized Constructor and int values 
			Console.WriteLine("-----------parameterized constructor example by vithal wadje---------------");
			Console.WriteLine("\t");
			Console.WriteLine("value of a=" + v.a);
			Console.WriteLine("value of b=" + v.b);
			Console.Read();
		}
	}
}

// o/p-
// 100
// 175