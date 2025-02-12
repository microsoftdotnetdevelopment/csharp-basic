// FIFO
// When you add an item in the list, it is called enqueue, and when you remove an item, it is called deque.

using System;
using System.Collections.Generic;
class Program
{
	static void Main(string[] args)
	{
		// Create a Queue
		Queue<string> queueNumbers = new Queue<string>();

		queueNumbers.Enqueue("one");
		queueNumbers.Enqueue("two");
		queueNumbers.Enqueue("three");
		queueNumbers.Enqueue("four");
		queueNumbers.Enqueue("five");

		// A queue can be enumerated without disturbing its contents. 
		foreach (string number in queueNumbers)
		{
			Console.WriteLine(number);
		}

		Console.WriteLine("\nDequeuing '{0}'", queueNumbers.Dequeue());

		Console.WriteLine("Peek at next item to dequeue: {0}",
			queueNumbers.Peek());

		Console.WriteLine("Dequeuing '{0}'", queueNumbers.Dequeue());

		Console.WriteLine("\nContents of the copy:");
		foreach (string number in queueNumbers)
		{
			Console.WriteLine(number);
		}

		Console.WriteLine();

		//clear Queue by Clear method.
		Console.WriteLine("queueNumbers.Clear()");
		queueNumbers.Clear();

		Console.WriteLine();
		Console.WriteLine("queueNumbers.Count = {0}", queueNumbers.Count);
	}
}
// o/p-
// one
// two
// three
// four
// five

// Dequeuing 'one'
// Peek at next item to dequeue: two
// Dequeuing 'two'

// Contents of the copy:
// three
// four
// five

// queueNumbers.Clear()

// queueNumbers.Count = 0