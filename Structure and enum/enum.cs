
using System;

public enum CarType
{
    Toyota = 1,
    Honda = 2,
    Ford = 3,
}

public class Tutorial
{
    public static void Main()
    {
        CarType myCarType = CarType.Toyota;
        Console.WriteLine(myCarType);
    }
}
// o/p
// Toyota

public enum School
{
    Students,
    Teachers,
    books,
    Games,
    library

}
class Program7
{
    static void MainProgram(string[] args)
    {
        School vidya = School.Teachers;
        Console.WriteLine(vidya);
        Console.ReadLine();
    }
}
// o/p-
// Teachers
// Conversion of Enum to Tostring()

public class EnumSample
{
    public enum Tutorials
    {
        csharp = 1,
        html = 2
    };

    public static void MainEnumSample()
    {
        Enum MyTutorials = Tutorials.csharp;
        Console.WriteLine("Learn tutorials in www.techfunda.com '{0}'", MyTutorials.ToString());
    }
}
// Conversion of string to enum

class Program1
{
    enum Website
    {

        techfunda = 1,
        Dotnetfunda = 2,
        itfunda = 3
    }

    static void MainWebsite()
    {

        string value = "Dotnetfunda";


        Website site = (Website)Enum.Parse(typeof(Website), value);


        if (site == Website.Dotnetfunda)
        {
            Console.WriteLine("Dotnetfunda.");
        }
    }
}
// o/p-
// Dotnetfunda
// Conversion of Enum to Integer-

public class Enum
{
    enum Months { January = 1, February, March, April, May, June, July };

    static void MainEnum()
    {
        int x = (int)Months.January;
        int y = (int)Months.May;
        Console.WriteLine("Jan = {0}", x);
        Console.WriteLine("May = {0}", y);
    }
}
// Jan = 1
// May = 5
// Conversion of Integer to Enum-

class Program2
{
    public enum Monthofyear
    {
        January = 1, February, March, April, May, June, July, August, September, October, November, December
    }

    static void MainProgram2(string[] args)
    {
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.January, Monthofyear.January);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.February, Monthofyear.February);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.March, Monthofyear.March);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.April, Monthofyear.April);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.May, Monthofyear.May);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.June, Monthofyear.June);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.July, Monthofyear.July);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.August, Monthofyear.August);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.September, Monthofyear.September);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.October, Monthofyear.October);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.November, Monthofyear.November);
        Console.WriteLine("Monthofyear {0} {1}", (int)Monthofyear.December, Monthofyear.December);

        Console.ReadLine();
    }
}
// o/p-
// Monthofyear 1 January
// Monthofyear 2 February
// Monthofyear 3 March
// Monthofyear 4 April
// Monthofyear 5 May
// Monthofyear 6 June
// Monthofyear 7 July
// Monthofyear 8 August
// Monthofyear 9 September
// Monthofyear 10 October
// Monthofyear 11 November
// Monthofyear 12 December

// num.GetNames is a string represention. which are used to represent the values of the strings.
class Program3
{
    enum Websites
    {
        Dotnetfunda,
        itfunda,
        techfunda,
        kidsfunda,
        farmingfunda,
        fundoovideo
    };

    static void MainWebsites()
    {
        string name = Enum.GetName(typeof(Websites),
            Websites.techfunda);
        Console.WriteLine(name);

        name = Enum.GetName(typeof(Websites),
            0);
        Console.WriteLine(name);
    }
}
// o/p-
// techfunda
// Dotnetfunda

class Program4
{
    enum Websites
    {
        techfunda,
        dotnetfunda,
        itfunda
    }

    static void MainProgram4()
    {
        // M("D");
        // M("d");
        // M("X");
        // M("x");
        // M("F");
        // M("f");

    }

    public static void Main(string format)
    {

        string value = Enum.Format(typeof(Websites), Websites.itfunda, format);
        Console.WriteLine("{0} = {1}", format, value);
    }
}

public enum Sports
{
    Cricket,
    Football,
    Tennis
}
class EnumSwitch
{
    static void MainEnumSwitch()
    {
        Sports Game = Sports.Football;

        switch (Game)
        {
            case Sports.Cricket:
                Console.WriteLine("Indians love cricket.");
                break;
            case Sports.Football:
                Console.WriteLine("No one shows keen interest in football in India.");
                break;
            case Sports.Tennis:
                Console.WriteLine("Tennis is popular Game.");
                break;
        }
        Console.ReadLine();
    }
}
// o/p-
// No one shows keen interest in football in India.

// operators in enum
enum Alphabets
{
    a,
    b,
    c

}

class program5
{
    public static void Main5()
    {
        Console.WriteLine(Alphabets.a + 25);
        Console.WriteLine(45 - Alphabets.c);
        Console.WriteLine(Alphabets.a == Alphabets.a);
        Console.WriteLine(Alphabets.a != Alphabets.a);
        Console.WriteLine(Alphabets.a < Alphabets.c);
        Console.WriteLine(Alphabets.a > Alphabets.c);

    }
}
// o/p-
// 25
// 43
// True
// False
// True
// Falsen

namespace EnumApplication
{
    class EnumProgram
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void MainEnumProgram(string[] args)
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.ReadKey();
        }
    }
}
// o/p-
// Monday: 1
// Friday: 5