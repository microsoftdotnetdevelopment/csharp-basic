// Accept 10 values in array , and perform the below activities
// 	A. Find the unique numbers from array.
// 	B. Count the numbers coming more than once.
// 	C. Sort the array in ascending order with unique values.
// 	D. Sort the array in descending order with unique values.
// 	E. Count the existing prime numbers.
// 	F. Display all numbers coming more than once.


using System;
class Program
{
    static void Main(string[] args)
    {
        int i, j, a = 0;
        int[] n = new int[10];
        for (i = 0; i < 10; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < i; j++)
            {
                if (n[i] == n[j])
                {
                    break;
                }
            }
            if (i == j)
            {
                Console.Write(n[i]);
            }
        }
    }
}


class ProgramB
{
    static void MainB(string[] args)
    {
        int i, j, t, a = 0;
        int[] n = new int[10];
        for (i = 0; i < 10; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < i; j++)
            {
                if (n[i] == n[j])
                {
                    break;
                }
            }
            if (i == j)
            {
                Console.Write(n[i]);
                a++;
            }
        }

        Console.WriteLine("sorted array is");
        for (i = 0; i < a; i++)
        {
            for (j = i + 1; j < a; j++)
            {

                if (n[i] > n[j])
                {
                    t = n[i];
                    n[i] = n[j];
                    n[j] = t;
                }

            }

        }
        for (i = 0; i < a; i++)
        {
            Console.WriteLine(n[i]);
        }


    }
}


class ProgramC
{
    static void MainC(string[] args)
    {
        int i, j, t, a = 0;
        int[] n = new int[10];
        for (i = 0; i < 10; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < i; j++)
            {
                if (n[i] == n[j])
                {
                    break;
                }
            }
            if (i == j)
            {
                Console.Write(n[i]);
                a++;
            }
        }

        Console.WriteLine("sorted array is");
        for (i = 0; i < a; i++)
        {
            for (j = i + 1; j < a; j++)
            {

                if (n[i] < n[j])
                {
                    t = n[i];
                    n[i] = n[j];
                    n[j] = t;
                }

            }

        }
        for (i = 0; i < a; i++)
        {
            Console.WriteLine(n[i]);
        }


    }
}


class ProgramD
{
    static void MainD(string[] args)
    {
        int i, c, j;
        int[] n = new int[10];
        for (i = 0; i < 10; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < 10; i++)
        {
            c = 0;
            for (j = 2; j < n[i]; j++)
            {
                if (n[i] % j == 0)
                {
                    c = 1;
                    break;
                }
            }
            if (c == 0)
            {
                Console.Write(n[i]);
            }
        }
    }
}