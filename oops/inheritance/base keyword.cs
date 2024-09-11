using System;
// The base keyword is used to access members of the base class from within a derived class: 
class Car
{
	public void drive()
	{
		Console.WriteLine("Base Class : Drive Method");
	}
}

class MyCar : Car
{
	public new void drive()
	{
		base.drive(); //Calling Car's drive() method
		Console.WriteLine("Derived Class : Drive Method");
	}
}
class Program
{

	static void Main(string[] args)
	{
		MyCar o2 = new MyCar();
		o2.drive();

		//Output 
		//Base Class : Drive Method
		//Derived Class : Drive Method

		Console.ReadKey();
	}
}
// o/p-
// Base Class : Drive Method
// Derived Class : Drive Method