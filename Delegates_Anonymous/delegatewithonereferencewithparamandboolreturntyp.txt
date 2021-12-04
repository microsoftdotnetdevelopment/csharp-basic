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
        public delegate bool chardelgate(string word,char ch);

        //creating function1
        public static bool CharCheck(string x, char y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == y)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            //passing the reference of method into delegate, method is static so no need to create the instance of class while passing reference in delegate.
            chardelgate work = new chardelgate(CharCheck);
            bool result = work("India", 'a');
            if (result)
                Console.WriteLine("Character Found ");
            else
                Console.WriteLine("Character Not Found");

           
            
        }
    }
}
