using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        // example of delegate with one refernce
        //declaring delegate without return type and one parameter
        public delegate void dowork(string task);

        //creating function1
        public static void task(string s)
        {
            Console.WriteLine("I am " + s);
        }
        
        static void Main(string[] args)
        {
            //passing the reference of method into delegate, method is static so no need to create the instance of class while passing reference in delegate.
            dowork work = new dowork(task);
           
            work("studing");
        }
    }
}
