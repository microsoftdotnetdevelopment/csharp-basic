using System;

static void Sample()
{
    string n = "sunmy";
    Console.WriteLine(n.Substring(2));

    string str = null;
    string retString = null;
    str = "This is substring test";
    retString = str.Substring(8, 9);
    Console.WriteLine(retString);
}