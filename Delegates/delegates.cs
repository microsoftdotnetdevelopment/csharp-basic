
using System;
using System.Collections;

class Program
{
	public delegate void mydele();
	public void A()
	{
		Console.WriteLine("i m a");
	}
	public void B()
	{
		Console.WriteLine("I m b");
	}
	public void c()
	{
		Console.WriteLine("i m c");
	}

	class th
	{
		static void Main(string[] args)
		{
			Program ob = new Program();
			mydele delg = new mydele(ob.A);
			delg();
		}
	}
}
// o/p
// i m a

class Program1
{
	public delegate void mydele();
	public void A()
	{
		Console.WriteLine("i m a");
	}
	public void B()
	{
		Console.WriteLine("I m b");
	}
	public void c()
	{
		Console.WriteLine("i m c");
	}

	class th
	{
		static void Main1(string[] args)
		{
			Program ob = new Program();
			mydele delg = new mydele(ob.A);
			delg += new mydele(ob.B);
			delg += new mydele(ob.c);
			delg();
		}
	}
}
// o/p-
// i m a
// i m b
// i m c

namespace s1
{
	public delegate void mydele();
	class Program
	{

		public void A()
		{
			Console.WriteLine("i m a");
		}
		public void B()
		{
			Console.WriteLine("I m b");
		}
		public void c()
		{
			Console.WriteLine("i m c");
		}
	}
	class th
	{
		static void Main(string[] args)
		{
			Program ob = new Program();
			mydele delg = new mydele(ob.A);
			delg += new mydele(ob.B);
			delg += new mydele(ob.c);
			delg();
		}
	}
}

// A set of classes for handling a bookstore:
namespace Bookstore
{


	// Describes a book in the book list:
	public struct Book
	{
		public string Title;        // Title of the book.
		public string Author;       // Author of the book.
		public decimal Price;       // Price of the book.
		public bool Paperback;      // Is it paperback?

		public Book(string title, string author, decimal price, bool paperBack)
		{
			Title = title;
			Author = author;
			Price = price;
			Paperback = paperBack;
		}
	}

	// Declare a delegate type for processing a book:
	public delegate void ProcessBookDelegate(Book book);

	// Maintains a book database.
	public class BookDB
	{
		// List of all books in the database:
		ArrayList list = new ArrayList();

		// Add a book to the database:
		public void AddBook(string title, string author, decimal price, bool paperBack)
		{
			list.Add(new Book(title, author, price, paperBack));
		}

		// Call a passed-in delegate on each paperback book to process it: 
		public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
		{
			foreach (Book b in list)
			{
				if (b.Paperback)
					// Calling the delegate:
					processBook(b);
			}
		}
	}
}

// Using the Bookstore classes:
namespace BookTestClient
{
	using Bookstore;

	// Class to total and average prices of books:
	class PriceTotaller
	{
		int countBooks = 0;
		decimal priceBooks = 0.0m;

		internal void AddBookToTotal(Book book)
		{
			countBooks += 1;
			priceBooks += book.Price;
		}

		internal decimal AveragePrice()
		{
			return priceBooks / countBooks;
		}
	}

	// Class to test the book database:
	class Test
	{
		// Print the title of the book.
		static void PrintTitle(Book b)
		{
			Console.WriteLine("   {0}", b.Title);
		}

		// Execution starts here.
		static void Main()
		{
			BookDB bookDB = new BookDB();

			// Initialize the database with some books:
			AddBooks(bookDB);

			// Print all the titles of paperbacks:
			Console.WriteLine("Paperback Book Titles:");
			// Create a new delegate object associated with the static 
			// method Test.PrintTitle:
			bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(PrintTitle));

			// Get the average price of a paperback by using
			// a PriceTotaller object:
			PriceTotaller totaller = new PriceTotaller();
			// Create a new delegate object associated with the nonstatic 
			// method AddBookToTotal on the object totaller:
			bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(totaller.AddBookToTotal));
			Console.WriteLine("Average Paperback Book Price: ${0:#.##}",
			   totaller.AveragePrice());
		}

		// Initialize the book database with some test books:
		static void AddBooks(BookDB bookDB)
		{
			bookDB.AddBook("The C Programming Language",
			   "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
			bookDB.AddBook("The Unicode Standard 2.0",
			   "The Unicode Consortium", 39.95m, true);
			bookDB.AddBook("The MS-DOS Encyclopedia",
			   "Ray Duncan", 129.95m, false);
			bookDB.AddBook("Dogbert's Clues for the Clueless",
			   "Scott Adams", 12.00m, true);
		}
	}
}
// Output
// Paperback Book Titles:
//   The C Programming Language
//   The Unicode Standard 2.0
//   Dogbert's Clues for the Clueless
// Average Paperback Book Price: $23.97

