using System;

class Employee
{
	public string FullName
	{
		get { return Name; }
	}

	//Static field
	public static string Name;
}


class Program
{
	static void Main(string[] args)
	{
		Employee emp1 = new Employee();

		Employee emp2 = new Employee();

		Employee.Name = "Steve";

		Console.WriteLine("Employee1 Name = {0}, Employee2 Name = {1}", emp1.FullName, emp2.FullName);

		Console.Read();

		//Follwoing line will generate error is 
		//Member 'Employee.Name' cannot be accessed by with an instance reference.
		//emp1.Name = ;
	}
}
// o/p-
// Employee1 Name = Steve, Employee2 Name = Steve