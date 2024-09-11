using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        // example of delegate with mutliple references
        //declaring delegate without return type
        public delegate void dowork();

        //creating function1
        public static void studing()
        {
            Console.WriteLine("I am studing ");
        }
        public static void playing()
        {
            Console.WriteLine("I am Playing");

        }
        public static void watching()
        {
            Console.WriteLine("I am watching");
        }
        static void Main(string[] args)
        {
            //passing the reference of method into delegate, method is static so no need to create the instance of class while passing reference in delegate.
            dowork work = new dowork(studing);
            work += new dowork(playing);
            work += new dowork(watching);
            work();
        }
    }
}
