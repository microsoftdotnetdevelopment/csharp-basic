using System;

static void Sample()
{
    string n = "sunny";
    bool b = n.StartsWith("s");
    Console.WriteLine(b);

    string name = "sunny";
    bool b1 = false;
    b1 = name.StartsWith("s");
    Console.WriteLine(b1);
}