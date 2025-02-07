
using System;
using System.Collections;

namespace CollectionsApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList sl = new SortedList();

			sl.Add("001", "Zara Ali");
			sl.Add("002", "Abida Rehman");
			sl.Add("003", "Joe Holzner");
			sl.Add("004", "Mausam Benazir Nur");
			sl.Add("005", "M. Amlan");
			sl.Add("006", "M. Arif");
			sl.Add("007", "Ritesh Saikia");

			if (sl.ContainsValue("Nuha Ali"))
			{
				Console.WriteLine("This student name is already in the list");
			}
			else
			{
				sl.Add("008", "Nuha Ali");
			}

			// get a collection of the keys. 
			ICollection key = sl.Keys;

			foreach (string k in key)
			{
				Console.WriteLine(k + ": " + sl[k]);
			}
		}
	}
}

// o/p-
// 001: Zara Ali
// 002: Abida Rehman
// 003: Joe Holzner
// 004: Mausam Banazir Nur
// 005: M. Amlan 
// 006: M. Arif
// 007: Ritesh Saikia
// 008: Nuha Ali

class Program1
{
	static void Main1(string[] args)
	{
		SortedList<int, string> solObj = new SortedList<int, string>();

		solObj.Add(3, "C");
		solObj.Add(1, "A");
		solObj.Add(4, "D");
		solObj.Add(2, "B");

		// Iterate through the SortedList. 
		foreach (var item in solObj)
		{
			Console.WriteLine("Key : " + item.Key + " Value :" + item.Value);
		}

		Console.Read();
	}
}
// o/p-
// Key : 1 Value :A
// Key : 2 Value :B
// Key : 3 Value :C
// Key : 4 Value :D