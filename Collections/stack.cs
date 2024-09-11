// It represents a last-in, first out collection of object.
// It is used when you need a last-in, first-out access of items.
//  When you add an item in the list, it is called pushing the item and when you remove it, it is called popping the item.
using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Stack<string> stkObj = new Stack<string>();

		stkObj.Push("A");
		stkObj.Push("B");
		stkObj.Push("C");
		stkObj.Push("D");

		Console.WriteLine("First Time iterator");

		foreach (var stack in stkObj)
		{
			Console.WriteLine(stack);
		}

		//Pop Out the last element from Stack 
		stkObj.Pop();

		Console.WriteLine("second Time iterator after pop");
		foreach (var stack in stkObj)
		{
			Console.WriteLine(stack);
		}

		Console.Read();
	}
}
// o/p-
// First Time iterator
// D
// C
// B
// A
// second Time iterator after pop
// C
// B
// A