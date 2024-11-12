using System;
using System.Text;
// 1.Accept three numbers and display the maximum number of three by using loops.
static void Displaymax()
{
	int[] a = new int[3];
	for (int i = 0; i < 3; i++)
	{
		a[i] = int.Parse(Console.ReadLine());
	}
	int max = a[0];
	for (int i = 0; i < 3; i++)
	{
		if (a[i] > max)
		{
			max = a[i];
		}

	}
	Console.WriteLine("max no. " + max);
}
// 2.Accept the name of the user and count the number of vowels in it.
static void Displaycount()
{
	char[] sentence = new char[100];

	int i, vowels = 0, n;
	Console.WriteLine("Enter the Length of the sentence  \n");
	n = int.Parse(Console.ReadLine());
	for (i = 0; i < n; i++)
	{
		sentence[i] = Convert.ToChar(Console.Read());
	}
	for (i = 0; sentence[i] != '\0'; i++)
	{
		if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] ==
		'i' || sentence[i] == 'o' || sentence[i] == 'u') ||
		(sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
		'I' || sentence[i] == 'O' || sentence[i] == 'U'))
		{
			vowels = vowels + 1;
		}
	}
	Console.WriteLine(vowels);

	// or

	int i1, v = 0;
	string n1 = Console.ReadLine();
	for (i1 = 0; i1 < n1.Length; i1++)
		if (n1[i1] == 'a' || n1[i1] == 'e' || n1[i1] == 'i' || n1[i1] == 'o' || n1[i1] == 'u')
		{
			v = v + 1;
		}
	Console.WriteLine(v);
}
// 3.Accept the name of the user and count the letters in it.
static void Displaycountuser()
{
	int i, c = 0;
	string n = Console.ReadLine();
	for (i = 0; i < n.Length; i++)
	{
		c = c + 1;
	}
	Console.WriteLine(c);
}

// 4.Accept the email id and check whether email id is ok or not ? E.g. it should contain @ and . in between.
static void checkEmail()
{
	int i = 0, f = 0;
	string n = Console.ReadLine();
	for (i = 0; i < n.Length; i++)
	{
		if (n[i] == '@' || n[i] == '.')
		{
			f = f + 1;
		}

	}
	if (f == 2)
	{
		Console.WriteLine("correct");
	}
	else
	{
		Console.WriteLine("incorrect");
	}
}
// 5.Accept the word and check for the palindrome.
static void checkpalindrome()
{
	int i;
	string n = Console.ReadLine();
	string revs = "";

	for (i = n.Length - 1; i >= 0; i--)
	{
		revs = revs + n[i];
	}
	if (revs == n)
	{
		Console.WriteLine("palid");

	}
	else
	{
		Console.WriteLine("no");
	}
}
// 6.Display the prime numbers upto the number given by user.
static void checkprime()
{
	int n, i, p = 1, j;
	n = int.Parse(Console.ReadLine());
	for (i = 2; i < n; i++)
	{
		for (j = 2; j < i / 2; j++)
		{
			if (i % j == 0)
			{
				p = 0;
				break;
			}
		}
		if (p == 1)
		{
			Console.WriteLine(i);
		}
	}
}
// 7.Accept the name of the user and verify for the luck draw, conditions are given below
// 	1.name is starting with character a or s or h.
// 	2.name should have minimum 3 vowels in it.
// 	3.name should have minimum 5 and not more than 10 characters.

static void checkdraw()
{
	bool lucky1 = false, lucky2 = false;
	int i, cnt = 0;
	string n = Console.ReadLine();
	for (i = 0; i < n.Length; i++)
	{
		if (n.Length > 5 && n.Length < 10)
		{
			if (n[0] == 's' || n[0] == 'a' || n[0] == 'h')
			{
				lucky1 = true;
			}
			if (n[i] == 'a' || n[i] == 'e' || n[i] == 'o' || n[i] == 'u' || n[i] == 'i')
			{
				cnt++;
				if (cnt >= 3)
				{
					lucky2 = true;
				}
			}

		}
	}
	if (lucky1 == true && lucky2 == true)
	{
		Console.WriteLine("This Is a Lucky Winner");
	}
	else
	{
		Console.WriteLine("This is Not Lucky Winner");
	}
}

// 8.Accept the character and display the ascii value of that.
static void checkascii()
{
	char ch = char.Parse(Console.ReadLine());

	int i = ch;//implicit casting
	Console.WriteLine(i);
	Console.ReadKey();  //to hold window
}
// 9.Accept the ascii number and display the corresponding charcater.
static void checkasciinumber()
{
	int wer = int.Parse(Console.ReadLine());
	char n = (char)wer;//explicit
	Console.WriteLine(n);
	Console.ReadKey();
}

// 10.Create the below mentioned functions :
// 	A.Charindex("E" ,"HELLO") -- output -2(you have to pass two parameters string or char which u have to match),
// 	B.Left("India",3) -- output -- Ind
// 	C.Right("India",3)-- output -- dia
// 	D.Lower("INDIA") -- output -- india
// 	E.Replace("University","i","e") -- output-- Uneversety
// 	F.Replicate("India",4) -- output -- display India 4 times.
// 	G.Substring("understanding",3,5) -- output- derst
// 	H.Upper("india") -- output -- INDIA
// 	I.Concat("Hello","India") -- output --- HelloIndia


static void checkfunctions()
{
	// a)
	int i;
	string n = Console.ReadLine();
	char p = char.Parse(Console.ReadLine());
	for (i = 0; i < n.Length; i++)
	{
		if (n[i] == p)
		{
			Console.WriteLine(i + 1);
		}
	}
	// b)
	int i5;
	string n5 = Console.ReadLine();
	for (i5 = 0; i5 < 3; i5++)
	{
		Console.Write(n5[i5]);
	}

	// c)

	int i6, f = 0;
	string n6 = Console.ReadLine();
	for (i6 = n6.Length - 1; i6 >= f + 2; i6--)
	{
		Console.Write(n6[i6]);
	}

	// d)
	int i7, a;
	String n9 = Console.ReadLine();

	foreach (char c in n9)
	{
		a = (int)c;
		i7 = a + 32;
		Console.Write((char)i7);
	}
	// e)

	int i8;
	StringBuilder n55 = new StringBuilder("hello");

	char ch = char.Parse(Console.ReadLine());
	char kh = char.Parse(Console.ReadLine());
	for (i8 = 0; i8 < n55.Length; i8++)
	{
		if (n55[i8] == ch)
		{
			n55[i8] = kh;
		}
		Console.Write(n55[i8]);
	}

	// f)

	int i9;
	string n66 = Console.ReadLine();
	int p55 = int.Parse(Console.ReadLine());
	for (i9 = 0; i < p55; i9++)
	{
		Console.WriteLine(n66);
	}

	// h)
	int a6;
	string n7 = Console.ReadLine();
	foreach (char c in n7)
	{
		a6 = (int)c;
		a6 = a6 - 32;
		Console.Write((char)a6);
	}


	// i)


	string n8 = Console.ReadLine();
	string p77 = Console.ReadLine();
	Console.WriteLine(n8 + p77);
}
// 11. Accept the number and display the table in the format given below
// 	2 X 1 = 2
// 	2 x 2 = 4
// 	----------
// 	----------
// 	----------
// 	2 X 10 = 20 

static void checkformatdata()
{
	int i;
	int n = int.Parse(Console.ReadLine());
	for (i = 1; i <= 10; i++)
	{

		Console.WriteLine("{0}*{1}={2}", n, i, n * i);
	}
}

