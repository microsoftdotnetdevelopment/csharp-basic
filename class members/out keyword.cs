using System;

public class Employee
{
	//Out Parameter num
	public void OutputMethod(out int num)
	{
		num = 100;
	}
}
class Program
{
	static void Main()
	{
		Employee emp = new Employee();
		int i;
		emp.OutputMethod(out i);
		Console.WriteLine(i);
		Console.ReadKey();
	}
}
// o/p-
// 100


namespace CalculatorApplication
{
	class NumberManipulator
	{
		public void getValues(out int x, out int y)
		{
			Console.WriteLine("Enter the first value: ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second value: ");
			y = Convert.ToInt32(Console.ReadLine());
		}
		static void Main1(string[] args)
		{
			NumberManipulator n = new NumberManipulator();

			/* local variable definition */
			int a, b;

			/* calling a function to get the values */
			n.getValues(out a, out b);

			Console.WriteLine("After method call, value of a : {0}", a);
			Console.WriteLine("After method call, value of b : {0}", b);
			Console.ReadLine();
		}
	}
}

// When you want a method to return more than one value.

class EmployeeDetails
{

	public static void Main2()
	{
		int t = 0;
		int tp = 0;
		see(10, 20, out t, out tp);
		Console.WriteLine("sum={0} and pro={1}", t, tp);
	}
	public static void see(int j, int k, out int s, out int p)
	{
		s = j + k;
		p = j * k;
	}
}