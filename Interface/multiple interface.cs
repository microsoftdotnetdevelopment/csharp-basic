using System;

interface Isoftware
{
    void Hello();
}

interface IHardware
{
    void Hello();
}

class Test : Isoftware, IHardware
{
    void Isoftware.Hello()
    {
        Console.WriteLine("This is Software industry");
    }

    void IHardware.Hello()
    {
        Console.WriteLine("This is complete Hardware");
    }
}

public class interfacetest
{
    public static void Main()
    {
        Isoftware Obj1 = new Test();
        Obj1.Hello();

        IHardware Obj2 = new Test();
        Obj2.Hello();
    }
}

namespace Explicit
{
    class Program
    {
        interface techfunda              
        {
            void Test();
        }

        interface dotnetfunda              
        {
            void Test();
        }

        class MyClass : techfunda, dotnetfunda  
        {
            public void Test()
            {
                Console.WriteLine("This is techfunda website");
            }

            void dotnetfunda.Test()             
            {
                Console.WriteLine("This is dotnetfunda website");
            }
        }

        static void Main1()
        {
            MyClass my = new MyClass();
            my.Test();                  

            ((dotnetfunda)my).Test();     
        }
    }
}