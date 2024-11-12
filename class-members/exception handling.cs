
using System;
public class ExceptionHandlingAbuse
{
	public static void Main()
	{
		try
		{
			Console.WriteLine("Please enter Numerator");
			int Numerator = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("Please enter Denominator");
			//Convert.ToInt32() can throw FormatException, if the entered value
			//cannot be converted to integer. So use int.TryParse() instead
			int Denominator = Convert.ToInt32(Console.ReadLine());


			int Result = Numerator / Denominator;


			Console.WriteLine("Result = {0}", Result);
		}
		catch (FormatException)
		{
			Console.WriteLine("Only numbers are allowed!");
		}
		catch (OverflowException)
		{
			Console.WriteLine("Only numbers between {0} & {1} are allowed",
				Int32.MinValue, Int32.MaxValue);


		}
		catch (DivideByZeroException)
		{
			Console.WriteLine("Denominator cannot be zero");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static void Main22()
	{
		int[] numbers = new int[2];
		try
		{
			numbers[0] = 23;
			numbers[1] = 32;
			numbers[2] = 42;

			foreach (int i in numbers)
				Console.WriteLine(i);
		}
		catch (IndexOutOfRangeException ex)
		{
			Console.WriteLine("An index was out of range!");
		}
		catch (Exception ex)
		{
			Console.WriteLine("Some sort of error occured: " + ex.Message);
		}
		finally
		{
			Console.WriteLine("It's the end of our try block. Time to clean up!");
		}
		Console.ReadLine();
	}

}

