// OrderBy, OrderByDescending, ThenBy, and ThenByDescending can be used to sort data. Reverse method simply reverses the items in a given collection.

public class Student
{
	public int StudentID { get; set; }
	public string Name { get; set; }
	public int TotalMarks { get; set; }

	public static List<Student> GetAllStudents()
	{
		List<Student> listStudents = new List<Student>
		{
			new Student
			{
				StudentID= 101,
				Name = "Tom",
				TotalMarks = 800
			},
			new Student
			{
				StudentID= 102,
				Name = "Mary",
				TotalMarks = 900
			},
			new Student
			{
				StudentID= 103,
				Name = "Valarie",
				TotalMarks = 800
			},
			new Student
			{
				StudentID= 104,
				Name = "John",
				TotalMarks = 800
			},
		};

		return listStudents;
	}
}

// Example 1: Sort Students by Name in ascending order
IEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.Name);
foreach (Student student in result)
{
	Console.WriteLine(student.Name);
}

// Output: 
// orderby linq c# 

// Example 2: Rewrite Example 1 using SQL like syntax
IEnumerable<Student> result = from student in Student.GetAllStudents()
							  orderby student.Name
							  select student;

foreach (Student student in result)
{
	Console.WriteLine(student.Name);
}

// Output:
// Same as in Example 1

// Example 3: Sort Students by Name in descending order
IEnumerable<Student> result = Student.GetAllStudents().OrderByDescending(s => s.Name);
foreach (Student student in result)
{
	Console.WriteLine(student.Name);
}

// Output: 
// orderbydescending linq example 

// Example 4: Rewrite Example 3 using SQL like syntax
IEnumerable<Student> result = from student in Student.GetAllStudents()
							  orderby student.Name descending
							  select student;

foreach (Student student in result)
{
	Console.WriteLine(student.Name);
}

// If want to sort by more than one value or expression, that's when we use ThenBy or ThenByDescending along with OrderBy or OrderByDescending.
// OrderBy or OrderByDescending performs the primary sort. ThenBy or ThenByDescending is used for adding secondary sort. Secondary Sort operators 
IEnumerable<Student> result = Student.GetAllStudetns()
	.OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenBy(s => s.StudentID);
foreach (Student student in result)
{
	Console.WriteLine(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
}

// or

IEnumerable<Student> result = from student in Student.GetAllStudetns()
							  orderby student.TotalMarks, student.Name, student.StudentID
							  select student;
foreach (Student student in result)
{
	Console.WriteLine(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
}

// Reverses the items in the collection. 

IEnumerable<Student> students = Student.GetAllStudetns();

Console.WriteLine("Before calling Reverse");
foreach (Student s in students)
{
	Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
}

Console.WriteLine();
IEnumerable<Student> result = students.Reverse();

Console.WriteLine("After calling Reverse");
foreach (Student s in result)
{
	Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
}