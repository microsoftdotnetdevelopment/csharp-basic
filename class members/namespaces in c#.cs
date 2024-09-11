

using System;
using first_space;
using second_space;

namespace ABC
{
    namespace XYZ
    {
        namespace PQR
        {
            //Our Types(Classes,Interfaces,Structures,Delegates,Enumerations etc..)
            class Customer
            {
                //Class code
            }
        }
    }
}

// namespace ABC.XYZ.PQR //Nesting namespaces using dot operator


namespace first_space
{
   class namespace_cl
   {
      public void func()
      {
         Console.WriteLine("Inside first_space");
      }
   }
}

namespace second_space
{
   class namespace_cl
   {
      public void func()
      {
         Console.WriteLine("Inside second_space");
      }
   }
}

class TestClass
{
   static void Main(string[] args)
   {
      first_space.namespace_cl fc = new first_space.namespace_cl();
      second_space.namespace_cl sc = new second_space.namespace_cl();
      fc.func();
      sc.func();
      Console.ReadKey();
   }
}



namespace first_space
{
   class abc
   {
      public void func()
      {
         Console.WriteLine("Inside first_space");
      }
   }
}

namespace second_space
{
   class efg
   {
      public void func()
      {
         Console.WriteLine("Inside second_space");
      }
   }
}   

class TestClass1
{
   static void Main1(string[] args)
   {
      abc fc = new abc();
      efg sc = new efg();
      fc.func();
      sc.func();
      Console.ReadKey();
   }
}