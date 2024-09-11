using System;

static void Sample()
{
    string n = " sunny";
    Console.WriteLine(n.Trim());

    string n1 = ".. sunny df";
    Console.WriteLine(n1.Trim('.', ' '));
}