using System;
using System.Text.RegularExpressions;

static void Sample()
{
    string n = “df.vb.gh”;
    string[] detail = n.Split(‘.’);
    foreach (string s in detail)
    {
        Console.WriteLine(s);
    }

    string str = null;
    string[] strArr = null;
    int count = 0;
    str = "CSharp split test";
    char[] splitchar = { ' ' };
    strArr = str.Split(splitchar);
    for (count = 0; count <= strArr.Length - 1; count++)
    {
        Console.WriteLine(strArr[count]);
    }

    // using regular expressions:-
    string str1 = "one\n   \ntwo\n   \nthree\n   \n   \nfour";
    string[] result = Regex.Split(str1, "\n\\s*");
    for (int i = 0; i < result.Length; i++)
        Console.WriteLine(result[i]);

    string input = "one)(two)(three)(four)(five";
    string[] result1 = input.Split(new string[] { ")(" }, StringSplitOptions.None);
    foreach (string s in result1)
        Console.WriteLine(s);

    // for multiple characters:-
    string input1 = "one)(two)(three)(four)(five";
    string[] result2 = Regex.Split(input1, @"\)\(");
    foreach (string s in result2)
        Console.WriteLine(s);

    string test = "One\nTwo\r\nThree\nFour\n";
    string[] result3 = test.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
    foreach (string s in result3)
        Console.WriteLine(s);

    string test1 = "One\r\nTwo\r\nThree\r\nFour";
    string[] result4 = test1.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
    foreach (string s in result4)
        Console.WriteLine(s);

    string myStrA = "one two   three    four     five";
    string[] result5 = myStrA.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
    foreach (string s in result5)
        Console.WriteLine(s);
}
