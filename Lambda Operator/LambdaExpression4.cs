using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        
        //declaring delegate 
        public delegate bool delg(int x,int y);
     
        

        static void Main(string[] args)
        {
            delg work1 = (x, y) => { return x == y; }; // Example of Lambda expression where you have to create {} curly braces with proper return keyword and other codes..
            delg work2 = (x,y) => x==y; // Example of Lambda statement where we need not to write curly braces and not need to write return keyword. it requires only code which will return itself
            Console.WriteLine(work1(2,7));
            Console.WriteLine(work2(2,7));

            //both above code will give the same result....


            //below code is the example of Func<> delegate which can be used for our working without use of creating userdefined delegates as above,,
            
            //below is the example of delegate with string return type as mentioned in angular brackets e.g.<string> and without parameter
            Func<string> work3 = () => {return "I am Called with Func";}; //Lambda expression with curly braces and proper return type
            Func<string> work4 = () => "I am called with Func"; // Lambda statement without curly braces and without return type..

            Console.WriteLine(work3());
            Console.WriteLine(work4());
            Console.WriteLine(work3.Invoke()); // You can also invoke like this...

            //below code is replacement of delegate declared above with one boolean return type and two int parameters,
            //by using Func<> which is itself works as delegate and accept return types and parameters inside angular brackets <>.

            Func<int,int,bool> work5 = (x,y) => x==y; // here Func<int,int,bool> has int,int are types of two parameters and bool is the type of return type...
            //will pass (x,y) as two parameter names
            Console.WriteLine(work5(2, 3)); // will pass 2 to x and 3 to y ...

            Func<int, int, int> work6 = (x, y) => x * y;
            Console.WriteLine(work6(4, 4));
        }
    }
}
