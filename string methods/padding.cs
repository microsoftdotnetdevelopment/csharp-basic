using System;

static void Sample()
{

    string myString = "CSHARP";
    string newString;
    System.Console.WriteLine("String Before Padding : ");
    System.Console.WriteLine(myString);
    System.Console.WriteLine("String After Padding : ");
    newString = myString.PadLeft(10, ' ');
    newString = newString.PadRight(20, '*');
    System.Console.Write("[" + newString + "]");
    Console.Read();
}

// o/p
// [         CSHARP**********]