using System;

static void SampleCopy()
{
    string country = "southindia";
    string cou = "india";
    string n = string.Copy(cou);
    Console.WriteLine(n);

    string str1 = null;
    string str2 = null;
    str1 = "CSharp Copy() test";
    str2 = string.Copy(str1);
    Console.WriteLine(str2);
}