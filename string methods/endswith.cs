using System;

static void Sample()
{
    string n = "sunny";
    bool b = n.EndsWith("s");
    Console.WriteLine(b);

    string str = null;
    str = "VB.NET TOP 10 BOOKS";
    if (str.EndsWith("BOOKS") == true)
    {
        Console.WriteLine("The String EndsWith 'BOOKS' ");
    }
    else
    {
        Console.WriteLine("The String does not EndsWith 'BOOKS'");
    }
}