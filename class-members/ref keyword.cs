using System;

public class Employee
{
	//reference parameters num
	public void ReferenceMethod(ref int num)
	{
		num = num * 100;
	}
}
class Program
{
	static void Main()
	{
		Employee emp = new Employee();
		int i = 3;
		emp.ReferenceMethod(ref i);
		Console.WriteLine(i);
		Console.ReadKey();
	}
}
// o/p-
// 300