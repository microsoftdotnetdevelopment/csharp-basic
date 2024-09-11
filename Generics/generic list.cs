
using System;
using System.Collections.Generic;
namespace delegatesSample
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string> actdel = new Action<string>(ModelNumber);

			actdel("2013");
			actdel("203");
			Console.Read();
		}
		public static void ModelNumber(string year)
		{
			Console.WriteLine("vehicle Model number = " + year);
		}
	}
}
// 12

namespace delegatesSample
{
	class Program1
	{
		static void Main1(string[] args)
		{
			Func<int, int, string> FucDel = new Func<int, int, string>(AddNumber);
			Console.WriteLine(FucDel(4, 5));
			Console.Read();
		}
		public static string AddNumber(int n1, int n2)
		{
			return "Total = " + (n1 + n2);
		}
	}
}
// o/p-
// Total = 9

namespace delegatesSample
{
	class Program2
	{
		static void Main2(string[] args)
		{
			Predicate<string> PreDel = new Predicate<string>(IsStringNull);

			Console.WriteLine(PreDel(""));
			Console.Read();
		}


		public static bool IsStringNull(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

//Declare the generic class
public class GenericTestList<T>
{
	//Declare the generic method
	public void Add(T input)
	{
	}
}

//Declare Simple non generic Class
public class TestClass
{

}

class Program3
{
	static void Main3(string[] args)
	{
		// Declare a list of type int.
		GenericTestList<int> list1 = new GenericTestList<int>();

		// Declare a list of type string.
		GenericTestList<string> list2 = new GenericTestList<string>();

		// Declare a list of type ExampleClass.
		GenericTestList<TestClass> list3 = new GenericTestList<TestClass>();
	}
}


public interface IGenericInterface<T>
{
	int Total { get; }
	void Get(int index);
}


public interface ITest1<T> : IGenericInterface<T>
{
	void Add(T item);
}


public class TestClass<T> : ITest1<T>
{
	public int Total { get { return 0; } }

	public void Add(T item)
	{
		// to do
	}
	public void Get(int index)
	{
		//to do
	}
}

namespace Application
{
	public class ProgramNew
	{
		static void Main4(string[] args)
		{
			int x = 10;
			int y = 20;

			System.Console.WriteLine(" x : {0}, y: {1} ", x, y);

			Swap<int>(ref x, ref y);

			System.Console.WriteLine(" x : {0}, y: {1} ", x, y);

			Console.Read();
		}

		//Generic Method Swap
		static void Swap<T>(ref T lhs, ref T rhs)
		{
			T temp;
			temp = lhs;
			lhs = rhs;
			rhs = temp;
		}
	}
}
// Don’t use same parameter for generic method as containing generic class, 

class GenericTestList1<T>
{
	//following method will generate warning as in follwoing line
	//CS0693 C# Type parameter '' has the same name as the type parameter from outer type ''

	void SampleMethod<T>() { }
}

class GenericTestList2<T>
{
	//No warning 
	void SampleMethod<U>() { }
}


public delegate void Del<T>(T item);

// static void Notify(int i) { }

// Del<int> m1 = new Del<int>(Notify);