// Projection Operators (Select & SelectMany) are used to transform the results of a query.
// Select clause in SQL allows to specify what columns we want to retrieve. 
// In a similar fashion LINQ SELECT standard query operator allows us to specify what properties we want to retrieve. It also allows us to perform calculations.
// Select operator is used to select value from a collection and SelectMany operator is used to select values from a collection of collection i.e. nested collection

public class Employee
{
	public int EmployeeID { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Gender { get; set; }
	public int AnnualSalary { get; set; }

	public static List<Employee> GetAllEmployees()
	{
		List<Employee> listEmployees = new List<Employee>
		{
			new Employee
			{
				EmployeeID = 101,
				FirstName = "Tom",
				LastName = "Daely",
				Gender = "Male",
				AnnualSalary = 60000
			},
			new Employee
			{
				EmployeeID = 102,
				FirstName = "Mike",
				LastName = "Mist",
				Gender = "Male",
				AnnualSalary = 72000
			},
			new Employee
			{
				EmployeeID = 103,
				FirstName = "Mary",
				LastName = "Lambeth",
				Gender = "Female",
				AnnualSalary = 48000
			},
			new Employee
			{
				EmployeeID = 104,
				FirstName = "Pam",
				LastName = "Penny",
				Gender = "Female",
				AnnualSalary = 84000
			},
		};

		return listEmployees;
	}
}
// Program.cs-
// Retrieves just the EmployeeID property of all employees
IEnumerable<int> employeeIds = Employee.GetAllEmployees()
	.Select(emp => emp.EmployeeID);
foreach (int id in employeeIds)
{
	Console.WriteLine(id);
}


public class Student
{
	public string Name { get; set; }
	public string Gender { get; set; }
	public List<string> Subjects { get; set; }

	public static List<Student> GetAllStudetns()
	{
		List<Student> listStudents = new List<Student>
		{
			new Student
			{
				Name = "Tom",
				Gender = "Male",
				Subjects = new List<string> { "ASP.NET", "C#" }
			},
			new Student
			{
				Name = "Mike",
				Gender = "Male",
				Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
			},
			new Student
			{
				Name = "Pam",
				Gender = "Female",
				Subjects = new List<string> { "WCF", "SQL Server", "C#" }
			},
			new Student
			{
				Name = "Mary",
				Gender = "Female",
				Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
			},
		};

		return listStudents;
	}
}

IEnumerable<string> allSubjects = Student.GetAllStudetns().SelectMany(s => s.Subjects);          //using lambda expression-1
or
IEnumerable<string> allSubjects = from student in Student.GetAllStudetns()                       //using sql query like syntax-1
								  from subject in student.Subjects
								  select subject;
foreach (string subject in allSubjects)
{
	Console.WriteLine(subject);
}

// Selects only the distinct subjects--
IEnumerable<string> allSubjects = Student.GetAllStudetns().SelectMany(s => s.Subjects).Distinct();
// or
IEnumerable<string> allSubjects = (from student in Student.GetAllStudetns()
								   from subject in student.Subjects
								   select subject).Distinct();
foreach (string subject in allSubjects)
{
	Console.WriteLine(subject);
}

// Selects student name along with all the subjects--
var result = Student.GetAllStudetns().SelectMany(s => s.Subjects, (student, subject) =>
	new { StudentName = student.Name, Subject = subject });
// or
var result = from student in Student.GetAllStudetns()
			 from subject in student.Subjects
			 select new { StudnetName = student.Name, Subject = subject };
foreach (var v in result)
{
	Console.WriteLine(v.StudentName + " - " + v.Subject);
}

string[] stringArray =
{
	"ABCDEFGHIJKLMNOPQRSTUVWXYZ",
	"0123456789"
};

IEnumerable<char> result = stringArray.SelectMany(s => s);      //1st way
																// or
Enumerable<char> result = from s in stringArray                  //2nd way
						  from c in s
						  select c;

foreach (char c in result)
{
	Console.WriteLine(c);
}

