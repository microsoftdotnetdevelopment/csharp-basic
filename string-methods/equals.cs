using System;

static void Sample()
{
    string n = "tests";
    string p = "tests";
    bool b = n.Equals(p);
    Console.WriteLine(b);

    string str1 = "Equals";
    string str2 = "Equals";
    if (string.Equals(str1, str2))
    {
        Console.WriteLine("Strings are Equal() ");
    }
    else
    {
        Console.WriteLine("Strings are not Equal() ");
    }
}