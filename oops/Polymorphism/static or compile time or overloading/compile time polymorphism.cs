using System;

class Program
{
    static void Main(string[] args)
    {
        Employee empObj = new Employee();

        //here 2nd method will be called with types "string, string"
        empObj.DislayName("David", "Ray");

        //here 1st method will be called with types "string"
        empObj.DislayName("Ricky Mike");
        Console.Read();
    }
}
public class Employee
{
    //1st: same method name, return type same but different parameter type (string)
    public void DislayName(string fullName)
    {
        Console.WriteLine(fullName);
    }
    //2nd: same method name, return type same but different parameter type (string, string)
    public void DislayName(string firstName, string lastName)
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}

// o/p-
// David Ray
// Ricky Mike