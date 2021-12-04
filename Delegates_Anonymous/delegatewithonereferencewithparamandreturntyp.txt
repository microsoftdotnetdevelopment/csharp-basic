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
        //declaring delegate with int return type and two parameters
        public delegate int calc(int x,int y);

        //creating function1
        public static int add(int x, int y)
        {
            return x + y;
        }
        
        static void Main(string[] args)
        {
            //passing the reference of method into delegate, method is static so no need to create the instance of class while passing reference in delegate.
            calc work = new calc(add);
            int sum = work(2, 3);
            Console.WriteLine("The sum is : " + sum);
           
            
        }
    }
}
