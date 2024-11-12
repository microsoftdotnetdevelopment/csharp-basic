
using System;
namespace ConsoleApplication3
{
	public class Sample
	{
		public string param1, param2;
		public Sample(string a, string b)
		{
			param1 = a;
			param2 = b;
		}
		private Sample()  // Private Constructor Declaration
		{
			Console.WriteLine("Private Constructor with no prameters");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			// Here we don't have chance to create instace for private constructor
			Sample obj = new Sample("Welcome", "to Aspdotnet-Suresh");
			// it will not work because of inaccessability
			// Sample obj=new Sample();
			Console.WriteLine(obj.param1 + " " + obj.param2);
			Console.ReadLine();
		}
	}
}
// o/p-
// Welcome to Aspdotnet-Suresh