// Explanation of program-
// Declaring a delegate 
// public delegate void ProcessBookDelegate(Book book);
// Declares a new delegate type. Each delegate type describes the number and types of the arguments, and the type of the return value of methods that it can encapsulate.
// Whenever a new set of argument types or return value type is needed, a new delegate type must be declared.

// -Instantiating a delegate  
//  Once a delegate type has been declared, a delegate object must be created and associated with a particular method. 
// Like all other objects, a new delegate object is created with a new expression. When creating a delegate, however, the argument passed to the new expression is special — it is written like a method call, but without the arguments to the method.
// The following statement:
// bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(PrintTitle));
// creates a new delegate object associated with the static method Test.PrintTitle. The following statement:
// bookDB.ProcessPaperbackBooks(new    ProcessBookDelegate(totaller.AddBookToTotal));
// creates a new delegate object associated with the nonstatic method AddBookToTotal on the object totaller. In both cases, this new delegate object is immediately passed to the ProcessPaperbackBooks method.
// Note that once a delegate is created, the method it is associated with never changes — delegate objects are immutable.

// -Calling a delegate 
//  Once a delegate object is created, the delegate object is typically passed to other code that will call the delegate.
//  A delegate object is called by using the name of the delegate object, followed by the parenthesized arguments to be passed to the delegate. 
// An example of a delegate call is:
// processBook(b);
// A delegate can either be called synchronously, as in this example, or asynchronously by using BeginInvoke and EndInvoke methods.

namespace delegatesSample
{
	class Program2
	{
		//Declaring a delegate
		public delegate void Calculator(int n1, int n2);
		static void Main2(string[] args)
		{
			//create delegate instances
			Calculator addDel = new Calculator(Add);
			Calculator SubDel = new Calculator(Subtract);
			Calculator CrossDel = new Calculator(Multiply);
			Calculator MulPlusDel, multiMinusHiDel;
			// The three delegates, addDel, SubDel and CrossDel, are combined to MulPlusDel. 
			MulPlusDel = addDel + SubDel + CrossDel;
			//Remove SubDel from the MulPlusDel delegate
			multiMinusHiDel = MulPlusDel - SubDel;
			MulPlusDel(5, 2);
			multiMinusHiDel(6, 2);

			Console.Read();
		}
		public static void Add(int a1, int a2)
		{
			Console.WriteLine(a1 + a2);
		}
		public static void Subtract(int a1, int a2)
		{
			Console.WriteLine(a1 - a2);
		}
		public static void Multiply(int a1, int a2)
		{
			Console.WriteLine(a1 * a2);
		}
	}
}
// When the above code is compiled and executed, it produces the following result:
// 7
// 3
// 10
// 8

namespace delegatesSample
{
	class Program4
	{
		//Declaring a delegate
		public delegate int Calculator(int n1, int n2);

		static void Main4(string[] args)
		{
			////create delegate instances
			Calculator c1 = new Calculator(Add);

			//calling the methods using the delegate objects
			int result = c1(2, 3);

			Console.WriteLine(result);
			Console.Read();
		}


		public static int Add(int a1, int a2)
		{
			return a1 + a2;
		}
	}
}

delegate void TestDelegate(string s);
static void M(string s)
{
	Console.WriteLine(s);
}
static void Main(string[] args)
{
	TestDelegate testDelA = new TestDelegate(M);
	TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };
	TestDelegate testDelC = (x) => { Console.WriteLine(x); };
	testDelA("Hello. My name is M and I write lines.");
	testDelB("That's nothing. I'm anonymous and ");
	testDelC("I'm a famous author.");
	Console.WriteLine("Press any key to exit.");
	Console.ReadKey();
}


delegate int del(int i);
static void Main(string[] args)
{
	del myDelegate = x => x * x;
	int j = myDelegate(5); //j = 25 } 
}



