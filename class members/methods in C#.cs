//1st method
using System;

class ProgramN
{
	static void charind(string n, char p)
	{
		int i;

		for (i = 0; i < n.Length; i++)
		{
			if (n[i] == p)
			{
				Console.WriteLine(i + 1);
			}
		}
	}

	static void Main(string[] args)
	{
		string n = Console.ReadLine();
		char p = char.Parse(Console.ReadLine());
		charind(n, p);
		Console.ReadKey();
	}
}
//2nd method
class Program2
{
	static void charind()
	{
		int i;
		string n = Console.ReadLine();
		char p = char.Parse(Console.ReadLine());
		for (i = 0; i < n.Length; i++)
		{
			if (n[i] == p)
			{
				Console.WriteLine(i + 1);
			}
		}
	}

	static void Main2(string[] args)
	{
		charind();
		Console.ReadKey();
	}
}
//3rd method
class program3
{

	static int add()
	{
		Console.WriteLine("enetr two no.");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = a + b;
		return c;
	}

	void svm()
	{
		int a = add();
		Console.WriteLine("sum", +a);
	}
	//4th method
	static int add(int a, int b)
	{
		int c = a + b;
		return c;
	}

	void svmm()
	{
		Console.WriteLine("eneter two no.");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = add(a, b);
		Console.WriteLine("sum" + a);
	}


}

namespace CalculatorApplication
{
	class NumberManipulator
	{
		public int FindMax(int num1, int num2)
		{
			/* local variable declaration */
			int result;

			if (num1 > num2)
				result = num1;
			else
				result = num2;
			return result;
		}
		static void Main1(string[] args)
		{
			/* local variable definition */
			int a = 100;
			int b = 200;
			int ret;
			NumberManipulator n = new NumberManipulator();

			//calling the FindMax method
			ret = n.FindMax(a, b);
			Console.WriteLine("Max value is : {0}", ret);
			Console.ReadLine();
		}
	}
}


class program
{
	string name, city;
	int age;

	// Creating method for accepting details
	public void acceptdetails()
	{
		Console.Write("\nEnter your name:\t");
		name = Console.ReadLine();

		Console.Write("\nEnter Your City:\t");
		city = Console.ReadLine();

		Console.Write("\nEnter your age:\t\t");
		age = Convert.ToInt32(Console.ReadLine());
	}

	// Creating method for printing details
	public void printdetails()
	{
		Console.Write("\n\n===================");
		Console.Write("\nName:\t" + name);
		Console.Write("\nCity:\t" + city);
		Console.Write("\nAge:\t" + age);
		Console.Write("\n===================\n");
	}

	static void Main2(string[] args)
	{
		Program p = new Program();
		p.acceptdetails();
		p.printdetails();
		Console.ReadLine();
	}
}

class print
{
	public static void printname()
	{
		Console.WriteLine("Steven Clark");
		Console.ReadLine();
	}
}

class Program5
{
	static void Mai5n(string[] args)
	{
		// call directly static method with class name
		print.printname();
	}
}

public class Base
{
	public void ShowInfo()
	{
		Console.WriteLine("This is Base class");
	}
}

public class SimpleMethod
{
	static void Main3()
	{
		Base bs = new Base();
		bs.ShowInfo();
	}
}



public class Addition
{
	public int AddTwoValues(int x, int y)
	{
		return x + y;
	}

	public int AddThreeValues(int x, int y, int z)
	{
		return x + y + z;
	}
}

public class MethodParameters
{
	static void Main4()
	{
		Addition a = new Addition();
		int x = a.AddTwoValues(12, 13);
		int y = a.AddThreeValues(12, 13, 14);

		Console.WriteLine(x);
		Console.WriteLine(y);
	}
}

public class Employee
{
	public string GetEmployeeFullName(string firstName, string secondName)
	{
		return firstName + " " + secondName;
	}
}

class Program6
{
	static void Main6()
	{
		Employee emp = new Employee();
		string EmpFullname = emp.GetEmployeeFullName("steve", "smith");
		Console.WriteLine(EmpFullname);
		Console.ReadKey();
	}
}
// o/p-
// steve smith

class StaticDemo
{
	public void display(int x)
	{
		Console.WriteLine("Area of a Square:" + x * x);
	}
	public void display(int x, int y)
	{
		Console.WriteLine("Area of a Square:" + x * y);
	}

	static void Main5(string[] args)
	{
		StaticDemo spd = new StaticDemo();
		spd.display(5);
		spd.display(10, 3);
	}
}

class EmployeeDetails2
{

	public static void Main6()
	{
		EmployeeDetails2 p = new EmployeeDetails2();
		p.wer();
	}
	public void wer()
	{
		Console.WriteLine("fr");
	}
}

class EmployeeDetails3
{

	public static void Main7()
	{
		wer();
	}
	public static void wer()
	{
		Console.WriteLine("fr");
	}
}

class EmployeeDetails4
{

	public static void Main8()
	{
		EmployeeDetails4.wer();
	}
	public static void wer()
	{
		Console.WriteLine("fr");
	}
}
