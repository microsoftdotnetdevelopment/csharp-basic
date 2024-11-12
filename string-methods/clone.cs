// It returns a object
using System;
static void Sample()
{
    string state = "southindia";
    object ob1 = state.Clone();
    Console.WriteLine(ob1);

    string state1 = "southindia";
    string st1 = "";
    st1 = (string)state1.Clone();
    Console.WriteLine(st1);

    string state2 = "southindia";
    string st2 = null;
    st2 = (string)state2.Clone();
    Console.WriteLine(st2);

    string country = "southindia";
    object ob11 = country.Clone();
    Console.WriteLine(object.ReferenceEquals(country, ob11));

    // Means it has two copies but both copies have same address

    string name = "tests";
    string b = null;
    b = (string)name.Clone();
    Console.WriteLine(b);

    string str = "Clone() Test";
    string clonedString = null;
    clonedString = (String)str.Clone();
    Console.WriteLine(clonedString);
}