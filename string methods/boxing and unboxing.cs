// Any type value or reference can be assigned to an object without an explicit conversion-boxing
// Unboxing is simply the opposite of boxing. In it values are again shifted from the heap to the stack. 
// In unboxing first of all it checks for the boxed object value and then it goes for replica creation or we can say for copying.
using System;
static void Sample()
{
    int a = 10;
    int b = 10;
    bool c = object.ReferenceEquals(a, b); //boxing example
    Console.WriteLine(c);
}
//  value type cannot have same reference
static void Sample1()
{
    string a = "sunny";
    Console.WriteLine(a[2]);
    // a[2] = 'u';
    Console.WriteLine(a);
    // o/p-It gives error
}
static void Sample2()
{
    string a = "sunny";
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i]);
    }
}
static void reversethestring()
{
    string a = "sunny";
    for (int i = a.Length - 1; i >= 0; i--)
    {
        Console.Write(a[i]);
    }
}
static void Sample3()
{
    string a = "adsc";
    string b = "adsc";
    bool c = object.ReferenceEquals(a, b); //boxing example
}
