// A property with only get accessor is Read only property.
// A property with only set accessor is write only property.
using System;
using System.Collections.Generic;

class employee
{
	int eid;
	string ename;

	public int employeeid
	{
		set
		{
			eid = value;
		}
		get
		{
			return eid;
		}
	}
	public string employeename
	{
		set
		{
			ename = value;
		}
		get
		{
			return ename;
		}
	}
	public void setemployee(int a, string b)
	{
		employeeid = a;
		employeename = b;
	}
}
class programmer
{
	public static void Main(string[] args)
	{
		employee e = new employee();
		e.employeeid = 2;//set value
		Console.WriteLine(e.employeeid);//get value
	}
}

class employee1
{
	int eid;
	string ename;
	public int employeeid
	{
		set
		{
			eid = value;
		}
		get
		{
			return eid;
		}
	}
	public string employeename
	{
		set
		{
			ename = value;
		}
		get
		{
			return ename;
		}
	}
	public void setemployee(int a, string b)
	{
		employeeid = a;
		employeename = b;
	}
	public string getemployee
	{
		get
		{
			return ename + eid;
		}
	}
}
class programmer1
{
	public static void Main1(string[] args)
	{
		employee1 e = new employee1();
		e.setemployee(2, "tests");
		Console.WriteLine(e.getemployee);//read only value
	}
}

public class Car
{

	public Car() { }
	private string color;
	public string a
	{
		get
		{
			return color;
		}
		set
		{
			color = value;
		}
	}


}
class Program
{
	static void Mainb(string[] args)
	{
		Car car = new Car();

		car.a = "RED";
		Console.WriteLine(car.a);
	}
}


class Employee2
{
	//prop -> double tab
	int eid;
	string ename;

	//readr/write property
	public int EID
	{
		get
		{
			return eid;
		}
		set
		{
			eid = value;
		}
	}

	public string ENAME
	{
		get
		{
			return ename;
		}
		set
		{
			ename = value;
		}
	}


	//read property
	public string GetEmployee
	{
		get
		{
			string data = string.Format("Employee ID : {0} , Employee Name : {1}", eid, ename);
			return data;
		}
	}

	public DateTime GetTime
	{
		get
		{
			return DateTime.Now;
		}
	}

}
class Program2
{
	//svm double tab
	static void Main2(string[] args)
	{
		Employee2 emp = new Employee2();
		emp.EID = 23;
		emp.ENAME = "Abhay";
		Console.WriteLine(emp.GetEmployee);
		Console.WriteLine(emp.GetTime);
	}
}

class Employee3
{
	int Age;
	public int EmpAge
	{
		get
		{
			return Age;
		}
		set
		{
			if (value > 12)
				Age = value;

		}
	}
}
class Program3
{
	//svm double tab
	static void Main3(string[] args)
	{
		Employee3 emp = new Employee3();
		emp.EmpAge = 10;
		Console.WriteLine(emp.EmpAge);
	}
}

class Employee4
{
	public int EmpID { get; set; }
	public int EmpAge { get; set; }

	public string EmpName { get; set; }

	public DateTime EmpDOJ { get; set; }


}
class Program4
{
	//svm double tab
	static void Main4(string[] args)
	{

		//first way
		Employee4 nitesh = new Employee4 { EmpID = 101, EmpName = "Nitesh", EmpAge = 21, EmpDOJ = new DateTime(2016, 11, 21) };
		Employee4 sakshi = new Employee4 { EmpID = 102, EmpName = "Sakshi", EmpAge = 22, EmpDOJ = new DateTime(2017, 12, 20) };



		//second way
		/*nitesh.EmpID = 101;
        nitesh.EmpAge = 21;
        nitesh.EmpName = "Nitesh";
        nitesh.EmpDOJ = new DateTime(2016, 11, 21);*/



	}
}

class Employee5
{
	public int EmpID { get; set; }
	public int EmpAge { get; set; }

	public string EmpName { get; set; }

	public DateTime EmpDOJ { get; set; }


}
class Program5
{
	//svm double tab
	static void Main5(string[] args)
	{

		//first way
		Employee5[] emloyees = new Employee5[2];

		Employee5 nitesh = new Employee5 { EmpID = 101, EmpName = "Nitesh", EmpAge = 21, EmpDOJ = new DateTime(2016, 11, 21) };
		Employee5 sakshi = new Employee5 { EmpID = 102, EmpName = "Sakshi", EmpAge = 22, EmpDOJ = new DateTime(2017, 12, 20) };

		emloyees[0] = nitesh;
		emloyees[1] = sakshi;

		//second way
		/*nitesh.EmpID = 101;
        nitesh.EmpAge = 21;
        nitesh.EmpName = "Nitesh";
        nitesh.EmpDOJ = new DateTime(2016, 11, 21);*/

		foreach (var emp in emloyees)
		{
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Employee ID: " + emp.EmpID);
			Console.WriteLine("Employee Age: " + emp.EmpName);
			Console.WriteLine("Employee Name: " + emp.EmpAge);
			Console.WriteLine("Employee DOJ: " + emp.EmpDOJ);

		}

	}
}


class Employee6
{
	public int EmpID { get; set; }
	public int EmpAge { get; set; }

	public string EmpName { get; set; }

	public DateTime EmpDOJ { get; set; }


}
class Program6
{
	//svm double tab
	static void Main6(string[] args)
	{

		//first way
		List<Employee6> employees = new List<Employee6>();

		Employee6 nitesh = new Employee6 { EmpID = 101, EmpName = "Nitesh", EmpAge = 21, EmpDOJ = new DateTime(2016, 11, 21) };
		Employee6 sakshi = new Employee6 { EmpID = 102, EmpName = "Sakshi", EmpAge = 22, EmpDOJ = new DateTime(2017, 12, 20) };

		employees.Add(nitesh);
		employees.Add(sakshi);

		//second way
		/*nitesh.EmpID = 101;
        nitesh.EmpAge = 21;
        nitesh.EmpName = "Nitesh";
        nitesh.EmpDOJ = new DateTime(2016, 11, 21);*/

		foreach (var emp in employees)
		{
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Employee ID: " + emp.EmpID);
			Console.WriteLine("Employee Age: " + emp.EmpName);
			Console.WriteLine("Employee Name: " + emp.EmpAge);
			Console.WriteLine("Employee DOJ: " + emp.EmpDOJ);

		}

	}
}


public class Employee7
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}
class Program7
{
	static void Main7()
	{
		Employee7 emp = new Employee7();
		emp.FirstName = "Steve";
		emp.LastName = "Smith";
		Console.WriteLine("Employee Full Name : {0} {1}", emp.FirstName, emp.LastName);
		Console.ReadKey();
	}
}
// o/p-
// Employee Full Name : Steve Smith

public class Employee8
{
	public int EmployeeId { get; set; }
	private string name { get; set; }
	private int salary { get; set; }
	public void SetName(string empName)
	{
		name = empName;
	}
	public string GetName()
	{
		return name;
	}
	public void SetSalary(int empSalary)
	{
		salary = empSalary;
	}
	public int GetSalary()
	{
		return salary;
	}
}
class Program8
{
	static void Main8(string[] args)
	{
		Employee8 emp = new Employee8();
		//following line will give you error 
		//emp.name = "Steve";
		emp.SetName("Steve");
		//following line will give you error 
		//emp.salary = 10000 
		emp.SetSalary(10000);
		Console.WriteLine("Employee Name : {0} , Salary :  {1}", emp.GetName(), emp.GetSalary());
		Console.ReadKey();
	}
}
// o/p-
// Employee Name : Steve , Salary :  10000


