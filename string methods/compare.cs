using System;

static void Sample()
{
    string country = "southindia";
    object ob1 = country.Clone();
    Console.WriteLine(country.CompareTo(ob1));

    string country1 = "southindia";
    string cou = "insia";
    int n = country1.CompareTo(cou);
    Console.WriteLine(n);

    string str1 = null;
    string str2 = null;
    str1 = "csharp";
    str2 = "CSharp";
    int result = 0;
    result = string.Compare(str1, str2);
    Console.WriteLine(result.ToString());
    result = string.Compare(str1, str2, true);
    Console.WriteLine(result.ToString());
}
// The Compare and CompareOrdinal methods are static, while CompareTo is an instance method.it is based on ascii

class Program
{
    static void Main()
    {
        string a = "a";
        string b = "b";

        int c = string.Compare(a, b);
        Console.WriteLine(c);

        c = string.CompareOrdinal(b, a);
        Console.WriteLine(c);

        c = a.CompareTo(b);
        Console.WriteLine(c);

        c = b.CompareTo(a);
        Console.WriteLine(c);
    }
}

// Output
// -1       (This means a is smaller than b)
// 1        (This means b is smaller than a)
// -1
// 1