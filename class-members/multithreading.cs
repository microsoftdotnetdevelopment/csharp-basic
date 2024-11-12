using System;
using System.Threading;

class Program
{
	static void Main(string[] args)
	{
		// create thread start delegate instance - contains the method to execute by the thread
		ThreadStart ts = new ThreadStart(run);
		// create new thread
		Thread thrd = new Thread(ts);
		// start thread
		thrd.Start();
		// makes the main thread sleep - let sub thread to run
		Thread.Sleep(1000);
		for (int t = 10; t > 0; t--)
		{
			Console.WriteLine("Main Thread value is :" + t);
			Thread.Sleep(1000);
		}

		Console.WriteLine("Good Bye!!!I'm main Thread");
		Console.ReadLine();
	}
	// this method executed by a separate thread
	static void run()
	{
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("Sub Thread value is : " + i);
			Thread.Sleep(1000);
		}
		Console.WriteLine("Good Bye!!!I'm Sub Thread");
	}
}



// The following program demonstrates the concept of threads:



namespace MultithreadingApplication
{
	class ThreadCreationProgram
	{
		public static void CallToChildThread()
		{
			Console.WriteLine("Child thread starts");
		}

		static void Main1(string[] args)
		{
			ThreadStart childref = new ThreadStart(CallToChildThread);
			Console.WriteLine("In Main: Creating the Child thread");
			Thread childThread = new Thread(childref);
			childThread.Start();
			Console.ReadKey();
		}
	}
}
// When the above code is compiled and executed, it produces the following result:

// In Main: Creating the Child thread
// Child thread starts

// Managing Threads--
// The Thread class provides various methods for managing threads.
// The following example demonstrates the use of the sleep() method for making a thread pause for a specific period of time.

namespace MultithreadingApplication1
{
	class ThreadCreationProgram1
	{
		public static void CallToChildThread()
		{
			Console.WriteLine("Child thread starts");

			// the thread is paused for 5000 milliseconds
			int sleepfor = 5000;

			Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
			Thread.Sleep(sleepfor);
			Console.WriteLine("Child thread resumes");
		}

		static void Main2(string[] args)
		{
			ThreadStart childref = new ThreadStart(CallToChildThread);
			Console.WriteLine("In Main: Creating the Child thread");
			Thread childThread = new Thread(childref);
			childThread.Start();
			Console.ReadKey();
		}
	}
}
// When the above code is compiled and executed, it produces the following result:

// In Main: Creating the Child thread
// Child thread starts
// Child Thread Paused for 5 seconds
// Child thread resumes



// The following program illustrates destroying:



namespace MultithreadingApplication2
{
	class ThreadCreationProgram2
	{
		public static void CallToChildThread()
		{
			try
			{
				Console.WriteLine("Child thread starts");

				// do some work, like counting to 10
				for (int counter = 0; counter <= 10; counter++)
				{
					Thread.Sleep(500);
					Console.WriteLine(counter);
				}

				Console.WriteLine("Child Thread Completed");
			}

			catch (ThreadAbortException e)
			{
				Console.WriteLine("Thread Abort Exception");
			}
			finally
			{
				Console.WriteLine("Couldn't catch the Thread Exception");
			}
		}

		static void Main3(string[] args)
		{
			ThreadStart childref = new ThreadStart(CallToChildThread);
			Console.WriteLine("In Main: Creating the Child thread");
			Thread childThread = new Thread(childref);
			childThread.Start();

			//stop the main thread for some time
			Thread.Sleep(2000);

			//now abort the child
			Console.WriteLine("In Main: Aborting the Child thread");

			childThread.Abort();
			Console.ReadKey();
		}
	}
}
// When the above code is compiled and executed, it produces the following result:

// In Main: Creating the Child thread
// Child thread starts
// 0
// 1
// 2
// In Main: Aborting the Child thread
// Thread Abort Exception
// Couldn't catch the Thread Exception 