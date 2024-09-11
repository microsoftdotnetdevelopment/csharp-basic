using System;

static void Sample()
{

    string str = null;
    int len = str.Length;
    // When run the above code it will throw NullReferenceException.


    // How to check null String in c#?
    // You may use the null keyword to check or assign the value of an object.
    string str1 = null;
    if (str1 == null)
    {
        Console.WriteLine("String is null");
    }
    // In the above code we created a string Object and assigned null and next we check the string is null or not.


    string str2 = null;
    if (string.IsNullOrEmpty(str2))
    {
        Console.WriteLine("String is empty or null");
    }

    string str3 = null;
    if (str3 == null)
    {
        Console.WriteLine("String is null");
    }
    else
    {
        Console.WriteLine("String is not null");
    }
    str3 = "test";
    if (string.IsNullOrEmpty(str3))
    {
        Console.WriteLine("String is empty or null");
    }
    else
    {
        Console.WriteLine("String is not empty or null");
    }
}