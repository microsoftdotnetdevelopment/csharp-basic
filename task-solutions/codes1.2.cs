using System;

class Tasks
{
   
    public static void AllConversions()
    {
        // 1.Accept the distance in Km and convert it into meters .
        int num = Convert.ToInt32(Console.ReadLine());
        int in_metre = num * 1000;
        Console.WriteLine(in_metre);
        // or

        String a = Console.ReadLine();
        int num1 = int.Parse(a);
        int in_meter = num1 * 1000;
        Console.WriteLine(in_meter);

        // 2.Accept the speed in kmph(kilometer per hour) and convert it into mps(meter per second).
        String a1 = Console.ReadLine();
        float num2 = float.Parse(a1);
        float mps = (num2 * 5) / 18;
        Console.WriteLine(mps);

        // 3.Accept temperature in celcius and display it in farenhite .
        String a2 = Console.ReadLine();
        float c = float.Parse(a2);
        float f = ((9 * c) / 5) + 32;
        Console.WriteLine(f);

        // 4.Accept the dimensions of rectangle like length and width and calculate the area and perimeter.
        String a3 = Console.ReadLine();
        String b = Console.ReadLine();
        int l = int.Parse(a3);
        int w = int.Parse(b);
        int area = l * w;
        int para = 2 * (l + w);
        Console.WriteLine("area is " + area);
        Console.WriteLine("PArameter is " + para);

        // 5.Accept the three numbers and calculate its addition, subtraction, product and divisions.
        String a4 = Console.ReadLine();
        String b1 = Console.ReadLine();
        String c1 = Console.ReadLine();
        int d = int.Parse(a4);
        int e = int.Parse(b1);
        int f1 = int.Parse(c1);
        int sum = d + e + f1;
        int sub = d - e - f1;
        int mul = d * e * f1;
        int div = d / e;
        Console.WriteLine(sum);
        Console.WriteLine(sub);
        Console.WriteLine(mul);
        Console.WriteLine(div);
    }

    public static void AllConversions2()
    {
        // 6.Accept the character and display it's ascii value.
        string str = Console.ReadLine();
        for (int ii = 0; ii < str.Length; ii++)
            Console.Write(((int)str[ii]).ToString());
        // or
        char ch = char.Parse(Console.ReadLine());

        int i = (int)ch;
        Console.WriteLine(i);
        Console.ReadKey();  //to hold window
                            // 7.Accept the ascii value and display its equvilant character.
        int wer = int.Parse(Console.ReadLine());
        char n = (char)wer;
        Console.WriteLine(n);
        Console.ReadKey();
    }

    public static void Fromatting()
    {


        // 8.Accept the details of employee like employee id,employee name, employee city , employee Gender , employee mobile , employee basic salary and display in the below format :

        // -----------------------------------------------Employee Details------------------------------------------------
        // |	Employee ID : 101
        // |	Employee Name : Deepak
        // |	Employee City : Delhi
        // |	Employee Gender : M
        // |	Employee Mobile : 8887412457
        // |	Employee Basic Salary : 18000
        // |	Employee Allowances  : 4000
        // |	Employee Meal Deduction : 5%
        // |	Employee Total Salary : (Calculate yourself)
        // ----------------------------------------------------------------------------------------------------------------

        // Note : Calculate Total salary by formula :
        // 	Basic Salary + Allowance - 5% of Basic Salary


        const int Allowances = 4000;
        const int Meal = 5;
        String a = Console.ReadLine();
        String b = Console.ReadLine();
        String c = Console.ReadLine();
        String d = Console.ReadLine();
        String e = Console.ReadLine();
        String f = Console.ReadLine();



        int basic_salary = int.Parse(f);
        int ta = (5 * basic_salary) / 100;
        int total_salary = basic_salary + Allowances - ta;
        Console.WriteLine("---------------------------------------------- - Employee Details------------------------------------------------");
        Console.WriteLine("|            Employee ID : " + a);
        Console.WriteLine("|            Employee Name : " + b);
        Console.WriteLine("|            Employee City : " + c);
        Console.WriteLine("|            Employee Gender: " + d);
        Console.WriteLine("|            Employee Mobile : " + e);
        Console.WriteLine("|            Employee Basic Salary : " + basic_salary);
        Console.WriteLine("|            Employee Allowances  : " + Allowances);
        Console.WriteLine("|            Employee Meal Deduction : " + Meal);
        Console.WriteLine("|            Employee Total Salary : " + total_salary);
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
    }

    public static void CDvf()
    {
        // 9.Accept  Principal , Rate of interest and Time in years and calculate the Simple interest and Compound interest.
        String a = Console.ReadLine();
        String b = Console.ReadLine();
        String c = Console.ReadLine();
        int p = int.Parse(a);
        int i = int.Parse(b);
        int t = int.Parse(c);
        float simple = (p * i * t) / 100;
        Console.WriteLine(simple);

        // 10.Implement the pythagoras theorem by taking two sides and calculate the third side .use Math.Sqrt() method for finding the square root for e.g. Math.Sqrt(64) to find the square root of 64.  
        String a6 = Console.ReadLine();
        String b6 = Console.ReadLine();
        double c6 = double.Parse(a6);
        double d = double.Parse(b6);
        double e = c6 * c6;
        double f = d * d;
        double g = e + f;
        double third = Math.Sqrt(g);
        Console.WriteLine(third);
        // to use sqrt function you need to take double datatype;   
    }

    public static void Main()
    {

    }
}
















