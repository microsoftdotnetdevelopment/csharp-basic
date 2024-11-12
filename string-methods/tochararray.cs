using System;

static void Sample()
{
    string n = "tests";
    Console.WriteLine(n.ToCharArray());

    string name = "tests";
    char[] b = new char[1];
    b = name.ToCharArray();
    Console.WriteLine(b);
}