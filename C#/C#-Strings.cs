
using System;
using System.IO;
using System.Text;
using static System.String;

public class StringsAndIndexes
{
	public static void DeclaringInitializingStrings()
	{

		// You can declare and initialize strings in various ways, as shown in the following example:

		// Declare without initializing.
		string message1;

		// Initialize to null.
		string message2 = null;

		// Initialize as an empty string.
		// Use the Empty constant instead of the literal "".
		string message3 = System.String.Empty;

		//Initialize with a regular string literal.
		string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

		// Initialize with a verbatim string literal.
		string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

		// Use System.String if you prefer.
		System.String greeting = "Hello World!";

		// In local variables (i.e. within a method body)
		// you can use implicit typing.
		var temp = "I'm still a strongly-typed System.String!";

		// Use a const string to prevent 'message4' from
		// being used to store another string value.
		const string message4 = "You can't get rid of me!";

		// Use the String constructor only when creating
		// a string from a char*, char[], or sbyte*. See
		// System.String documentation for details.
		char[] letters = { 'A', 'B', 'C' };
		string alphabet = new string(letters);

		// Note that you do not use the new operator to create a string object except when initializing the string with an array of chars.
		// Initialize a string with the Empty constant value to create a new String object whose string is of zero length. The string literal representation of a zero-length string is "". By initializing strings with the Empty value instead of null, you can reduce the chances of a NullReferenceException occurring. Use the static IsNullOrEmpty(String) method to verify the value of a string before you try to access it.


		// Although string is a reference type, the equality operators (== and !=) are defined to compare the values of string objects, not references. This makes testing for string equality more intuitive. For example:

		string a = "hello";
		string b = "h";
		// Append to contents of 'b'
		b += "ello";
		Console.WriteLine(a == b);
		Console.WriteLine((object)a == (object)b);

		// This displays "True" and then "False" because the content of the strings are equivalent, but a and b do not refer to the same string instance.
	}

	public static void ImmutabilityStringObjects()
	{
		// String objects are immutable: they cannot be changed after they have been created. All of the String methods and C# operators that appear to modify a string actually return the results in a new string object. In the following example, when the contents of s1 and s2 are concatenated to form a single string, the two original strings are unmodified. The += operator creates a new string that contains the combined contents. That new object is assigned to the variable s1, and the original object that was assigned to s1 is released for garbage collection because no other variable holds a reference to it.

		string sz = "A string is more ";
		string sa = "than the sum of its chars.";

		// Concatenate sz and sa. This actually creates a new
		// string object and stores it in s1, releasing the
		// reference to the original object.
		sz += sa;

		System.Console.WriteLine(sz);
		// Output: A string is more than the sum of its chars.


		// Because a string "modification" is actually a new string creation, you must use caution when you create references to strings. If you create a reference to a string, and then "modify" the original string, the reference will continue to point to the original object instead of the new object that was created when the string was modified. The following code illustrates this behavior:

		string s1 = "Hello ";
		string sn = s1;
		s1 += "World";

		System.Console.WriteLine(sn);
		//Output: Hello
	}

	public static void Verbatimstringliterals()
	{


		// Use verbatim strings for convenience and better readability when the string text contains backslash characters, for example in file paths. Because verbatim strings preserve new line characters as part of the string text, they can be used to initialize multiline strings. Use double quotation marks to embed a quotation mark inside a verbatim string. The following example shows some common uses for verbatim strings.Verbatim string literals start with @ and are also enclosed in double quotation marks. See the example below :

		string s1 = "The path is C:\\PublicDocuments\\Report1.doc";
		Console.WriteLine(s1);
		//output : The path is C:\PublicDocuments\Report1.doc

		string sc = @"The path is C:\PublicDocuments\Report1.doc";
		Console.WriteLine(sc);
		//output : The path is C:\PublicDocuments\Report1.doc      

		// Note :At compile time, verbatim strings are converted to ordinary strings with all the same escape sequences. Therefore, if you view a verbatim string in the debugger watch window, you will see the escape characters that were added by the compiler, not the verbatim version from your source code. For example, the verbatim string @"C:\files.txt" will appear in the watch window as "C:\\files.txt".

	}

	public static void Main()
	{
		string s1 = "This string consists of a single short sentence.";
		int nWords = 0;

		s1 = s1.Trim();
		for (int ctr = 0; ctr < s1.Length; ctr++)
		{
			if (Char.IsPunctuation(s1[ctr]) | Char.IsWhiteSpace(s1[ctr]))
				nWords++;
		}
		Console.WriteLine("The sentence\n   {0}\nhas {1} words.",
						  s1, nWords);
	}
	// Note :  Because the String class implements the IEnumerable interface, you can also iterate through the Char objects in a string by using a foreach construct, as the following example shows.

