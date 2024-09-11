
using System;
using System.Globalization;

// 1. Store the colors in the array with names like "Red","Blue","Green","Orange","Black" and display in the below pattern by using loops:

// 	-----------------------------------------------------------------------------------------
// 	|											|
// 	|			Red	:	1						|
// 	|			Blue	:	2						|
// 	|			Green	:	3						|
// 	|			Orange	:	4						|
// 	|			Balck	:	5						|
// 	|											|
// 	-----------------------------------------------------------------------------------------
static void Test1()
{
    int i;
    string[] arr1 = { "red", "blue", "green", "orange", "black" };
    Console.WriteLine("-----------------------------------------------------------------------------------------");
    for (i = 0; i <= 6; i++)
    {
        Console.WriteLine("|                   " + arr1[i] + " : " + i + "              |");
    }
    Console.WriteLine("-----------------------------------------------------------------------------------------");
}

// 2. Display the below format by using loop :

// 	-----------------------------------------------------------------------------------------
// 	|											|
// 	|			a	:	5						|
// 	|			b	:	4						|
// 	|			c	:	3						|
// 	|			d	:	2						|
// 	|			e	:	1						|
// 	|											|
// 	-----------------------------------------------------------------------------------------
static void Test2()
{
    Console.WriteLine("-----------------------------------------------------------------------------------------");
    int i = 97, j;
    while (i < 102)
    {
        for (j = 53; j >= 49; j--)
        {
            Console.WriteLine("|           " + "{0} : {1}", (char)i, (char)j + "            | ");
            i++;
        }
    }
    Console.WriteLine("-----------------------------------------------------------------------------------------");
}
// 3.Accept 10 values from user and calculate the :
// 	A.Maximum
// 	B.Minimum
// 	C.Sum
// 	D.Average

// By using Loop without using array.
static void TestA()
{
    int i, max = 0, j;
    int[] ch = new int[10];
    for (j = 0; j < 10; j++)
    {
        ch[j] = int.Parse(Console.ReadLine());
    }

    max = ch[0];
    for (i = 0; i < 10; i++)
    {
        if (ch[i] > max)
        {
            max = ch[i];
        }

    }
    Console.WriteLine("max element" + max);
}

static void TestB()
{
    int i, min = 0, j;
    int[] ch = new int[10];
    for (j = 0; j < 10; j++)
    {
        ch[j] = int.Parse(Console.ReadLine());
    }

    min = ch[0];
    for (i = 0; i < 10; i++)
    {
        if (ch[i] < min)
        {
            min = ch[i];
        }

    }
    Console.WriteLine("min element" + min);
}

static void TestC()
{
    int i, sum = 0, j;
    int[] ch = new int[10];
    for (j = 0; j < 10; j++)
    {
        ch[j] = int.Parse(Console.ReadLine());
    }


    for (i = 0; i < 10; i++)
    {

        sum = sum + ch[i];


    }
    Console.WriteLine("sum of  elements" + sum);
}

static void TestD()
{
    int i, sum = 0, j, avg;
    int[] ch = new int[10];
    for (j = 0; j < 10; j++)
    {
        ch[j] = int.Parse(Console.ReadLine());
    }


    for (i = 0; i < 10; i++)
    {

        sum = sum + ch[i];


    }
    avg = sum / 10;
    Console.WriteLine("avg of  elements" + avg);

}

// 4.Accept the name of 10 fruits and display the random fruit everytime user runs the program.
static void TestRandom()
{
    int i;
    Random r = new Random();

    string[] fru = new string[10];
    for (i = 0; i < 10; i++)
    {
        fru[i] = Console.ReadLine();

    }
    string ne = fru[r.Next(0, fru.Length)];
    Console.WriteLine(ne);
}
// 5.Find the factorial of a number by using array.

// 6.Check for the palindrome of the word taken by user.
static void Testpalindrome()
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
// 7.Initialize 4 array with 4 values as give below :

// 	Array name : "hairs " with values "balck","brown",white","yellow"
// 	Array name : "eyes" with values "black","brown","white","gray"
// 	Array name : "nose" with values "small","large","medium","bent"
// 	Array name : "title" with values "cat","elephant","cow","dog"

// Ask the user to choose the options provided by you one by one like below :

// 	Please provide the Color of your hair , please choose from below options :
// 			A. BLACK
// 			B. BROWN
// 			C. WHITE
// 			D. YELLOW

// 	Answer :  user will choose option and give answer either A,B,C or D here.

// 	Similarly ask other values from rest two array name "eyes" and "nose".

// 	After accepting all the options , display the random name from title array in the below given format :

// 	Hi As per your options provided ,You personality matches with ELEPHANT !!!!


class Program
{
    static int option(char ch)
    {
        int temp;
        if (ch == 'A' || ch == 'a')
        {
            temp = 0;
        }
        else if (ch == 'B' || ch == 'b')
        {
            temp = 1;
        }
        else if (ch == 'C' || ch == 'c')
        {
            temp = 2;
        }
        else if (ch == 'D' || ch == 'd')
        {
            temp = 3;
        }
        else
        {
            temp = 5;
        }
        return temp;
    }
    static void Main(string[] args)
    {
        Char ch;
        int temp;
        string[] hairs = new string[] { "black", "brown", "white", "yellow" };
        string[] eyes = new string[] { "black", "brown", "white", "gray" };
        string[] nose = new string[] { "small", "large", "medium", "bent" };
        string[] title = new string[] { "CAT", "ELEPHANT", "COW", "DOG" };
        Console.WriteLine("Please provide the Color of your hair ");
        Console.WriteLine("Please choose the options from below: ");
        Console.WriteLine("A. black" + Environment.NewLine + "B. Brown" + Environment.NewLine + "C. White" + Environment.NewLine + "D. Yellow");
        ch = char.Parse(Console.ReadLine());
        temp = option(ch);
        if (temp == 5)
        {
            Console.WriteLine("Please choose correct option");
        }
        else
        {


            Console.WriteLine("Please provide the Color of your eyes ");
            Console.WriteLine("Please choose the options from below: ");
            Console.WriteLine("A. black" + Environment.NewLine + "B. Brown" + Environment.NewLine + "C. White" + Environment.NewLine + "D. gray");
            ch = char.Parse(Console.ReadLine());
            temp = option(ch);
            if (temp == 5)
            {
                Console.WriteLine("Please choose correct option");
            }
            else
            {
                Console.WriteLine("Please provide the size of your nose ");
                Console.WriteLine("Please choose the options from below: ");
                Console.WriteLine("A. small" + Environment.NewLine + "B. Large" + Environment.NewLine + "C. Medium" + Environment.NewLine + "D. Bend");
                ch = char.Parse(Console.ReadLine());
                temp = option(ch);
                if (temp == 5)
                {
                    Console.WriteLine("Please choose correct option");
                }
                else
                {
                    Random rnd = new Random();
                    int fin_optn = rnd.Next(0, 4);
                    Console.WriteLine("Hi As per your options provided ,You personality matches with " + title[fin_optn] + " !!!!");
                }
            }
        }
    }
}

