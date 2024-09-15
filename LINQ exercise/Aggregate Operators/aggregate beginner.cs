// The first call uses a Func that specifies that the accumulation should be added to the next element. This simply results in the sum of all the elements in the array.
// The Aggregate method receives a higher-order procedure of type Func. The Func receives two arguments and returns a third
using System;
using System.Linq;

class Program
{
	static void Main()
	{
		int[] array = { 1, 2, 3, 4, 5 };
		int result = array.Aggregate((a, b) => b + a);
		// 1 + 2 = 3
		// 3 + 3 = 6
		// 6 + 4 = 10
		// 10 + 5 = 15
		Console.WriteLine(result);

		result = array.Aggregate((a, b) => b * a);   // ((((1*2)*3)*4)*5)
													 // 1 * 2 = 2
													 // 2 * 3 = 6
													 // 6 * 4 = 24
													 // 24 * 5 = 120
		Console.WriteLine(result);
	}
}

// Output
// 15
// 120

namespace Demo1
{
	class Program1
	{
		static void Main1()
		{
			int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			int smallestNumber = Numbers.Min();
			int smallestEvenNumber = Numbers.Where(n => n % 2 == 0).Min();

			int largestNumber = Numbers.Max();
			int largestEvenNumber = Numbers.Where(n => n % 2 == 0).Max();

			int sumOfAllNumbers = Numbers.Sum();
			int sumOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Sum();

			int countOfAllNumbers = Numbers.Count();
			int countOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Count();

			double averageOfAllNumbers = Numbers.Average();
			double averageOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Average();

			Console.WriteLine("Smallest Number = " + smallestNumber);
			Console.WriteLine("Smallest Even Number = " + smallestEvenNumber);

			Console.WriteLine("Largest Number = " + largestNumber);
			Console.WriteLine("Largest Even Number = " + largestEvenNumber);

			Console.WriteLine("Sum of All Numbers = " + sumOfAllNumbers);
			Console.WriteLine("Sum of All Even Numbers = " + sumOfAllEvenNumbers);

			Console.WriteLine("Count of All Numbers = " + countOfAllNumbers);
			Console.WriteLine("Count of All Even Numbers = " + countOfAllEvenNumbers);

			Console.WriteLine("Average of All Numbers = " + averageOfAllNumbers);
			Console.WriteLine("Average of All Even Numbers = " + averageOfAllEvenNumbers);
		}
	}
}


namespace Demo2
{
	class Program2
	{
		static void Main2()
		{
			string[] countries = { "India", "USA", "UK" };

			int minCount = countries.Min(x => x.Length);
			int maxCount = countries.Max(x => x.Length);

			Console.WriteLine
				   ("The shortest country name has {0} characters in its name", minCount);
			Console.WriteLine
				   ("The longest country name has {0} characters in its name", maxCount);
		}
	}
}