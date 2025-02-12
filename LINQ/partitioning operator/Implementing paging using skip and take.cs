using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
	public int StudentID { get; set; }
	public string Name { get; set; }
	public int TotalMarks { get; set; }

	public static List<Student> GetAllStudetns()
	{
		List<Student> listStudents = new List<Student>
		{
			new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
			new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
			new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 },
			new Student { StudentID= 104, Name = "John", TotalMarks = 800 },
			new Student { StudentID= 105, Name = "John", TotalMarks = 800 },
			new Student { StudentID= 106, Name = "Brian", TotalMarks = 700 },
			new Student { StudentID= 107, Name = "Jade", TotalMarks = 750 },
			new Student { StudentID= 108, Name = "Ron", TotalMarks = 850 },
			new Student { StudentID= 109, Name = "Rob", TotalMarks = 950 },
			new Student { StudentID= 110, Name = "Alex", TotalMarks = 750 },
			new Student { StudentID= 111, Name = "Susan", TotalMarks = 860 },
		};

		return listStudents;
	}
}



namespace Demo
{
	class Program
	{
		public static void Main()
		{
			IEnumerable<Student> students = Student.GetAllStudetns();

			do
			{
				Console.WriteLine("Please enter Page Number - 1,2,3 or 4");
				int pageNumber = 0;

				if (int.TryParse(Console.ReadLine(), out pageNumber))
				{
					if (pageNumber >= 1 && pageNumber <= 4)
					{
						int pageSize = 3;
						IEnumerable<Student> result = students
													 .Skip((pageNumber - 1) * pageSize).Take(pageSize);

						Console.WriteLine();
						Console.WriteLine("Displaying Page " + pageNumber);
						foreach (Student student in result)
						{
							Console.WriteLine(student.StudentID + "\t" +
																		student.Name + "\t" + student.TotalMarks);
						}
						Console.WriteLine();
					}
					else
					{
						Console.WriteLine("Page number must be an integer between 1 and 4");
					}
				}
				else
				{
					Console.WriteLine("Page number must be an integer between 1 and 4");
				}
			} while (1 == 1);
		}
	}
}