using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1.Accept the size of the two dimensional array like no of rows and columns then store the values in it and display accordingly.


class Program
{
    static void Main(string[] args)
    {
        int i, j;
        int[,] n = new int[2, 3];
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 3; j++)
            {
                n[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.WriteLine(n[i, j]);
            }
        }
    }
}

// 2.Accept the values of an array of size 10 then perform the below operations :

// 	A. Sort it in ascending order by using Bubble Sort.
// 	B. Sort it in descending order by using Bubble Sort.
// 	C. Use loop to copy the values of existing array upto the index provided by user into  new array and display its all values.

namespace ConsoleApplication10
{
    class Program10
    {
        static void Main10(string[] args)
        {
            int[] n = new int[15];
            int i, temp = 0, j;
            int p = int.Parse(Console.ReadLine());
            for (i = 0; i < p; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (j = 0; j < p; j++)
            {

                for (i = 0; i < p - 1; i++)
                {
                    if (n[i] > n[i + 1])
                    {
                        temp = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = temp;

                    }
                }



            }
            for (i = 0; i < p; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }

}

namespace ConsoleApplicationB
{
    class ProgramB
    {
        static void MainB(string[] args)
        {
            int[] n = new int[15];
            int i, temp = 0, j;
            int p = int.Parse(Console.ReadLine());
            for (i = 0; i < p; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (j = 0; j < p; j++)
            {

                for (i = 0; i < p - 1; i++)
                {
                    if (n[i] < n[i + 1])
                    {
                        temp = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = temp;

                    }
                }



            }
            for (i = 0; i < p; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }

}

namespace ConsoleApplicationC
{
    class ProgramC
    {
        static void MainC(string[] args)
        {
            int[] arr = new int[10];
            int n, p, i;
            n = int.Parse(Console.ReadLine());
            for (p = 0; p < n; p++)
            {
                arr[p] = int.Parse(Console.ReadLine());
            }
            Console.Write("upto which index you want to copy array");
            int q = int.Parse(Console.ReadLine());
            q = q + 1;
            for (i = 0; i < q; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
// 3.Accept the characters in the array of dimensio 3X4 means 3 rows and 4 columns , after it perform the below operations :

// 	A.Display the characters in single line stored at similar indexes like 0,0 1,1 2,2 etc.
// 	B.Display the characters in single line stored at even sum of both indexes E.G (1,1) sum is 2(even).
// 	C.Display the characters in single line stored at odd sum of both indexes E.G (1,2) sum is 3(odd).

namespace ConsoleApplication3A
{
    class Program3A
    {
        static void Main3A(string[] args)
        {
            int i, j, p = 1;
            char[,] n = new char[3, 4];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    n[i, j] = char.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(n[i, j]);
                    }

                }
            }

        }
    }
}

namespace ConsoleApplicationBC
{
    class ProgramBC
    {
        static void MainBC(string[] args)
        {
            int i, j, k = 0, even = 0, odd = 0;
            int[,] n = new int[3, 4];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    n[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {

                    if ((i + j) % 2 == 1)
                    {
                        odd = odd + n[i, j];
                    }
                    else
                    {
                        even = even + n[i, j];
                    }
                }
            }
            Console.WriteLine("odd");
            Console.WriteLine(odd);
            Console.WriteLine("even");
            Console.WriteLine(even);
        }
    }
}
// 4.Accept your friend's names in array of dimension 3X4 (3 rows and 4 columns ) and then perform the below tasks :

// 	A. Display the random name from the array.
// 	B. count the names starting with vowels.
// 	C. count the names ending with vowels.
// 	D. count the name which contains minimum 3 or more vowels in it.
// 	E. search for the specific name given by user in array and display found or not found.
// 	F. randomly display name like in the below pattern(e.g. full name is abhay ):

// 		ab** ( only first two character to be displayed and rest will be displayed as *(asterik)		

// 	 and then ask user to give the full name and check whether it is same or not.


namespace ConsoleApplication4
{
    class Program4
    {
        static void Main4(string[] args)
        {
            int i, j;
            string[,] n = new string[3, 4];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    n[i, j] = Console.ReadLine();
                }
            }
            Random r = new Random();
            i = r.Next(0, 3);
            j = r.Next(0, 4);

            Console.WriteLine(n[i, j]);
        }
    }
}

namespace ConsoleApplication4B
{
    class Program4B
    {
        static void Main4B(string[] args)
        {
            int i, j, a = 0;
            string temp;
            string[,] n = new string[3, 4];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    n[i, j] = Console.ReadLine();
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    temp = n[i, j];
                    if (temp[0].Equals('a') || temp[0].Equals('e') || temp[0].Equals('i') || temp[0].Equals('o') || temp[0].Equals('u'))
                    {
                        a++;
                    }
                }
            }

            Console.WriteLine(a);
        }
    }
}

namespace ConsoleApplication4C
{
    class Program4C
    {
        static void Main4C(string[] args)
        {
            int i, j, a = 0;
            string temp;
            string[,] n = new string[3, 4];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    n[i, j] = Console.ReadLine();
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    temp = n[i, j];
                    int p = temp.Length;
                    if (temp[p - 1].Equals('a') || temp[p - 1].Equals('e') || temp[p - 1].Equals('i') || temp[p - 1].Equals('o') || temp[p - 1].Equals('u'))
                    {
                        a++;
                    }
                }
            }

            Console.WriteLine(a);
        }
    }
}

namespace ConsoleApplication4D
{
    class Program4D
    {
        static void Main4D(string[] args)
        {
            int i, j, a = 0, k, p;

            string temp;
            string[,] n = new string[3, 4];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    n[i, j] = Console.ReadLine();
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    temp = n[i, j];
                    p = temp.Length;
                    for (k = 0; k < p; k++)
                    {
                        if (temp.Contains('a') || temp.Contains('e') || temp.Contains('i') || temp.Contains('o') || temp.Contains('u'))
                        {
                            a++;
                            if (a > 3)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                }

                Console.WriteLine(a);
            }
        }
    }
}


namespace ConsoleApplication4E
{
    class Program4E
    {
        static void Main4E(string[] args)
        {
            int i, j, p = 0, q = 0;
            string temp;
            string[,] n = new string[3, 4];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    n[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("enter name you want to search");
            temp = Console.ReadLine();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (n[i, j] == temp)
                    {
                        p = 1;
                    }
                    else
                    {
                        q = 2;
                    }
                }
            }
            if (p == 1)
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
    }
}






