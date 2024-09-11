
using System;
using System.Threading;

namespace ConsoleApplication3
{
	class Sample
	{
		public string param1, param2;
		static Sample()
		{
			Console.WriteLine("Static Constructor");
		}
		public Sample()
		{
			param1 = "Sample";
			param2 = "Instance Constructor";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			// Here Both Static and instance constructors are invoked for first instance
			Sample obj = new Sample();
			Console.WriteLine(obj.param1 + " " + obj.param2);
			// Here only instance constructor will be invoked
			Sample obj1 = new Sample();
			Console.WriteLine(obj1.param1 + " " + obj1.param2);
			Console.ReadLine();
		}
	}
}

// o/p-
// Static Constructor
// Sample Instance Constructor
// Sample Instance Constructor


namespace CheezyCodeApp
{
	class Application
	{
		//static variables
		private static DateTime startedAt;
		private static int instanceCount;
		//property to set current time at instance creation
		private DateTime CurrentTime { get; set; }

		//Static Constructor
		static Application()
		{
			//setting static variable
			instanceCount = 0;
			startedAt = DateTime.Now;
			Console.WriteLine("Application Started at " + startedAt);
		}

		public Application()
		{
			CurrentTime = DateTime.Now;
			instanceCount++;
			Console.WriteLine("Instance " + instanceCount + " created at " + CurrentTime);
		}


	}
	class Program1
	{
		static void Main1(string[] args)
		{
			Application app = new Application();
			Thread.Sleep(1000);
			Application app1 = new Application();
			Thread.Sleep(1000);
			Application app2 = new Application();
			Console.ReadLine();


			//Outputs
			//Application Started at 08/08/2016 22:39:16
			//Instance 1 created at 08/08/2016 22:39:16
			//Instance 2 created at 08/08/2016 22:39:17
			//Instance 3 created at 08/08/2016 22:39:18

		}
	}
}