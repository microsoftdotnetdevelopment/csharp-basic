using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinqExamples
{
   
    class myclass
    {
        static void Main(string[] args)
        {
           
            string[] fruits = { "Apple", "Grapes", "Pineapple", "Orange", "Mango" };
            var result = fruits.Select(s => s); // will select all items in fruits
            foreach (var f in fruits)
                Console.WriteLine(f);

            var results1 = fruits.Select(s => s.Substring(0, 3));
            foreach (string s in results1)
                Console.WriteLine(s);

                int[] numbers = { 1, 2, 3, 4, 5 };
var result = numbers.Select(n => n);
        foreach (var n in result) {
            Console.Write(n + " "); }


int[] numbers = { 1, 2, 3, 4, 5 };
        var result = numbers.Select(n => n + 1);
        foreach (var n in result) { Console.Write(n + " "); }
            
        }
    }
}
