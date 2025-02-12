// Events are user actions such as key press, clicks, mouse movements, etc., or some occurrence such as system generated notifications
using System;
public delegate void Handler();
class Program
{
	public static event Handler menu;

	static void Main()
	{
		menu += new Handler(Birthdays);
		menu += new Handler(Meetings);
		menu += new Handler(Reminders);

		menu.Invoke();
	}

	static void Birthdays()
	{
		Console.WriteLine("Today is Nehru's birthday");
	}

	static void Meetings()
	{
		Console.WriteLine("Today's Meetings.....");
	}

	static void Reminders()
	{
		Console.WriteLine("Remind to do ......");
	}
}
// o/p-
// Today is Nehru's birthday
// Today's Meetings.....
// Remind to do ......

class Program1
{
	static void Main1(string[] args)
	{
		TestEvent t1 = new TestEvent(2);

		//Add “ChangeNumber” event to the t1
		t1.ChangeNumber += UpdateMeWhenPropertyChange;

		t1.Number = 5;
		t1.Number = 4;

		Console.WriteLine("number =  " + t1.Number);
		Console.Read();
	}

	public static void UpdateMeWhenPropertyChange(int num)
	{
		Console.WriteLine("Event set this value " + num);
	}
}

class TestEvent
{
	private int number;

	public int Number
	{
		get
		{
			return number;
		}
		set
		{
			number = value;
			OnChanges(number);
		}
	}

	//delegate for Event
	public delegate void UpdateDelegate(int s);

	//here we declare an Event for UpdateDelegate
	public event UpdateDelegate ChangeNumber;

	public TestEvent(int num)
	{
		number = num;
		OnChanges(num);
	}

	public void OnChanges(int ss)
	{
		if (ChangeNumber != null)
		{
			Console.WriteLine("Event fired");

			//publish Event from here. 
			ChangeNumber(ss);
		}
		else
		{
			Console.WriteLine("Event Not fired");
		}
	}
}

// When the above code is compiled and executed, it produces the following result:

// Event Not fired

// Event Fired

// Event set this value 5

// Event Fired

// Event set this value 4

// number = 4