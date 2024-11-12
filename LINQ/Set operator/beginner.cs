using System;
using System.Linq;

class Program
{
	static void Main()
	{

		// Return distinct country names. In this example the default comparer is being used and the comparison is case-sensitive, so in the output we see country USA 2 times. 

		string[] countries = { "USA", "usa", "INDIA", "UK", "UK" };

		var result = countries.Distinct();

		foreach (var v in result)
		{
			Console.WriteLine(v);
		}

		// Output: 
		// distinct in linq 

		// Example 2: For the comparison to be case-insensitive, use the other overloaded version of Distinct() method to which we can pass a class that implements IEqualityComparer as an argument. In this case we see country USA only once in the output.

		string[] countries1 = { "USA", "usa", "INDIA", "UK", "UK" };

		var result1 = countries1.Distinct(StringComparer.OrdinalIgnoreCase);

		foreach (var v in result1)
		{
			Console.WriteLine(v);
		}

		// Output: 
		// distinct in linq example 

		// When comparing elements, Distinct() works in a slightly different manner with complex types like Employee, Customer etc. 

		// Example 3: Notice that in the output we don't get unique employees. This is because, the default comparer is being used which will just check for object references being equal and not the individual property values.

		List<Employee> list = new List<Employee>()
{
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 102, Name = "Mary"}
};

		var result2 = list.Distinct();

		foreach (var v in result2)
		{
			Console.WriteLine(v.ID + "\t" + v.Name);
		}

// Output: 
// linq distinct c# example 

		// To solve the problem in Example 3, there are 3 ways
		// 1. Use the other overloaded version of Distinct() method to which we can pass a custom class that implements IEqualityComparer
		// 2. Override Equals() and GetHashCode() methods in Employee class
		// 3. Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods

		// Example 4 : Using the overloaded version of Distinct() method to which we can pass a custom class that implements IEqualityComparer

		// Step 1 : Create a custom class that implements IEqualityComparer<T> and implement Equals() and GetHashCode() methods

public class EmployeeComparer : IEqualityComparer<Employee>
	{
		public bool Equals(Employee x, Employee y)
		{
			return x.ID == y.ID && x.Name == y.Name;
		}

		public int GetHashCode(Employee obj)
		{
			return obj.ID.GetHashCode() ^ obj.Name.GetHashCode();
		}
	}

	// Step 2 : Pass an instance of EmployeeComparer as an argument to Distinct() method

	List<Employee> list11 = new List<Employee>()
{
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 102, Name = "Mary"}
};

	var result3 = list11.Distinct(new EmployeeComparer());

foreach (var v in result3)
{
    Console.WriteLine(v.ID + "\t" + v.Name);
}

// Output: 
// iequalitycomparer example 

// Example 5 : Override Equals() and GetHashCode() methods in Employee class

public class Employee
{
	public int ID { get; set; }
	public string Name { get; set; }

	public override bool Equals(object obj)
	{
		return this.ID == ((Employee)obj).ID && this.Name == ((Employee)obj).Name;
	}

	public override int GetHashCode()
	{
		return this.ID.GetHashCode() ^ this.Name.GetHashCode();
	}
}

// Example 6 : Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods

List<Employee> list2 = new List<Employee>()
{
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 102, Name = "Mary"}
};

var result4 = list2.Select(x => new { x.ID, x.Name }).Distinct();

foreach (var v in result4)
{
	Console.WriteLine(" " + v.ID + "\t" + v.Name);
}

// Union combines two collections into one collection while removing the duplicate elements.

// Example 1: numbers1 and numbers2 collections are combined into a single collection. Notice that, the duplicate elements are removed.

int[] numbers1 = { 1, 2, 3, 4, 5 };
int[] numbers2 = { 1, 3, 6, 7, 8 };

var result5 = numbers1.Union(numbers2);

foreach (var v in result5)
{
	Console.WriteLine(v);
}

// Output: 
// union in linq 

// When comparing elements, just like Distinct() method, Union(), Intersect() and Except() methods work in a slightly different manner with complex types like Employee, Customer etc. 

// Example 2 : Notice that in the output the duplicate employee objects are not removed. This is because, the default comparer is being used which will just check for object references being equal and not the individual property values.

List<Employee> list1 = new List<Employee>()
{
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 102, Name = "Susy"},
	new Employee { ID = 103, Name = "Mary"}
};

List<Employee> list2 = new List<Employee>()
{
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 104, Name = "John"}
};

var result = list1.Union(list2);

foreach (var v in result)
{
	Console.WriteLine(v.ID + "\t" + v.Name);
}

// Output : 
// union in linq example 

// Example 3 : To solve the problem in Example 2, there are 3 ways
// 1. Use the other overloaded version of Union() method to which we can pass a custom class that implements IEqualityComparer
// 2. Override Equals() and GetHashCode() methods in Employee class
// 3. Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods

// Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods
List<Employee> list1 = new List<Employee>()
{
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 102, Name = "Susy"},
	new Employee { ID = 103, Name = "Mary"}
};

List<Employee> list2 = new List<Employee>()
{
	new Employee { ID = 101, Name = "Mike"},
	new Employee { ID = 104, Name = "John"}
};

var result = list1.Select(x => new { x.ID, x.Name })
					.Union(list2.Select(x => new { x.ID, x.Name }));

foreach (var v in result)
{
	Console.WriteLine(v.ID + "\t" + v.Name);
}

// Output :  
// union in linq c# 

// Intersect() returns the common elements between the 2 collections.

// Example 4 : Return common elements in numbers1 and numbers2 collections.

int[] numbers1 = { 1, 2, 3, 4, 5 };
int[] numbers2 = { 1, 3, 6, 7, 8 };

var result = numbers1.Intersect(numbers2);

foreach (var v in result)
{
	Console.WriteLine(v);
}

// Output :  
// intersect in linq 

// Except() returns the elements that are present in the first collection but not in the second collection.

// Example 5: Return the elements that are present in the first collection but not in the second collection.

int[] numbers1 = { 1, 2, 3, 4, 5 };
int[] numbers2 = { 1, 3, 6, 7, 8 };

var result = numbers1.Except(numbers2);

foreach (var v in result)
{
	Console.WriteLine(v);
}
}}