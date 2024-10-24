using System;

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent Constructor.");
    }
    public virtual void print()
    {
        Console.WriteLine("I'm a Parent Class.");
    }
}
public class ChildClass : ParentClass
{
    public ChildClass()
    {
        Console.WriteLine("Child Constructor.");
    }
    public override void print()
    {
        Console.WriteLine("I'm a Child Class");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ParentClass parObj = new ChildClass();
        parObj.print();
        Console.Read();
    }
}
// In above example, when you run the program, at compile time the type of parObj is parentClass but it will still call the child class�s override method 
// because at the runtime, the type of the parObj object refers to is ChildClass.
// When you execute following code,it produces the following result:

// Parent Constructor.
// Child Constructor.
// I'm a Child Class