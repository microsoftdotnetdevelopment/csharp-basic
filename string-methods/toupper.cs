using System;

static void Sample()
{
    string msg = "Hello, Welcome to C#";
    string upperMsg = msg.ToUpper();
    Console.WriteLine(upperMsg);

    double a = 5.0;
    msg = msg + " " + a.ToString();
    Console.WriteLine(msg);
}
// o/p-
// HELLO, WELCOME TO C#
// Hello, Welcome to C# 5
// Ex:2-
// string s = 'tests'
// Console.WriteLine(s.ToUpper());


