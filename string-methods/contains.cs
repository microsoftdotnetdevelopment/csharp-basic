using System;

static void Sample()
{
    string country = "southindia";
    string cou = "india";
    if (country.Contains(cou))
    {
        Console.WriteLine(country);
    }
    else
    {
        Console.WriteLine(cou);
    }

    string str = null;
    str = "CSharp TOP 10 BOOKS";
    if (str.Contains("TOP") == true)
    {
        Console.WriteLine("The string Contains() 'TOP' ");
    }
    else
    {
        Console.WriteLine("The String does not Contains() 'TOP'");
    }
}

// it returns bool type
