using System;

static void Sample()
{
    string n = �sunny�;
    Console.WriteLine(n.ToCharArray());

    string name = "sunny";
    char[] b = new char[1];
    b = name.ToCharArray();
    Console.WriteLine(b);
}