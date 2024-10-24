// TryParse is using for determine whether a string is a valid representation of a specified numeric type or not.
// TryParse method that is implemented by all primitive numeric types and also by types such as DateTime and IPAddress.

using System;
class Program
{
    static void Main(String[] args)
    {
        int age;
        Console.WriteLine("Enter Your Age - ");
        string strAge = Console.ReadLine();
        if (int.TryParse(strAge, out age))
        {
            Console.WriteLine("Input is in correct format -" + age);
        }
        else
        {
            Console.WriteLine("Please enter the correct value");
        }
        Console.ReadKey();

        bool isNumeric;
        int i;
        string str = "100";
        isNumeric = int.TryParse(str, out i);
        Console.WriteLine("The value of i is " + i);
    }
}
// o/p-
// Enter Your Age -
// 23
// Input is in correct format -23


