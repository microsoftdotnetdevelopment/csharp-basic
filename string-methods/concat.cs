using System;
using System.Collections.Generic;


static void Sample()
{
    string country = "southindia";
    string cou = "india";
    string all = string.Concat(country, cou);
    Console.WriteLine(all);

    string s = "bfdwed";
    string n = "aywdwe";
    string q = null;
    q = string.Concat(n, s);
    Console.WriteLine(q);

    string str1 = null;
    string str2 = null;
    str1 = "Concat() ";
    str2 = "Test";
    Console.WriteLine(string.Concat(str1, str2));

    string s1 = "string2";
    string s2 = "string1" + s1;
    Console.WriteLine(s2);

    var list = new List<string>();
    list.Add("cat");
    list.Add("dog");
    list.Add("perls");

    // Concat the list.
    string concat = string.Concat(list);
    Console.WriteLine(concat);

    // Join the list.
    string join = string.Join("", list);
    Console.WriteLine(join);
}