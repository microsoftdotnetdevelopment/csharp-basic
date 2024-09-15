// Group Join produces hierarchical data structures. Each element from the first collection is paired with a set of correlated elements from the second collection. 

public class Department
{
	public int ID { get; set; }
	public string Name { get; set; }

	public static List<Department> GetAllDepartments()
	{
		return new List<Department>()
		{
			new Department { ID = 1, Name = "IT"},
			new Department { ID = 2, Name = "HR"},
			new Department { ID = 3, Name = "Payroll"},
		};
	}
}

public class Employee
{
	public int ID { get; set; }
	public string Name { get; set; }
	public int DepartmentID { get; set; }

	public static List<Employee> GetAllEmployees()
	{
		return new List<Employee>()
		{
			new Employee { ID = 1, Name = "Mark", DepartmentID = 1 },
			new Employee { ID = 2, Name = "Steve", DepartmentID = 2 },
			new Employee { ID = 3, Name = "Ben", DepartmentID = 1 },
			new Employee { ID = 4, Name = "Philip", DepartmentID = 1 },
			new Employee { ID = 5, Name = "Mary", DepartmentID = 2 },
			new Employee { ID = 6, Name = "Valarie", DepartmentID = 2 },
			new Employee { ID = 7, Name = "John", DepartmentID = 1 },
			new Employee { ID = 8, Name = "Pam", DepartmentID = 1 },
			new Employee { ID = 9, Name = "Stacey", DepartmentID = 2 },
			new Employee { ID = 10, Name = "Andy", DepartmentID = 1}
		};
	}
}

// Example 1: Group employees by Department.
var employeesByDepartment = Department.GetAllDepartments()
																		   .GroupJoin(Employee.GetAllEmployees(),
																			 d => d.ID,
																			 e => e.DepartmentID,
																			 (department, employees) => new
																			 {
																				 Department = department,
																				 Employees = employees
																			 });

foreach (var department in employeesByDepartment)
{
	Console.WriteLine(department.Department.Name);
	foreach (var employee in department.Employees)
	{
		Console.WriteLine(" " + employee.Name);
	}
	Console.WriteLine();
}

// Output: 


// Example 2: Rewrite Example 1 using SQL like syntax.
var employeesByDepartment = from d in Department.GetAllDepartments()
							join e in Employee.GetAllEmployees()
							on d.ID equals e.DepartmentID into eGroup
							select new
							{
								Department = d,
								Employees = eGroup
							};

// Please note: Group Join uses the join operator and the into keyword to group the results of the join. 

// If you have 2 collections, and when you perform an inner join, then only the matching elements between the 2 collections are included in the result set. Non - Matching elements are excluded from the result set.
public class Department
{
	public int ID { get; set; }
	public string Name { get; set; }

	public static List<Department> GetAllDepartments()
	{
		return new List<Department>()
		{
			new Department { ID = 1, Name = "IT"},
			new Department { ID = 2, Name = "HR"},
			new Department { ID = 3, Name = "Payroll"},
		};
	}
}

public class Employee
{
	public int ID { get; set; }
	public string Name { get; set; }
	public int DepartmentID { get; set; }

	public static List<Employee> GetAllEmployees()
	{
		return new List<Employee>()
		{
			new Employee { ID = 1, Name = "Mark", DepartmentID = 1 },
			new Employee { ID = 2, Name = "Steve", DepartmentID = 2 },
			new Employee { ID = 3, Name = "Ben", DepartmentID = 1 },
			new Employee { ID = 4, Name = "Philip", DepartmentID = 1 },
			new Employee { ID = 5, Name = "Mary", DepartmentID = 2 },
			new Employee { ID = 6, Name = "Valarie", DepartmentID = 2 },
			new Employee { ID = 7, Name = "John", DepartmentID = 1 },
			new Employee { ID = 8, Name = "Pam", DepartmentID = 1 },
			new Employee { ID = 9, Name = "Stacey", DepartmentID = 2 },
			new Employee { ID = 10, Name = "Andy"}
		};
	}
}

