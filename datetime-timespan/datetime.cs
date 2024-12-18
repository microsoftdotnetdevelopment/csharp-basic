
using System;
class Program
{
	static void Main(string[] args)
	{
		DateTime fooDate = DateTime.Now;
		Console.WriteLine(fooDate.ToString("hh:mm, dd MMM yyyy"));
	}
}
// o/p
// 01:49, 12 Feb 2017

class Program1
{
	static void Main1()
	{
		DateTime time = DateTime.Now;
		string format = "MMMM dddd d HH:mm yyyy";
		Console.WriteLine(time.ToString(format));
	}
	// o/p-
	// February Sunday 12 14:13 2017
}

class Program2
{
	static void Main2()
	{

		DateTime now = DateTime.Now;
		Console.WriteLine(now.ToLongDateString());
		Console.WriteLine(now.ToLongTimeString());
		Console.WriteLine(now.ToShortDateString());
		Console.WriteLine(now.ToShortTimeString());
		Console.WriteLine(now.ToString());

	}
}
// o/p-
// 12 February 2017
// 14:14:18
// 12-02-2017
// 02:14 PM
// 12-02-2017 14:14:18

class Program3
{
	static void Main3()
	{
		DateTime now = DateTime.Today;
		for (int i = 0; i < 7; i++)
		{
			Console.WriteLine(now.ToString("dddd"));
			now = now.AddDays(1);
		}
	}
}
// o/p-
// Sunday
// Monday
// Tuesday
// Wednesday
// Thursday
// Friday
// Saturday

class Program4
{
	static void Main4()
	{

		DateTime now = DateTime.Now;
		for (int i = 0; i < 2; i++)
		{
			Console.WriteLine(now.ToString("tt "));
			now = now.AddHours(12);
		}
	}
}
// o/p-
// PM
// AM
class Program5
{
	static void Main5()
	{
		DateTime date = new DateTime(2013, 6, 23);
		Console.WriteLine("Some Date Formats : ");
		Console.WriteLine("Date and Time:  {0}", date);
		Console.WriteLine(date.ToString("yyyy-MM-dd"));
		Console.WriteLine(date.ToString("dd-MMM-yy"));
		Console.WriteLine(date.ToString("M/d/yyyy"));
		Console.WriteLine(date.ToString("M/d/yy"));
		Console.WriteLine(date.ToString("MM/dd/yyyy"));
		Console.WriteLine(date.ToString("MM/dd/yy"));
		Console.WriteLine(date.ToString("yy/MM/dd"));
		string strDate = date.ToString("M");
		Console.WriteLine("Month and Date :  {0}", strDate);
	}
}
// o/p-
// Some Date Formats :
// Date and Time:  23-06-2013 00:00:00
// 2013-06-23
// 23-Jun-13
// 6-23-2013
// 6-23-13
// 06-23-2013
// 06-23-13
// 13-06-23
// Month and Date :  23 June
class Program6
{
	static void Main6()
	{
		DateTime date = new DateTime(2013, 6, 23);
		string strDate = date.ToString("M");
		Console.WriteLine("Month and Date :  {0}", strDate);
	}
}
// o/p-
// Month and Date :  23 June

