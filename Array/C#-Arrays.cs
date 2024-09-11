using System;
using System.Linq;



class TestArraysClass
{
	static void Main()
	{
		// Declare a single-dimensional array 
		int[] array1 = new int[5];

		// Declare and set array element values
		int[] array2 = new int[] { 1, 3, 5, 7, 9 };

		// Alternative syntax
		int[] array3 = { 1, 2, 3, 4, 5, 6 };

		// Declare a two dimensional array
		int[,] multiDimensionalArray1 = new int[2, 3];

		// Declare and set array element values
		int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

		// Declare a jagged array
		int[][] jaggedArray = new int[6][];

		// Set the values of the first array in the jagged array structure
		jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

		//A string array can be initialized in the same way.
		string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

		System.Console.WriteLine(weekDays[0]);
	}

	static void ImplicitlyTypedArraySample()
	{
		var a = new[] { 1, 10, 100, 1000 }; // int[]
		var b = new[] { "hello", null, "world" }; // string[]

		// single-dimension jagged array
		var c = new[]
{
				new[]{1,2,3,4},
				new[]{5,6,7,8}
			};

		// jagged array of strings
		var d = new[]
{
				new[]{"Luca", "Mads", "Luke", "Dinesh"},
				new[]{"Karen", "Suma", "Frances"}
			};
		// In the previous example, notice that with implicitly-typed arrays, no square brackets are used on the left side of the initialization statement. Note also that jagged arrays are initialized by using new [] just like single-dimension arrays.

		// 19. When you create an anonymous type that contains an array, the array must be implicitly typed in the type's object initializer. In the following example, contacts is an implicitly-typed array of anonymous types, each of which contains an array named PhoneNumbers. Note that the var keyword is not used inside the object initializers.

		var contacts = new[]
				   {
				new {
						Name = " Eugene Zabokritski",
						PhoneNumbers = new[] { "206-555-0108", "425-555-0001" }
					},
				new {
						Name = " Hanying Feng",
						PhoneNumbers = new[] { "650-555-0199" }
					}
			};



	}





	public static void CreateInstanceandSetValue()
	{
		Array my1DArray = Array.CreateInstance(typeof(Int32), 5);
		for (int i = my1DArray.GetLowerBound(0); i <= my1DArray.GetUpperBound(0); i++)
			my1DArray.SetValue(i + 1, i);
	}

	static void TestArraysClass1()
	{
		// 32. This example uses the Rank property to display the number of dimensions of an array.
		// Declare and initialize an array:
		int[,] theArray = new int[5, 10];
		System.Console.WriteLine("The array has {0} dimensions.", theArray.Rank);
	}
	// Output: The array has 2 dimensions.
	// 33.Arrays can be passed as arguments to method parameters. Because arrays are reference types, the method can change the value of the elements:

}

