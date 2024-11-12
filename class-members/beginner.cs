using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

class Program
{
	static void Main()
	{
		// Prompt the user for his name
		Console.WriteLine("Please enter your name");
		// Read the name from console
		string UserName = Console.ReadLine();
		// Concatenate name with hello word and print
		Console.WriteLine("Hello " + UserName);
		//Placeholder syntax to print name with hello word 
		//Console.WriteLine("Hello {0}", UserName);
	}

	static void Findrange()
	{
		int i = 0;
		Console.WriteLine("Min={0}", int.MinValue);
		Console.WriteLine("Min={0}", int.MaxValue);
	}
}


namespace goto_statements
{
	class Program1
	{
		static void Main1(string[] args)
		{
			string name;

		label: //creating label with colon(:)

			Console.WriteLine("Enter your name: ");
			name = Console.ReadLine();

			Console.WriteLine("Welcome {0}", name);
			Console.WriteLine("Press Ctrl + C for Exit\n");

			goto label; //jump to label statement           
		}
	}
}

namespace Hello
{
	class Program2
	{
		static void Main2(string[] args)
		{

			int i;
			for (i = 0; i <= 10; i++)
			{
				if (i == 5)
					continue;

				if (i == 8)
					break;
				Console.WriteLine("value is" + i);
			}
			Console.ReadLine();
		}
	}
}

// Recursion-
// A recursive function is a function that calls itself.

namespace InterviewQuestionPart4
{
	class Program3
	{
		static void Main3(string[] args)
		{
			Console.WriteLine("Please Enter a Number");

			//read number from user    
			int number = Convert.ToInt32(Console.ReadLine());
			//invoke the static method    
			double factorial = Factorial(number);

			//print the factorial result    
			Console.WriteLine("factorial of" + number + "=" + factorial.ToString());

		}
		public static double Factorial(int number)
		{
			if (number == 0)
				return 1;

			double factorial = 1;
			for (int i = number; i >= 1; i--)
			{
				factorial = factorial * i;
			}
			return factorial;
		}
	}
}

// Explain the Finalize() and Dispose() methods in Garbage Collection class?
// Dispose() is called when we want for an object to release any unmanaged resources with them. It belongs to IDisposable interface.
class jkhbkj
{
	static void Mainrdt()
	{
		string constring = "Server=(local);Database=my; User Id=sa; Password=sa";
		SqlConnection sqlcon = new SqlConnection(constring);
		try
		{



			sqlcon.Open(); // here connection is open


			// some code here which will be execute
		}
		catch
		{
			// code will be execute when error occurred in try block
		}
		finally
		{
			sqlcon.Close(); // close the connection
			sqlcon.Dispose(); // detsroy the connection object
		}
	}
}
// Finalize() is used for the same purpose but it doesn't assure the garbage collection of an object. It belongs to Object class
class employee
{
	//This is the destructor of emp class
	~employee()
	{

	}
	//This destructor is implicitly compiled to the Finalize method.
}

class Program4
{
	static void Main4(String[] args)
	{
		if (args.Length > 0)
		{
			Console.WriteLine("First Argument Is - " + args[0]); //PRINT FIRST ARGUMENT    
		}
		Console.Read();
	}

	//Main(String[] args) method has String[] args in parenthesis. This implies - Main() method can accept array of arguments of type String.
	static void Mainjkhnkj(String[] args)
	{
		int a = 2;
		int b = 3;

		int c = ++a + b++;

		int d = ++a - b-- + c++;


		int e = ++c + d++ - a-- + b++;
		Console.WriteLine(e);
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		Console.WriteLine(d);
	}
}


