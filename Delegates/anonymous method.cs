
using System;
delegate void NumberChanger(int n);
namespace DelegateAppl
{
	class TestDelegate
	{
		static int num = 10;
		public static void AddNum(int p)
		{
			num += p;
			Console.WriteLine("Named Method: {0}", num);
		}

		public static void MultNum(int q)
		{
			num *= q;
			Console.WriteLine("Named Method: {0}", num);
		}

		public static int getNum()
		{
			return num;
		}
		static void Main(string[] args)
		{
			//create delegate instances using anonymous method
			NumberChanger nc = delegate (int x)
			{
				Console.WriteLine("Anonymous Method: {0}", x);
			};

			//calling the delegate using the anonymous method 
			nc(10);

			//instantiating the delegate using the named methods 
			nc = new NumberChanger(AddNum);

			//calling the delegate using the named methods 
			nc(5);

			//instantiating the delegate using another named methods 
			nc = new NumberChanger(MultNum);

			//calling the delegate using the named methods 
			nc(2);
			Console.ReadKey();
		}
	}
}
// o/p
// Anonymous method: 10
// Named method: 15
// Name method: 30

delegate void Printer(string s);

class TestClass
{
	static void Main2()
	{
		// Instantiate the delegate type using an anonymous method.
		Printer p = delegate (string j)
		{
			System.Console.WriteLine(j);
		};

		// Results from the anonymous delegate call.
		p("The delegate using the anonymous method is called.");

		// The delegate instantiation using a named method "DoWork".
		p = new Printer(TestClass.DoWork);

		// Results from the old style delegate call.
		p("The delegate using the named method is called.");
	}

	// The method associated with the named delegate.
	static void DoWork(string k)
	{
		System.Console.WriteLine(k);
	}
}
/* Output:
	The delegate using the anonymous method is called.
	The delegate using the named method is called.
*/

delegate int MathOp(int a, int b);
class Program
{
	//delegate for representing anonymous method
	delegate int del(int x, int y);

	static void Main3(string[] args)
	{
		//anonymous method using delegate keyword
		del d1 = delegate (int x, int y) { return x * y; };

		int z1 = d1(2, 3);

		Console.WriteLine(z1);
	}
}
//output:
// 6


delegate void MyDelegate(string s);

class MyClass
{
	public static void Hello(string s)
	{
		Console.WriteLine("  Hello, {0}!", s);
	}

	public static void Goodbye(string s)
	{
		Console.WriteLine("  Goodbye, {0}!", s);
	}

	public static void Main4()
	{
		MyDelegate a, b, c, d;

		// Create the delegate object a that references 
		// the method Hello:
		a = new MyDelegate(Hello);
		// Create the delegate object b that references 
		// the method Goodbye:
		b = new MyDelegate(Goodbye);
		// The two delegates, a and b, are composed to form c: 
		c = a + b;
		// Remove a from the composed delegate, leaving d, 
		// which calls only the method Goodbye:
		d = c - a;

		Console.WriteLine("Invoking delegate a:");
		a("A");
		Console.WriteLine("Invoking delegate b:");
		b("B");
		Console.WriteLine("Invoking delegate c:");
		c("C");
		Console.WriteLine("Invoking delegate d:");
		d("D");
	}
}
// Output
// Invoking delegate a:
//   Hello, A!
// Invoking delegate b:
//   Goodbye, B!
// Invoking delegate c:
//   Hello, C!
//   Goodbye, C!
// Invoking delegate d:
//   Goodbye, D!

class Program1
{

	//create a delegate

	delegate int del(int x, int y);

	static void Main1(string[] args)
	{
		//instantiate the delegate using an anonymous method.

		del d1 = delegate (int x, int y) { return x * y; };

		int result = d1(4, 3);

		Console.WriteLine(result);

		Console.Read();
	}
}
// o/p-
// 12