using System;

static void Sample()
{
    string n = " tests";
    Console.WriteLine(n.Trim());

    string n1 = ".. tests df";
    Console.WriteLine(n1.Trim('.', ' '));
}