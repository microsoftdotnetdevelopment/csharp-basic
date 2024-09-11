using System;

static void Sample()
{
    string n = "su";
    Console.WriteLine(n.Insert(2, "nny"));

    string str = "This is CSharp Test";
    string insStr = "Insert ";
    string strRes = str.Insert(15, insStr);
    Console.WriteLine(strRes);
}