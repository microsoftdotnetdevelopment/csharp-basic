using System;
// 1.Accept the number from user and display the below given pattern . For E.G user has given number 5 .

// Pattere A :

// 		* * * * *
// 		* * * *
// 		* * *
// 		* *
// 		*



// Pattern B :
// 		*
// 		* *
// 		* * *
// 		* * * *
// 		* * * * *

// Pattern C :	
// 		*
// 	      *   *
// 	    *       *
// 	  *           *
//         *               *

// Patter D :

// 		1
// 		1 2
// 		1 2 3
// 		1 2 3 4
// 		1 2 3 4 5

// Pattern E :

// 		1 2 3 4 5 
// 		1 2 3 4
// 		1 2 3 
// 		1 2
// 		1


// Patter F :
// 		1
// 		1 1
// 		1 1 1
// 		1 1 1 1
// 		1 1 1 1 1

// Pattern G:
// 		a
// 		B C
// 		d e f
// 		G H I J
// 		k l m n o

static void patterna()
{


    int i, j;
    for (i = 1; i <= 5; i++)
    {
        for (j = 1; j <= 5; j++)
        {
            if (j <= 6 - i)
            {
                Console.Write("x");
            }

        }
        Console.WriteLine();
    }
}

static void patternb()
{
    int i, j;
    for (i = 1; i <= 5; i++)
    {
        for (j = 1; j <= 5; j++)
        {
            if (j <= i)
            {
                Console.Write("x");
            }

        }
        Console.WriteLine();
    }
}
static void patternc()
{

    int i, j;
    for (i = 1; i <= 5; i++)
    {
        for (j = 1; j <= 9; j++)
        {
            if (j == 6 - i || j == 4 + i)
            {
                Console.Write("x");
            }
            else
            {
                Console.Write(" ");
            }

        }
        Console.WriteLine();
    }
}
static void patternd()
{

    int i, j;
    for (i = 1; i <= 5; i++)
    {
        for (j = 1; j <= 5; j++)
        {
            if (j <= i)
            {
                Console.Write(j);

            }


        }

        Console.WriteLine();
    }
}
static void patterne()
{

    int i, j;
    for (i = 1; i <= 5; i++)
    {
        for (j = 1; j <= 5; j++)
        {
            if (j <= 6 - i)
            {
                Console.Write(j);

            }


        }

        Console.WriteLine();
    }
}
static void patternf()
{

    int i, j, k = 1;
    for (i = 1; i <= 5; i++)
    {
        for (j = 1; j <= 5; j++)
        {
            if (j <= i)
            {
                Console.Write(k);

            }


        }

        Console.WriteLine();
    }
}
static void patterng()
{

    int i, j, k = 65, l = 97;
    for (i = 0; i <= 5; i++)
    {
        for (j = 0; j <= i; j++)
        {
            if (i % 2 == 0)
            {
                Console.Write((char)l);
                k++;
                l++;
            }
            else
            {
                Console.Write((char)k);
                k++;
                l++;
            }

        }
        Console.WriteLine();

    }
}

// 2. Accept the no of lines and the choice of displaying the lines e.g. horizontal or vertical . For E.G user has given no of lines 5 and chosen horizontal then display 5 horizontal lines as below :

// ---------------------
// ---------------------
// ---------------------
// ---------------------
// ---------------------

// similarly do for vertical .




class Program
{



    static void Main(string[] args)
    {
        int i, k;
        char ch;
        Console.Write("enter no. of lines");
        int n = int.Parse(Console.ReadLine());
        Console.Write("which line you want to print horizontal or vertical");
        ch = char.Parse(Console.ReadLine());
        switch (ch)
        {
            case 'h':
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("--------------");

                }
                break;
            case 'v':
                for (i = 0; i < n; i++)
                {
                    for (k = 0; k < n; k++)
                    {
                        Console.Write("| ");
                    }
                    Console.WriteLine(" ");
                }
                break;


        }
    }
}




