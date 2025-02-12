// A common place to use lambdas is with List.We pass lambda expressions as arguments, for sorting or for searching. We use them in queries.

using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
	delegate void D(string value);

	static void Main()
	{
		// ... Specify delegate with lambda expression.
		D d = v => Console.WriteLine(v);
		// ... Invoke delegate.
		d.Invoke("cat");
	}
}
// o/p-
// cat

class Program1
{
	//create a delegate
	delegate int del(int i);

	static void Main1(string[] args)
	{
		//lambda expression using delegate keyword
		del d1 = x => x * 5;

		int result = d1(2);

		Console.WriteLine(result);

		Console.Read();
	}

	// o/p-
	// 10

	static void Main5()
	{
		List<int> elements = new List<int>() { 10, 20, 31, 40 };
		// ... Find index of first odd element.
		int oddIndex = elements.FindIndex(x => x % 2 != 0);
		Console.WriteLine(oddIndex);
	}
	// x          The argument name.
	// =>         Separates argument list from result expression.
	// x % 2 !=0  Returns true if x is not even.
	// The =>  operator can be read as "goes to." It is always used when declaring a lambda expression.The => operator separates arguments from methods.
	// With Invoke, a method on Func and Action, we execute the methods in the lambdas.
	// Left side:This is the parameters. It can be empty. Sometimes it can be implicit (derived from the right).
	// Right side:This is a statement list inside curly brackets with a return statement, or an expression.
}

class Program2
{
	static void Main2()
	{
		//
		// Use implicitly-typed lambda expression.
		// ... Assign it to a Func instance.
		//
		Func<int, int> func1 = x => x + 1;
		//
		// Use lambda expression with statement body.
		//
		Func<int, int> func2 = x => { return x + 1; };
		//
		// Use formal parameters with expression body.
		//
		Func<int, int> func3 = (int x) => x + 1;
		//
		// Use parameters with a statement body.
		//
		Func<int, int> func4 = (int x) => { return x + 1; };
		//
		// Use multiple parameters.
		//
		Func<int, int, int> func5 = (x, y) => x * y;
		//
		// Use no parameters in a lambda expression.
		//
		Action func6 = () => Console.WriteLine();
		//
		// Use delegate method expression.
		//
		Func<int, int> func7 = delegate (int x) { return x + 1; };
		//
		// Use delegate expression with no parameter list.
		//
		Func<int> func8 = delegate { return 1 + 1; };
		//
		// Invoke each of the lambda expressions and delegates we created.
		// ... The methods above are executed.
		//
		Console.WriteLine(func1.Invoke(1));
		Console.WriteLine(func2.Invoke(1));
		Console.WriteLine(func3.Invoke(1));
		Console.WriteLine(func4.Invoke(1));
		Console.WriteLine(func5.Invoke(2, 2));
		func6.Invoke();
		Console.WriteLine(func7.Invoke(1));
		Console.WriteLine(func8.Invoke());
	}
}

// Output

// 2
// 2
// 2
// 2
// 4

// 2
// 2
