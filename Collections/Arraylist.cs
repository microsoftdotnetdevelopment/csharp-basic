// It represents an ordered collection of an object that can be indexed individually. It is basically an alternative to an array. 
// However, unlike array you can add and remove items from a list at a specified position using an index and the array resizes itself automatically. 
// It also allows dynamic memory allocation, adding, searching and sorting items in the list.

using System;
using System.Collections;

namespace CollectionApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList al = new ArrayList();

			Console.WriteLine("Adding some numbers:");
			al.Add(45);
			al.Add(78);
			al.Add(33);
			al.Add(56);
			al.Add(12);
			al.Add(23);
			al.Add(9);

			Console.WriteLine("Capacity: {0} ", al.Capacity);
			Console.WriteLine("Count: {0}", al.Count);

			Console.Write("Content: ");
			foreach (int i in al)
			{
				Console.Write(i + " ");
			}

			Console.WriteLine();
			Console.Write("Sorted Content: ");
			al.Sort();
			foreach (int i in al)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}

// o/p-
// Adding some numbers:
// Capacity: 8
// Count: 7
// Content: 45 78 33 56 12 23 9
// Content: 9 12 23 33 45 56 78  

class Program1
{
	static void Main1(string[] args)
	{
		// Creates and initializes a new ArrayList.
		ArrayList alObj = new ArrayList();

		alObj.Add("A");
		alObj.Add("B");
		alObj.Add(1);

		// Displays the properties and values of the ArrayList.
		Console.WriteLine("Count:    {0}", alObj.Count);

		Console.WriteLine();

		Console.WriteLine("Capacity: {0}", alObj.Capacity);

		Console.WriteLine();

		Console.WriteLine("Values:");

		foreach (var item in alObj)
		{
			Console.WriteLine(item);
		}

		Console.Read();

	}
}
// o/p-
// Count:    3

// Capacity: 4

// Values:
// A
// B
// 1

class Program2
{
	static void Main2(string[] args)
	{

		ArrayList aList = new ArrayList();
		aList.Add("Sunday");
		aList.Add("Monday");
		aList.Add("Tuesday");
		aList.Add("Wednesday");
		aList.Add("Thurday");
		aList.Add("Friday");
		aList.Add("Saturday");
		aList.Insert(2, "Tuesday");
		aList.Remove("Monday");
		aList.Sort();
		// 		ListBox1.DataSource = aList;
		// 		ListBox1.DataBind();
	}
}