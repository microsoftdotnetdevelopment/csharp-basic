using System;

static void Sample()
{
    string country = "southindia";
    char[] ch = new char[10];
    country.CopyTo(0, ch, 0, 5);
    Console.WriteLine(ch);

    string str1 = "CopyTo() sample";
    char[] chrs = new char[6];
    str1.CopyTo(0, chrs, 0, 6);
    Console.WriteLine(chrs[0].ToString() + chrs[1].ToString() + chrs[2].ToString() + chrs[3].ToString() + chrs[4].ToString() + chrs[5].ToString());
}