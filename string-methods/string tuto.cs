using System;
class myclass
{
    static void Main(string[] args)
    {
        /*string country = "india";
        string state = "southindia";
        object ob1 = country.Clone();
        Console.WriteLine(object.ReferenceEquals(country, ob1));
        Console.WriteLine(country.CompareTo(ob1)); // output  - 0
        Console.WriteLine(country.CompareTo(state)); //output - 1

        Console.WriteLine(state.Contains(country)); // output : true
        char[] cstate = new char[20];
        country.CopyTo(0, cstate, 0, 4);
        Console.Write(cstate);
        Console.Write(new string(cstate)); // will write the empty spaces also
        Console.WriteLine("OK");

        Console.WriteLine(country.Equals(state));
        Console.WriteLine(country == state); // == amd != operators are overloaded in string class.
        */

        /*string info = "E101,vaibhav,noida,12-01-2016";
        string[] details = info.Split(',','-');
        foreach(string s in details)
            Console.WriteLine(s);
        // Task : string array , string containing information as above taken from user , for doj display
        // format also like DD-MM-YYYY 
        // validate the employee id starting with E.
        // doj format
        // conact it by comma and maintain a new string into the array.
        // accept the details of 3 employees */

        /*string dd = "   trimexample   ";
        Console.Write(dd);
        Console.Write(dd.TrimEnd());
        Console.Write(dd.TrimStart());
        Console.WriteLine();

        string a = "11bz.,.indiza,,,,..";
        Console.WriteLine(a.TrimStart('.',','));
        Console.WriteLine(a.TrimEnd('.', ','));
        Console.WriteLine(a.Trim('.', ',','1','z'));
        */

        //empty strings
        string mobile = string.Empty;
        string email = "";
        string eid = " ";

        //format to display the date strings or currency into different formats

        Console.WriteLine(string.IsNullOrEmpty(mobile));
        Console.WriteLine(string.IsNullOrWhiteSpace(eid));


        string data = string.Join(",", "E103", "Deepak", "Delhi", "18-12-2015");
        Console.WriteLine(data); // can use in above example




        // working with Char

        char ch = 'a';
        char.IsControl(ch);

        // storing the key values
        Console.WriteLine("Press any navigation key");
        ConsoleKeyInfo ck = Console.ReadKey();

        if (ck.Key == ConsoleKey.UpArrow)
        {
            Console.WriteLine("Upper Pressed");
        }


        // Activity on keys ....
    }
}