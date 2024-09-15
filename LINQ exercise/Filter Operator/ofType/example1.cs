using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinqExamples
{
	class Student
	{
		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int StudentAge { get; set; }

		static void Main(string[] args)
		{

			ArrayList list = new ArrayList();
			list.Add(1);
			list.Add("India");
			list.Add("Australia");
			list.Add(new Student { StudentID = 101, StudentAge = 21, StudentName = "Sumit" });
			list.Add(4);
			list.Add("China");

			var countries = list.OfType<string>();
			var students = list.OfType<Student>();

			foreach (var c in countries)
				Console.WriteLine(c);

			foreach (var s in students)
				Console.WriteLine(s.StudentName);
		}
	}
}
// o/p-
// India
// Australia
// China
// Sumit
