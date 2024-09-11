using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		// Create a Dictionary with Key as int and Value as strings. 
		Dictionary<int, string> DicObject = new Dictionary<int, string>();

		DicObject.Add(1, "A");
		DicObject.Add(2, "B");
		DicObject.Add(3, "C");
		DicObject.Add(4, "D");

		// Iterate through the Dictionary. 
		foreach (var Dics in DicObject)
		{
			Console.WriteLine("Key : " + Dics.Key + " Value :" + Dics.Value);
		}

		Console.Read();
	}
}
// o/p-
// Key : 1 Value :A
// Key : 2 Value :B
// Key : 3 Value :C
// Key : 4 Value :D

class Program1
{
	static void Main1(string[] args)
	{
		Dictionary<string, long> phonebook = new Dictionary<string, long>();
		phonebook.Add("Alex", 415434543);
		phonebook["Jessica"] = 415984588;

		if (phonebook.ContainsKey("Alex"))
		{
			Console.WriteLine("Alex's number is " + phonebook["Alex"]);
		}
	}
}
// o/p-
// Alex's number is 415434543
