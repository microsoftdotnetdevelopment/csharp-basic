using System;

public class Employee
{
	//value parameter number
	public void valueMethod(int number)
	{
		number = number * 100;
	}
}
class Program
{
	static void Main()
	{
		Employee emp = new Employee();
		int i = 3;
		emp.valueMethod(i);
		Console.WriteLine(i);
		Console.ReadKey();
	}
}
// o/p-
// 3

// Methods Parameter:
// Pass by value/pass by reference
// Ex:- Pass by value

class EmployeeDetails2
{

	public static void Main2()
	{
		int i = 0;
		see(i);
		Console.WriteLine(i);
	}
	public static void see(int j)
	{
		j = 100;
	}
}
// o/p-
// 0
// It is pass by value here two variables pointing to two different locations.One variable will not affect the value of other variable.

// Ex:1- pass by reference
class EmployeeDetails1
{

	public static void Main1()
	{
		int i = 0;
		see(ref i);
		Console.WriteLine(i);
	}
	public static void see(ref int j)
	{
		j = 100;
	}
}
// It is pass by reference here two variables pointing to two same locations.One variable will affect the value of other variable.
