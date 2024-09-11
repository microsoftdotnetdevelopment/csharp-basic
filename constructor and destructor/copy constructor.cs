// Copy Constructor
// The constructor which creates an object by copying variables from another object is called a copy constructor. 
// The purpose of a copy constructor is to initialize a new instance to the values of an existing instance.

using System;
namespace copyConstractor
{
	class employee
	{
		private string name;
		private int age;
		public employee(employee emp)   // declaring Copy constructor.
		{
			name = emp.name;
			age = emp.age;
		}
		public employee(string name, int age)  // Instance constructor.
		{
			this.name = name;
			this.age = age;
		}
		public string Details     // Get deatils of employee
		{
			get
			{
				return " The age of " + name + " is " + age.ToString();
			}
		}
	}
	class empdetail
	{
		static void Main()
		{
			employee emp1 = new employee("Vithal", 23);  // Create a new employee object.
			employee emp2 = new employee(emp1);          // here is emp1 details is copied to emp2.
			Console.WriteLine(emp2.Details);
			Console.ReadLine();
		}
	}
}
// o/p-
// The age of Vithal is 23

class Automobile
{
	public int numberOfWheels;
	public int seatingCapacity;

	public Automobile()
	{
		//Default Constructor            
	}


	public Automobile(Automobile oldInstance)
	{
		numberOfWheels = oldInstance.numberOfWheels;
		seatingCapacity = oldInstance.seatingCapacity;
	}
}
class Program1
{
	static void Main1(string[] args)
	{
		Automobile oldInstance = new Automobile();
		oldInstance.numberOfWheels = 5;
		oldInstance.seatingCapacity = 6;

		//Passing oldInstance as a parameter to copy constructor.
		Automobile newInstance = new Automobile(oldInstance);

		//Changed values of oldInstance
		oldInstance.numberOfWheels = 2;
		oldInstance.seatingCapacity = 3;


		Console.WriteLine(oldInstance.numberOfWheels);
		Console.WriteLine(oldInstance.seatingCapacity);

		Console.WriteLine(newInstance.numberOfWheels);
		Console.WriteLine(newInstance.seatingCapacity);
		Console.ReadLine();


		//Outputs
		//2
		//3
		//5
		//6
	}
}