	public static void Main1()
	{
		string s1 = "This string consists of a single short sentence.";
		int nWords = 0;

		s1 = s1.Trim();
		foreach (var ch in s1)
		{
			if (Char.IsPunctuation(ch) | Char.IsWhiteSpace(ch))
				nWords++;
		}
		Console.WriteLine("The sentence\n   {0}\nhas {1} words.",
						  s1, nWords);
	}
	// The example displays the following output:
	//       The sentence
	//          This string consists of a single short sentence.
	//       has 8 words.

	public static void NullandEmptystrings()
	{



		// The String class includes the following two convenience methods that enable you to test whether a string is null or empty:

		// A. IsNullOrEmpty, which indicates whether a string is either null or is equal to String.Empty. This method eliminates the need to use code such as the following: 
		string str = "vdf";
		if (str == null || str.Equals(String.Empty))   // first way to check 
		{
			str = "d";
			Console.WriteLine(str);
			Console.ReadKey();
		}
		if (IsNullOrEmpty(str))  // second way to check which eliminates the first.
		{
			Console.WriteLine(str);
		}


		// B. IsNullOrWhiteSpace, which indicates whether a string is null, equals String.Empty, or consists exclusively of white-space characters. This method eliminates the need to use code such as the following:

		if (str == null || str.Equals(String.Empty) || str.Trim().Equals(String.Empty)) // frist way to check
		{

		}
		if (IsNullOrWhiteSpace(str)) // second way to check which eliminates the first way
		{

		}

	}
	// Consider the below two examples , one example id doing the same task by using string class and second is doing through StringBuilder

	public static void ImmutabilityandStringBuilder()
	{
		Random rnd = new Random();

		string str = String.Empty;
		StreamWriter sw = new StreamWriter(@".\StringFile.txt",
							 false, Encoding.Unicode);

		for (int ctr = 0; ctr <= 1000; ctr++)
		{
			str += Convert.ToChar(rnd.Next(1, 0x0530));
			if (str.Length % 60 == 0)
				str += Environment.NewLine;
		}
		sw.Write(str);
		sw.Close();
	}

	public static void StringBuilderMethod()
	{
		Random rnd = new Random();
		StringBuilder sb = new StringBuilder();
		StreamWriter sw = new StreamWriter(@".\StringFile.txt",
										   false, Encoding.Unicode);

		for (int ctr = 0; ctr <= 1000; ctr++)
		{
			sb.Append(Convert.ToChar(rnd.Next(1, 0x0530)));
			if (sb.Length % 60 == 0)
				sb.AppendLine();
		}
		sw.Write(sb.ToString());
		sw.Close();
	}
	// String operations in .NET are highly optimized and in most cases do not significantly impact performance. However, in some scenarios such as tight loops that are executing many hundreds or thousands of times, string operations can affect performance. The StringBuilder class creates a string buffer that offers better performance if your program performs many string manipulations. The StringBuilder string also enables you to reassign individual characters, something the built-in string data type does not support. This code, for example, changes the content of a string without creating a new string:

	static void TestStringBuilder()
	{
		// In this example, a StringBuilder object is used to create a string from a set of numeric types:
		System.Text.StringBuilder sb = new System.Text.StringBuilder();

		// Create a string composed of numbers 0 - 9
		for (int i = 0; i < 10; i++)
		{
			sb.Append(i.ToString());
		}
		System.Console.WriteLine(sb);  // displays 0123456789

		// Copy one character of the string (not possible with a System.String)
		sb[0] = sb[9];

		System.Console.WriteLine(sb);  // displays 9123456789

		System.Text.StringBuilder sm = new System.Text.StringBuilder("Rat: the ideal pet");
		sm[0] = 'C';
		System.Console.WriteLine(sm.ToString());
		System.Console.ReadLine();

		//Outputs Cat: the ideal pet

	}
	// A format string is a string whose contents can be determined dynamically at runtime. You create a format string by using the static Format method and embedding placeholders in braces that will be replaced by other values at runtime. The following example uses a format string to output the result of each iteration of a loop:

	static void FormatString()
	{
		// Get user input.
		System.Console.WriteLine("Enter a number");
		string input = System.Console.ReadLine();

		// Convert the input string to an int.
		int j;
		System.Int32.TryParse(input, out j);

		// Write a different string each iteration.
		string s;
		for (int i = 0; i < 10; i++)
		{
			// A simple format string with no alignment formatting.
			s = System.String.Format("{0} times {1} = {2}", i, j, (i * j));
			System.Console.WriteLine(s);
		}

		//Keep the console window open in debug mode.
		System.Console.ReadKey();
	}
	// One overload of the WriteLine method takes a format string as a parameter. Therefore, you can just embed a format string literal without an explicit call to the method. However, if you use the WriteLine method to display debug output in the Visual Studio Output window, you have to explicitly call the Format method because WriteLine only accepts a string, not a format string.
}





