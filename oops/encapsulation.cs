using System;
// Ability to combine state and behaviour of object into single logical entity is encapsulation.
// The need of encapsulation is to protect or prevent the code (data) from accidental corruption due to the silly little errors that we are all prone to make

public class Car
{
    public string color = "White";
    private bool IsStart = false;

    //Its public – so accessible outside class
    public string GetColor()
    {
        return color;
    }

    //Its private – so not accessible outside class
    private bool StartEngine()
    {
        IsStart = true;
        return IsStart;
    }

    //Its private – so not accessible outside class
    private bool StopEngine()
    {
        IsStart = false;
        return IsStart;
    }

    //Its public – so accessible outside class
    public void GetStartCar()
    {
        //"StartEngine()" is private but accessible and limited to this class only
        StartEngine();
    }

    //Its public – so accessible outside class
    public void GetStopCar()
    {
        //"StopEngine()" is private but accessible and limited to this class only
        StopEngine();
    }

    //Its public – so accessible outside class
    public bool GetCarStatus()
    {
        return IsStart;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car objCar = new Car();

        Console.WriteLine("Car color is : " + objCar.GetColor()); //accessible outside "Car"

        //we can't call this method as it is inaccessible outside "Car"
        //objCar.StartEngine(); //commented because we can't access it

        Console.WriteLine("Start the  Car: "); //accessible outside

        objCar.GetStartCar();

        Console.WriteLine("Car started : " + objCar.GetCarStatus()); //accessible outside "Car"

        Console.WriteLine("Stop the  Car: "); //accessible outside

        objCar.GetStopCar();

        Console.WriteLine("Car started : " + objCar.GetCarStatus()); //accessible outside "Car"

        Console.Read();
    }
}
// When the above code is compiled and executed, it produces the following result:

// Car color is : White
// Start the  Car:
// Car started : True
// Stop the  Car:
// Car started : False


public class Department
{
    private string departname;

    // Accessor.
    public string GetDepartname()
    {
        return departname;
    }
    // Mutator.
    public void SetDepartname(string a)
    {
        departname = a;
    }
}


public class Department1
{
    private string departname;
    public string Departname
    {
        get
        {
            return departname;
        }
        set
        {
            departname = value;
        }
    }
}
public class Departmentmain
{
    public static int Mainn(string[] args)
    {
        Department1 d = new Department1();
        d.Departname = "Communication";
        Console.WriteLine("The Department is :{0}", d.Departname);
        return 0;
    }
}

