
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sealed_class
{
	class Program
	{
		public sealed class BaseClass
		{
			public void Display()
			{
				Console.WriteLine("This is a sealed class which can;t be further inherited");
			}
		}

		public class Derived : BaseClass
		{
			// this Derived class can;t inherit BaseClass because it is sealed
		}

		static void Main(string[] args)
		{
			BaseClass obj = new BaseClass();

			obj.Display();

			Console.ReadLine();
		}
	}
}