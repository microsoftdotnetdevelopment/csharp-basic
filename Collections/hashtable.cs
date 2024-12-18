using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		// Creates and initializes a new Hashtable.
		Hashtable htObj = new Hashtable();

		htObj.Add(1, "A");

		htObj.Add(2, "B");

		htObj.Add(3, "C");

		// Displays the properties and values of the ArrayList.
		Console.WriteLine("Count:    {0}", htObj.Count);

		Console.WriteLine();
		Console.WriteLine("Values");

		foreach (DictionaryEntry item in htObj)
		{
			Console.WriteLine("Key : {0}, Value: {1}", item.Key, item.Value);
		}

		//result will be null as key is not in hashtable
		string result = htObj[4] as string;

		Console.WriteLine("result is null :{0}", string.IsNullOrEmpty(result));
		Console.Read();

	}
}
// o/p-
// Count:    3

// Values
// Key : 3, Value: C
// Key : 2, Value: B
// Key : 1, Value: A
// result is null :True