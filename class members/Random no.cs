
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

class Program
{
	static int randamno(int n, int p)
	{
		int i, sum = 0, ne;
		Random r = new Random();
		for (i = 0; i < p; i++)
		{
			ne = r.Next(1, 7);
			sum = sum + ne;
		}

		return sum;

	}
	static void Main(string[] args)
	{
		Console.WriteLine("enter what no. you are expected");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine("how many attempts you need");
		int p = int.Parse(Console.ReadLine());
		int sum = randamno(n, p);
		Console.WriteLine(sum);
		if (sum > n)
		{
			Console.WriteLine("winner");
		}
		else
		{
			Console.WriteLine("Looser");
		}
	}
}


class Program1
{
	static void fill()
	{
		int i;
		int[] arr = new int[10];
		Random n = new Random();
		for (i = 0; i < 10; i++)
		{
			arr[i] = n.Next(1, 10);
			display(arr[i]);
		}
	}
	static void display(int temp)
	{
		Console.WriteLine(temp);
	}
	static void Main1(string[] args)
	{
		fill();
	}
}




class Program2
{
	static void Main2(string[] args)
	{
		int i, j;
		char c;
		Random r = new Random();
		for (i = 0; i < 6; i++)
		{
			if (i == 2 || i == 3)
			{
				int d = r.Next(1, 9);
				Console.Write(d);
				continue;
			}
			c = (char)r.Next(65, 90);
			Console.Write(c);

		}

	}
}

class Program3
{
	static void Main3(string[] args)
	{
		int i;

		string n = Console.ReadLine();
		StringBuilder b = new StringBuilder();
		b.Append(n);
		Random p = new Random();
		for (i = 0; i < 4; i++)
		{
			b[p.Next(0, 9)] = 'x';

		}
		Console.WriteLine(b);
	}
}



namespace ConsoleApplication10
{
	class Program4
	{
		static void Main4(string[] args)
		{
			int i, j;
			int[,] n = new int[3, 4];

			Random r = new Random();
			for (i = 0; i < 3; i++)
			{
				for (j = 0; j < 4; j++)
				{
					int p = r.Next(1, 9);
					n[i, j] = p;
				}
			}
			for (i = 0; i < 3; i++)
			{
				for (j = 0; j < 4; j++)
				{
					Console.WriteLine(n[i, j]);
				}
			}
		}

		static void Mainfvd()
		{
			Random r = new Random();
			int ne = r.Next(10);
			Console.WriteLine(ne);
		}

		static void jkhbkj()
		{
			Random r = new Random();
			char c = (char)r.Next(65, 92);
			char m = (char)r.Next(65, 92);
			int d = r.Next(1, 9);
			int e = r.Next(1, 9);
			char a = (char)r.Next(65, 92);
			char b = (char)r.Next(65, 92);
			Console.WriteLine("{0}{1}{2}{3}{4}{5}", c, m, d, e, a, b);
		}
	}
}


