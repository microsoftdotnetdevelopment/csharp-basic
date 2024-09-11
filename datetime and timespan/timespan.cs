
using System;
class Pro
{
	static void Main(string[] args)
	{

		TimeSpan span = new TimeSpan(3, 2, 10, 30, 25);//day , hour, minutes, seconds, and milliseconds, 
		Console.WriteLine(span);
	}

}
// o/p-
// 3.02:10:30.0250000

class Program1
{
	static void Main1()
	{
		TimeSpan span1 = TimeSpan.FromDays(20);
		TimeSpan span2 = TimeSpan.FromHours(11);
		TimeSpan span3 = TimeSpan.FromMinutes(46);
		TimeSpan span4 = TimeSpan.FromSeconds(58);
		TimeSpan span5 = TimeSpan.FromMilliseconds(59);

		Console.WriteLine(span1);
		Console.WriteLine(span2);
		Console.WriteLine(span3);
		Console.WriteLine(span4);
		Console.WriteLine(span5);
	}
}
// o/p-
// 20.00:00:00
// 11:00:00
// 00:46:00
// 00:00:58
// 00:00:00.0590000

class Program2
{
	static void Main2()
	{

		TimeSpan span1 = TimeSpan.FromHours(6);
		TimeSpan span2 = TimeSpan.FromMinutes(34);
		TimeSpan span3 = span1.Add(span2);
		Console.WriteLine(span3);
	}
}
// o/p-
// 06:34:00



