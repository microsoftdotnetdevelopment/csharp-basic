// Params enables methods to receive variable numbers of parameters. 
// With params, the arguments passed to a method are changed by the compiler to elements in a temporary array. 
using System;

class Program
{
	static void Main()
	{
		// Call params method with one to four int arguments.
		int sum1 = SumParameters(1);
		int sum2 = SumParameters(1, 2);
		int sum3 = SumParameters(3, 3, 3);
		int sum4 = SumParameters(2, 2, 2, 2);

		// ... Write results of the method invocations.
		Console.WriteLine(sum1);
		Console.WriteLine(sum2);
		Console.WriteLine(sum3);
		Console.WriteLine(sum4);
	}

	static int SumParameters(params int[] values)
	{
		// Loop through and sum the integers in the array.
		int total = 0;
		foreach (int value in values)
		{
			total += value;
		}
		return total;
	}
}

// Output

// 1
// 3
// 9
// 8


namespace ArrayApplication
{
	class ParamArray
	{
		public int AddElements(params int[] arr)
		{
			int sum = 0;
			foreach (int i in arr)
			{
				sum += i;
			}
			return sum;
		}
	}

	class TestClass
	{
		static void Main1(string[] args)
		{
			ParamArray app = new ParamArray();
			int sum = app.AddElements(512, 720, 250, 567, 889);
			Console.WriteLine("The sum is: {0}", sum);
			Console.ReadKey();
		}
	}
}