class ArrayClass
{
	static void PrintArray(string[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			System.Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : "");
		}
		System.Console.WriteLine();
	}

	static void ChangeArray(string[] arr)
	{
		// The following attempt to reverse the array does not persist when
		// the method returns, because arr is a value parameter.
		arr = (arr.Reverse()).ToArray();
		// The following statement displays Sat as the first element in the array.
		System.Console.WriteLine("arr[0] is {0} in ChangeArray.", arr[0]);
	}

	static void ChangeArrayElements(string[] arr)
	{
		// The following assignments change the value of individual array 
		// elements. 
		arr[0] = "Sat";
		arr[1] = "Fri";
		arr[2] = "Thu";
		// The following statement again displays Sat as the first element
		// in the array arr, inside the called method.
		System.Console.WriteLine("arr[0] is {0} in ChangeArrayElements.", arr[0]);
	}

	static void ArrayClass1()
	{
		// Declare and initialize an array.
		string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

		// Pass the array as an argument to PrintArray.
		PrintArray(weekDays);

		// ChangeArray tries to change the array by assigning something new
		// to the array in the method. 
		ChangeArray(weekDays);

		// Print the array again, to verify that it has not been changed.
		System.Console.WriteLine("Array weekDays after the call to ChangeArray:");
		PrintArray(weekDays);
		System.Console.WriteLine();

		// ChangeArrayElements assigns new values to individual array
		// elements.
		ChangeArrayElements(weekDays);

		// The changes to individual elements persist after the method returns.
		// Print the array, to verify that it has been changed.
		System.Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
		PrintArray(weekDays);
	}
	// Output: 
	// Sun Mon Tue Wed Thu Fri Sat
	// arr[0] is Sat in ChangeArray.
	// Array weekDays after the call to ChangeArray:
	// Sun Mon Tue Wed Thu Fri Sat
	// 
	// arr[0] is Sat in ChangeArrayElements.
	// Array weekDays after the call to ChangeArrayElements:
	// Sat Fri Thu Wed Thu Fri Sat

	static void ArraysDeclar()
	{
		// Multi - Dimensional Array:

		// Two-dimensional array.
		int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
		// The same array with dimensions specified.
		int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
		// A similar array with string elements.
		string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
												{ "five", "six" } };

		// Three-dimensional array.
		int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
										 { { 7, 8, 9 }, { 10, 11, 12 } } };
		// The same array with dimensions specified.
		int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
											   { { 7, 8, 9 }, { 10, 11, 12 } } };

		// Accessing array elements.
		System.Console.WriteLine(array2D[0, 0]);
		System.Console.WriteLine(array2D[0, 1]);
		System.Console.WriteLine(array2D[1, 0]);
		System.Console.WriteLine(array2D[1, 1]);
		System.Console.WriteLine(array2D[3, 0]);
		System.Console.WriteLine(array2Db[1, 0]);
		System.Console.WriteLine(array3Da[1, 0, 1]);
		System.Console.WriteLine(array3D[1, 1, 2]);

		// Getting the total count of elements or the length of a given dimension.
		var allLength = array3D.Length;
		var total = 1;
		for (int i = 0; i < array3D.Rank; i++)
		{
			total *= array3D.GetLength(i);
		}
		System.Console.WriteLine("{0} equals {1}", allLength, total);

		// Output:
		// 1
		// 2
		// 3
		// 4
		// 7
		// three
		// 8
		// 12
		// 12 equals 12
	}

	static void JaggedArray()
	{
		// Declare the array of two elements:
		int[][] arr = new int[2][];

		// Initialize the elements:
		arr[0] = new int[5] { 1, 3, 5, 7, 9 };
		arr[1] = new int[4] { 2, 4, 6, 8 };

		// Display the array elements:
		for (int i = 0; i < arr.Length; i++)
		{
			System.Console.Write("Element({0}): ", i);

			for (int j = 0; j < arr[i].Length; j++)
			{
				System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
			}
			System.Console.WriteLine();
		}
		// Keep the console window open in debug mode.
		System.Console.WriteLine("Press any key to exit.");
		System.Console.ReadKey();
	}
	/* Output:
    Element(0): 1 3 5 7 9
    Element(1): 2 4 6 8
*/

	static void UsingForeachWithArrays()
	{
		// C# also provides the foreach statement. This statement provides a simple, clean way to iterate through the elements of an array or any enumerable collection. The foreach statement processes elements in the order returned by the array or collection type’s enumerator, which is usually from the 0th element to the last. For example, the following code creates an array called numbers and iterates through it with the foreach statement:

		int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
		foreach (int i in numbers)
		{
			System.Console.Write("{0} ", i);
		}
		// Output: 4 5 6 1 2 3 -2 -1 0


		// With multidimensional arrays, you can use the same method to iterate through the elements, for example:



		int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
		// Or use the short form:
		// int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

		foreach (int i in numbers2D)
		{
			System.Console.Write("{0} ", i);
		}
		// Output: 9 99 3 33 5 55





	}

}



class TestOut
{
	// Passing Arrays as out
	static void FillArray(out int[] arr)
	{
		// Initialize the array:
		arr = new int[5] { 1, 2, 3, 4, 5 };
	}

	static void Main1()
	{
		int[] theArray; // Initialization is not required

		// Pass the array to the callee using out:
		FillArray(out theArray);

		// Display the array elements:
		System.Console.WriteLine("Array elements are:");
		for (int i = 0; i < theArray.Length; i++)
		{
			System.Console.Write(theArray[i] + " ");
		}

		// Keep the console window open in debug mode.
		System.Console.WriteLine("Press any key to exit.");
		System.Console.ReadKey();
	}
}
/* Output:
	Array elements are:
	1 2 3 4 5        
*/

// In this example, the array theArray is initialized in the caller (the Main method), and passed to the FillArray method by using the ref parameter.Some of the array elements are updated in the FillArray method. Then, the array elements are returned to the caller and displayed.

class TestRef
{
	// Passing Array as ref
	static void FillArray(ref int[] arr)
	{
		// Create the array on demand:
		if (arr == null)
		{
			arr = new int[10];
		}
		// Fill the array:
		arr[0] = 1111;
		arr[4] = 5555;
	}

	static void Main2()
	{
		// Initialize the array:
		int[] theArray = { 1, 2, 3, 4, 5 };

		// Pass the array using ref:
		FillArray(ref theArray);

		// Display the updated array:
		System.Console.WriteLine("Array elements are:");
		for (int i = 0; i < theArray.Length; i++)
		{
			System.Console.Write(theArray[i] + " ");
		}

		// Keep the console window open in debug mode.
		System.Console.WriteLine("Press any key to exit.");
		System.Console.ReadKey();
	}



	/* Output:
		Array elements are:
		1111 2 3 4 5555
	*/
}



