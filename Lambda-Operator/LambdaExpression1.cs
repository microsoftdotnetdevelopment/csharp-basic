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
        //declaring delegate 
        public delegate void delg();
        public static void underwork()
        {
            Console.WriteLine("I am underwork");
        }
        

        static void Main(string[] args)
        {
            //passing the reference of method into delegate, method is static so no need to create the instance of class while passing reference in delegate.
            // In .Net 1.0 developers used to pass the reference of function to the delegate as below:

            delg work = new delg(underwork);
            work();


            // in .NET 2.0 and above .NET provides the concepts of Anonymous methods means methods without names and can be declared directly with delegate
            delg work1 = delegate() { Console.WriteLine("I am Called anonymously"); };
            work1();


            // in .NET 3.5 and above .NET introduced Lambda expression to override the concepts of anonymous method...
            delg work2 = () => { Console.WriteLine("I am called by Lambda operator"); };
            work2();
        }
    }
}
