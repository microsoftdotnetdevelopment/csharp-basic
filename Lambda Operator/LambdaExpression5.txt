using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }

        static void Main(string[] args)
        {
           
            // passing Student type as parameter type and return type is bool ,, below delegate is checking for student age is greater than 18 or not..
            Func<Student, bool> teenager = s => s.StudentAge > 18;
            bool result = teenager(new Student { StudentID= 101, StudentName="Deepak", StudentAge=20 });
            Console.WriteLine(result);
 
        }
    }
}