// Example 1 : Join the Employees and Department collections and print all the Employees and their respective department names.
var result = Employee.GetAllEmployees().Join(Department.GetAllDepartments(),
										e => e.DepartmentID,
										d => d.ID, (employee, department) => new
										{
											EmployeeName = employee.Name,
											DepartmentName = department.Name
										});
foreach (var employee in result)
{
	Console.WriteLine(employee.EmployeeName + "\t" + employee.DepartmentName);
}

// Output:

// Example 2 : Rewrite Example 1 using SQL like syntax. 
var result = from e in Employee.GetAllEmployees()
			 join d in Department.GetAllDepartments()
			 on e.DepartmentID equals d.ID
			 select new
			 {
				 EmployeeName = e.Name,
				 DepartmentName = d.Name
			 };

foreach (var employee in result)
{
	Console.WriteLine(employee.EmployeeName + "\t" + employee.DepartmentName);
}

// Cross join produces a cartesian product i.e when we cross join two sequences, every element in the first collection is combined with every element in the second collection. 
// The total number of elements in the resultant sequence will always be equal to the product of the elements in the two source sequences. The on keyword that specfies the JOIN KEY is not required.

// Let us understand implementing Cross Join with an example. Consider the following Department and Employee classes. 

public class Department
{
	public int ID { get; set; }
	public string Name { get; set; }

	public static List<Department> GetAllDepartments()
	{
		return new List<Department>()
		{
			new Department { ID = 1, Name = "IT"},
			new Department { ID = 2, Name = "HR"},
		};
	}
}


public class Employee
{
	public int ID { get; set; }
	public string Name { get; set; }
	public int DepartmentID { get; set; }

	public static List<Employee> GetAllEmployees()
	{
		return new List<Employee>()
		{
			new Employee { ID = 1, Name = "Mark", DepartmentID = 1 },
			new Employee { ID = 2, Name = "Steve", DepartmentID = 2 },
			new Employee { ID = 3, Name = "Ben", DepartmentID = 1 },
			new Employee { ID = 4, Name = "Philip", DepartmentID = 1 },
			new Employee { ID = 5, Name = "Mary", DepartmentID = 2 },
		};
	}
}

// Example 1 : Cross Join Employees collection with Departments collections.
var result = from e in Employee.GetAllEmployees()
			 from d in Department.GetAllDepartments()
			 select new { e, d };

foreach (var v in result)
{
	Console.WriteLine(v.e.Name + "\t" + v.d.Name);
}

// Output: We have 5 elements in Employees collection and 2 elements in Departments collection. In the result we have 10 elements, i.e the cartesian product of the elements present in Employees and Departments collection. Notice that every element from the Employees collection is combined with every element in the Departments collection. 
// cross join in linq 

// Example 2 : Cross Join Departments collections with Employees collection
var result = from d in Department.GetAllDepartments()
			 from e in Employee.GetAllEmployees()
			 select new { e, d };

foreach (var v in result)
{
	Console.WriteLine(v.e.Name + "\t" + v.d.Name);
}

// Output: Notice that the output in this case is slightly different from Example 1. In this case, every element from the Departments collection is combined with every element in the Employees collection. 
// cross join in linq example 

// Example 3 : Rewrite Example 1 using extension method syntax

// To implement Cross Join using extension method syntax, we could either use SelectMany() method or Join() method

// Implementing cross join using SelectMany() 
var result = Employee.GetAllEmployees()
						.SelectMany(e => Department.GetAllDepartments(), (e, d) => new { e, d });

foreach (var v in result)
{
	Console.WriteLine(v.e.Name + "\t" + v.d.Name);
}

Implementing cross join using Join()
var result = Employee.GetAllEmployees()
									 .Join(Department.GetAllDepartments(),
											   e => true,
											   d => true,
											   (e, d) => new { e, d });

foreach (var v in result)
{
	Console.WriteLine(v.e.Name + "\t" + v.d.Name);
}
