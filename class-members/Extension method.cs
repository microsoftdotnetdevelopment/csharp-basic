// Extension methods enable you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type
// An extension method is a static method of a static class, where the "this" modifier is applied to the first parameter.

using System;
using System.Text;
using ClassLibExtMethod;

namespace ClassLibExtMethod
{
	public class Class1
	{
		public string Display()
		{
			return ("I m in Display");
		}

		public string Print()
		{
			return ("I m in Print");
		}
	}
}



namespace ExtensionMethod1
{
	public static class XX
	{
		public static void NewMethod(this Class1 ob)
		{
			Console.WriteLine("Hello I m extended method");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Class1 ob = new Class1();
			ob.Display();
			ob.Print();
			ob.NewMethod();
			Console.ReadKey();
		}
	}
}
// Ex:2-Without extension

class Program1
{
	static int vow(string m)
	{
		int i, c = 0;
		for (i = 0; i < m.Length; i++)
		{
			if (m[i] == 'a' || m[i] == 'e' || m[i] == 'i' || m[i] == 'o' || m[i] == 'u')
			{
				c++;
			}
		}
		return c;

	}
	static void Main1(string[] args)
	{
		string n = Console.ReadLine();

		int p = vow(n);
		Console.Write(p);
	}
}

// using extension method

namespace program
{
	static class Program2
	{


		public static int vow(this string m)
		{
			int i, c = 0;
			for (i = 0; i < m.Length; i++)
			{
				if (m[i] == 'a' || m[i] == 'e' || m[i] == 'i' || m[i] == 'o' || m[i] == 'u')
				{
					c++;
				}
			}
			return c;

		}
		class th
		{

			static void Main1(string[] args)
			{
				string n = Console.ReadLine();
				Console.WriteLine(n.vow());
			}
		}
	}
}
// Ex:3-without extension

class Program3
{

	static void left(string p, int q)
	{
		int i;
		char[] ch = p.ToCharArray();
		for (i = 0; i < q; i++)
		{
			Console.WriteLine(ch[i]);
		}
	}
	static void Main2(string[] args)
	{

		string p = Console.ReadLine();
		int q = int.Parse(Console.ReadLine());
		left(p, q);
	}
}
// with extension-
static class Program4
{

	public static void left(this int q, string p)
	{
		int i;
		char[] ch = p.ToCharArray();
		for (i = 0; i < q; i++)
		{
			Console.WriteLine(ch[i]);
		}
	}
	class th
	{
		static void Main3(string[] args)
		{

			string p = Console.ReadLine();
			int q = int.Parse(Console.ReadLine());
			q.left(p);
		}
	}
}


public static class MyExtensions
{
	public static int WordCount(this String str)
	{
		return str.Split(new char[] { ' ', '.', ',' }).Length;
	}
}


class Program5
{
	public static void Main5(string[] args)
	{
		string s = "Dot Net Tricks Extension Method Example";
		int i = s.WordCount();
		Console.WriteLine(i);
	}
}

public static class MyExtensions1
{
	public static string UppercaseFirstLetter(this string value)
	{
		if (value.Length > 0)
		{
			char[] array = value.ToCharArray();
			array[0] = char.ToUpper(array[0]);
			return new string(array);
		}
		return value;
	}
}

class Program6
{
	public static void Main6(string[] args)
	{
		string value = "dot net perls";
		value = value.UppercaseFirstLetter();
		Console.WriteLine(value);
	}
}