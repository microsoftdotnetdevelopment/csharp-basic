using System;
// Q1:- Accept the size of an array from user and perform the below activities.
// 	1.Check whether the size in the range of 5 and 15 only.
// 	2.Accept the values in that corresponding range.
// 	3.Display the values as below:-
// 		A.Display only values stored at even index.
// 		B.Display only the values stored at odd index.
// 		C.Display the sum of values stored at even index.
// 		D.Display the sum of values stored at odd index.
// 		E.Count total number of prime numbers in it.


// Note:	Create different functions for the above given activities.....

class Program
{

    static void Main(string[] args)
    {
        int j, k = 0, l = 0, m, add = 0, n, q, w, b = 1;
        int p = int.Parse(Console.ReadLine());
        int[] ch = new int[20];
        if (p >= 5 && p <= 15)
        {
            for (j = 0; j < p; j++)
            {
                ch[j] = int.Parse(Console.ReadLine());
            }
            for (k = 0; k < p; k++)
            {
                Console.WriteLine(ch[k]);
            }

            Console.Write("values at even place");
            for (l = 0; l < p; l++)
            {
                if (l % 2 == 0)
                {
                    Console.WriteLine(ch[l]);
                }
            }
            Console.Write("values at odd place");
            for (m = 0; m < p; m++)
            {
                if (m % 2 == 1)
                {
                    Console.WriteLine(ch[m]);
                }
            }
            Console.Write("summ at even index");
            for (n = 0; n < p; n++)
            {
                if (n % 2 == 0)
                {
                    add = add + ch[n];
                }
            }
            Console.WriteLine(add);
        }
        for (q = 0; q < p; q++)
        {
            for (w = 2; w < p / 2; w++)
            {
                if (ch[q] % w == 0)
                {
                    b = 0;
                    break;
                }
                else
                {
                    if (b == 1)
                    {
                        Console.WriteLine("prime no{0}", ch[q]);
                    }
                }
            }

        }
    }
}


// Q2:- Accept 5 employee names in array and perform the below tasks.

// 	A.Display the names only starting with character provided by the user.
// 	B.Display only those names which are having it's length equivalent and  greater than provided by user
// 	C.Display only those names which are ending with character provided by user.
// 	D.Display all names in uppercase.
// 	E.Count the total no of vowels in all names.
// 	F.Display the mid character of all names together by appending in single word.
// 	G.Display all names in ascending order by comparing only first charcter of every name.
// 	H.Display similar names if available in array.

class ProgramB
{
    static void MainB(string[] args)
    {
        int i;
        string[] we = new string[5];
        string[] ne = new string[5];
        for (i = 0; i < 5; i++)
        {
            we[i] = Console.ReadLine();
        }
        Console.WriteLine("enter character");
        string ch = Console.ReadLine();
        for (i = 0; i < 5; i++)
        {
            if (we[i].StartsWith(ch))
            {
                Console.WriteLine(we[i]);
            }
        }
    }
}

class ProgramC
{
    static void MainC(string[] args)
    {
        int i;
        string[] we = new string[5];

        for (i = 0; i < 5; i++)
        {
            we[i] = Console.ReadLine();
        }
        Console.WriteLine("enter length");
        int ch = int.Parse(Console.ReadLine());
        for (i = 0; i < 5; i++)
        {
            if (we[i].Length >= ch)
            {
                Console.WriteLine(we[i]);
            }
        }
    }
}


class ProgramCC
{
    static void MainCC(string[] args)
    {
        int i;
        string[] we = new string[5];

        for (i = 0; i < 5; i++)
        {
            we[i] = Console.ReadLine();
        }
        Console.WriteLine("enter last chaacter");
        string ch = Console.ReadLine();
        for (i = 0; i < 5; i++)
        {
            if (we[i].EndsWith(ch))
            {
                Console.WriteLine(we[i]);
            }
        }
    }
}


class ProgramD
{
    static void MainD(string[] args)
    {
        int i;
        string[] we = new string[5];

        for (i = 0; i < 5; i++)
        {
            we[i] = Console.ReadLine().ToUpper();
            //Console.WriteLine(we[i]);
        }
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine(we[i]);
        }

    }
}


class ProgramE
{
    static void MainE(string[] args)
    {
        int i, k = 0;
        string[] we = new string[5];
        int[] cnt = new int[5];
        for (i = 0; i < 5; i++)
        {
            we[i] = Console.ReadLine().ToUpper();
        }
        for (i = 0; i < 5; i++)
        {
            string temp = we[i];
            cnt[i] = func(temp);
        }
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine(cnt[i]);
        }
    }
    static int func(string temp)
    {
        int k = 0;
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] == 'A' || temp[i] == 'E' || temp[i] == 'I' || temp[i] == 'O' || temp[i] == 'U')
            {
                k++;
            }
        }
        return k;
    }
}


class ProgramF
{
    static void MainF(string[] args)
    {
        int j;
        string[] n = new string[5];
        string[] q = new string[5];

        for (int i = 0; i < 5; i++)
        {
            n[i] = Console.ReadLine();
        }
        for (j = 0; j < 5; j++)
        {
            int p = n[j].Length;
            q[j] = n[j].Substring(1, p - 2);
        }
        for (j = 0; j < 5; j++)
        {
            Console.Write(q[j]);
        }
    }
}


class ProgramG
{
    static void MainG(string[] args)
    {
        int i, j, k, l;
        string[] n = new string[5];
        string p = "";

        for (i = 0; i < 5; i++)
        {
            n[i] = Console.ReadLine();
        }
        for (j = 0; j < 5; j++)
        {
            for (k = i + 1; k < 5; k++)
            {
                for (l = 0; l < 5; l++)
                {
                    if (n[j][l] > n[k][l])
                    {
                        p = n[j];
                        n[l] = n[k];
                        n[k] = p;
                    }

                }

            }


        }
    }
}


class ProgramH
{
    static void MainH(string[] args)
    {
        int j;
        string[] n = new string[5];
        for (int i = 0; i < 5; i++)
        {
            n[i] = Console.ReadLine();
        }

        for (j = 0; j < 5; j++)
        {
            int p = n[j].CompareTo(n[j + 1]);
            if (p == 0)
            {
                Console.WriteLine(n[j]);
            }

        }
    }
}


// Q3:- Accept 10 numbers from user, within range of 1 and 20 only and store in an array then display those numbers 
//      which are not given by the user in array or except those numbers which are coming in array.


//      For example: if the user inputs 1,4,2,8,11,10,18,14,16,19

//      Now you need to display those numbers which are left i.e.3,5,6,7,9,12,13,15,17,20.   

class ProgramNum
{
    static void MainNum(string[] args)
    {
        int i, j, js = 0, k = 1, cnt = 0;
        int[] n = new int[20];
        int[] temp = new int[30];
        Console.WriteLine("enter no. between range 1 to 20");
        for (i = 0; i < 10; i++)
        {

            n[i] = int.Parse(Console.ReadLine());
        }

        while (k <= 20)
        {
            for (i = 0; i < 10; i++)
            {
                if (k != n[i])
                {
                    temp[js] = k;
                    js++;
                }
            }
            k++;
        }
        for (i = 0; i < 20; i++)
        {
            Console.WriteLine(temp[i]);
        }
    }
}

