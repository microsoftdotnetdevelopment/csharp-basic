// Collection classes are specialized classes for data storage.
// These classes provide support for stacks, queues, lists, and hash tables.
// list with generic
// list with non generic

using System;
using System.Collections.Generic;
using System.Threading;
class Program
{
	//svm double tab

	public List<int> Fill()
	{
		List<int> randomnumbers = new List<int>();
		int num = 0;
		Random rd = new Random();
		while (num != 16)
		{
			num = rd.Next(1, 20); // including 1 and excluding 20
			randomnumbers.Add(num);
		}
		return randomnumbers;

	}

	public void display(List<int> list)
	{
		foreach (var i in list)
			Console.Write(i + " ");
		Console.WriteLine();
	}
	static void Main(string[] args)
	{

		Program ob = new Program();
		for (int i = 0; i < 10; i++)
		{
			ob.display(ob.Fill());
			Thread.Sleep(1000);
			Console.WriteLine();
		}

	}
	static void Mair()
	{
		string s = "This is a sentence.";
		IList<string> list = new List<string>(s.Split(new string[] { " is " }, StringSplitOptions.None));
		foreach (string element in list)
		{
			Console.WriteLine(element);
		}
	}
	// o/p-
	// This
	// a sentence.
}


class Program56
{
	static void Main56(string[] args)
	{
		// Create a list of strings. 
		List<string> countrys = new List<string>();

		countrys.Add("USA");
		countrys.Add("India");
		countrys.Add("UK");
		countrys.Add("Canada");

		// Iterate through the list before removing 
		foreach (var country in countrys)
		{
			Console.WriteLine(country);
		}

		Console.WriteLine("");

		// This will remove the part at index 1.
		countrys.RemoveAt(1);

		Console.WriteLine("After Removing India from list collection");
		Console.WriteLine("");

		// Iterate through the list after remove
		foreach (var country in countrys)
		{
			Console.WriteLine(country);
		}

		Console.Read();
	}
}

class Program4
{
	static void Main4(string[] args)
	{
		List<string> food = new List<string>();
		food.Add("apple");
		food.Add("banana");

		List<string> vegetables = new List<string>();
		vegetables.Add("tomato");
		vegetables.Add("carrot");

		food.AddRange(vegetables);
		Console.WriteLine(food.Count);
	}
}
// o/p-
// 4

class Program3
{
	static void Main3(string[] args)
	{
		List<int> rollnumber = new List<int>();
		//Add the item in the rollnumber list

		rollnumber.Add(25);
		rollnumber.Add(30);
		rollnumber.Add(45);
		//count the elements in the rollnumber list

		//find an item
		int i = rollnumber.Find(item => item < 60); //lambda expression
		Console.WriteLine("item fount is:" + i);
	}
}
class Program2
{
	static void Main2(string[] args)
	{
		List<int> rollnumber = new List<int>();
		//Add the item in the rollnumber list
		rollnumber.Add(50);
		rollnumber.Add(25);
		rollnumber.Add(30);
		rollnumber.Add(45);
		//find an item using findindex
		int i = rollnumber.FindIndex(item => item < 60); //lambda expression
		Console.WriteLine("item fount at {0} position:" + i);
		//find an item using findlastindex
		int j = rollnumber.FindLastIndex(item => item < 60); //lambda expression
		Console.WriteLine("item fount at {0} position:" + j);
	}
}
class Program1
{
	static void Main1(string[] args)
	{
		List<int> primes = new List<int>(new int[] { 19, 23, 29 });

		int index = primes.IndexOf(23); // Exists.
		Console.WriteLine(index);

		index = primes.IndexOf(10); // Does not exist.
		Console.WriteLine(index);

	}
}
class Program8
{
	static void Main8(string[] args)
	{
		List<string> cities = new List<string>();
		cities.Add("New York");
		cities.Add("Mumbai");
		cities.Add("Berlin");
		cities.Add("Istanbul");

		// Join strings into one CSV line.
		string line = string.Join(",", cities.ToArray());
		Console.WriteLine(line);
	}
}
class Program9
{
	static void Main9(string[] args)
	{
		List<string> dogs = new List<string>(); // Example list.

		dogs.Add("spaniel"); // Contains: spaniel.
		dogs.Add("beagle"); // Contains: spaniel, beagle.
		dogs.Insert(1, "dalmatian"); // Spaniel, dalmatian, beagle.

		foreach (string dog in dogs) // Display for verification.
		{
			Console.WriteLine(dog);
		}
	}
}
class Program7
{
	static void Main7(string[] args)
	{
		List<string> list = new List<string>();
		list.Add("anchovy");
		list.Add("barracuda");
		list.Add("bass");
		list.Add("viperfish");

		// Reverse List in-place, no new variables required.
		list.Reverse();

		foreach (string value in list)
		{
			Console.WriteLine(value);
		}
	}
}
class Program6
{
	static void Main6(string[] args)
	{
		List<int> evenNumbers = new List<int>();
		int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		foreach (int num in numbers)
		{
			if (num % 2 == 0)
				evenNumbers.Add(num);
		}
		foreach (int a in evenNumbers)
			Console.WriteLine(a);
	}
}
