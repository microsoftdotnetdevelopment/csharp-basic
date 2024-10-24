using System;

public struct Square
{
	public int i, j;
	public Square(int x1, int x2)
	{
		i = x1;
		j = x2;
	}
}

// Declare and initialize struct objects. 
class TestSquare
{
	static void Main()
	{
		// Initialize:   
		Square squ1 = new Square();
		Square squ2 = new Square(2, 3);
		// Display results:
		Console.Write("Square 1: ");
		Console.WriteLine("i = {0}, j = {1}", squ1.i, squ2.j);
		Console.Write("Square 2: ");
		Console.WriteLine("i = {0}, j = {1}", squ2.i, squ2.j);
		// Keep the console window open in debug mode.
		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
	}
}

// When the above code is compiled and executed, it produces the following result:

// Square 1: i = 0, j = 0

// Square 2: i = 10, j = 10