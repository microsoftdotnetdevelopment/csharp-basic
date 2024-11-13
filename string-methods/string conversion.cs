// Ex:1-Convert string to int
using System;

class Program
{
    static void Main(String[] args)
    {
        int number = 0;
        Console.WriteLine("Enter number between 10 and 100 : ");
        string enteredNumber = Console.ReadLine();
        int.TryParse(enteredNumber, out number);
        Console.WriteLine("Have you entered number between 10 and 100 ?  " + (number > 10 && number < 100));
        Console.Read();
    }
}
// o/p-
// Enter number between 10 and 100 :
// 14
// Have you entered number between 10 and 100 ?  True