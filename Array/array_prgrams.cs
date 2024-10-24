using System;
using System.Text;
namespace ArrayApplication
{
    class MyArray
    {
        double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;
            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }

        static void Main()
        {
            MyArray app = new MyArray();

            /* an int array with 5 elements */
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            /* pass pointer to the array as an argument */
            avg = app.getAverage(balance, 5);

            /* output the returned value */
            Console.WriteLine("Average value is: {0} ", avg);
            Console.ReadKey();
        }
    }

    class ReverseArray
    {
        public static void ReverseSortedArray()
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Console.Write("Original Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Reverse(temp);
            Console.Write("Reversed Array: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Sort(list);
            Console.Write("Sorted Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class SamplesArray
    {

        public static void ArrayPrint()
        {

            // Creates and initializes a new integer array and a new Object array.
            int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
            Object[] myObjArray = new Object[5] { 26, 27, 28, 29, 30 };

            // Prints the initial values of both arrays.
            Console.WriteLine("Initially,");
            Console.Write("integer array:");
            PrintValues(myIntArray);
            Console.Write("Object array: ");
            PrintValues(myObjArray);

            // Copies the first two elements from the integer array to the Object array.
            System.Array.Copy(myIntArray, myObjArray, 2);

            // Prints the values of the modified arrays.
            Console.WriteLine("\nAfter copying the first two elements of the integer array to the Object array,");
            Console.Write("integer array:");
            PrintValues(myIntArray);
            Console.Write("Object array: ");
            PrintValues(myObjArray);

            // Copies the last two elements from the Object array to the integer array.
            System.Array.Copy(myObjArray, myObjArray.GetUpperBound(0) - 1, myIntArray, myIntArray.GetUpperBound(0) - 1, 2);

            // Prints the values of the modified arrays.
            Console.WriteLine("\nAfter copying the last two elements of the Object array to the integer array,");
            Console.Write("integer array:");
            PrintValues(myIntArray);
            Console.Write("Object array: ");
            PrintValues(myObjArray);
        }


        public static void PrintValues(Object[] myArr)
        {
            foreach (Object i in myArr)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
        }

        public static void PrintValues(int[] myArr)
        {
            foreach (int i in myArr)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
        }
    }
    /* 
    This code produces the following output.

    Initially,
    integer array:  1       2       3       4       5
    Object array:   26      27      28      29      30

    After copying the first two elements of the integer array to the Object array,
    integer array:  1       2       3       4       5
    Object array:   1       2       28      29      30

    After copying the last two elements of the Object array to the integer array,
    integer array:  1       2       3       29      30
    Object array:   1       2       28      29      30
    */

    public class SamplesArray2
    {

        public static void ThreeDArray()
        {

            // Creates and initializes a new three-dimensional Array of type Int32.
            Array myArr = Array.CreateInstance(typeof(Int32), 2, 3, 4);
            for (int i = myArr.GetLowerBound(0); i <= myArr.GetUpperBound(0); i++)
                for (int j = myArr.GetLowerBound(1); j <= myArr.GetUpperBound(1); j++)
                    for (int k = myArr.GetLowerBound(2); k <= myArr.GetUpperBound(2); k++)
                    {
                        myArr.SetValue((i * 100) + (j * 10) + k, i, j, k);
                    }

            // Displays the properties of the Array.
            Console.WriteLine("The Array has {0} dimension(s) and a total of {1} elements.", myArr.Rank, myArr.Length);
            Console.WriteLine("\tLength\tLower\tUpper");
            for (int i = 0; i < myArr.Rank; i++)
            {
                Console.Write("{0}:\t{1}", i, myArr.GetLength(i));
                Console.WriteLine("\t{0}\t{1}", myArr.GetLowerBound(i), myArr.GetUpperBound(i));
            }

            // Displays the contents of the Array.
            Console.WriteLine("The Array contains the following values:");
            PrintValues(myArr);
        }


        public static void PrintValues(Array myArr)
        {
            System.Collections.IEnumerator myEnumerator = myArr.GetEnumerator();
            int i = 0;
            int cols = myArr.GetLength(myArr.Rank - 1);
            while (myEnumerator.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}", myEnumerator.Current);
            }
            Console.WriteLine();
        }
    }
    /* 
    This code produces the following output.

    The Array has 3 dimension(s) and a total of 24 elements.
        Length    Lower    Upper
    0:    2    0    1
    1:    3    0    2
    2:    4    0    3
    The Array contains the following values:
        0    1    2    3
        10    11    12    13
        20    21    22    23
        100    101    102    103
        110    111    112    113
        120    121    122    123
    */

    public class Exercise
    {
        public static int CreateData()
        {
            int length = 2;
            Array Numbers = Array.CreateInstance(typeof(double), length);

            return 0;
        }
    }

    public class Exercise1
    {
        public static int VarkeywordDeclareVariable()
        {
            int length = 2;
            var Numbers = Array.CreateInstance(typeof(double), length);

            return 0;
        }
    }


    public class Exercise2
    {
        static int CreateInstanceData()
        {
            var Numbers = Array.CreateInstance(typeof(double), 5);

            Numbers.SetValue(7628.937, 0);
            Numbers.SetValue(6.48, 1);
            Numbers.SetValue(574.9, 2);
            Numbers.SetValue(293749.064, 3);
            Numbers.SetValue(0.70257, 4);

            return 0;
        }
    }

    public class Exercise3
    {
        static int DoubleType()
        {
            var Numbers = new double[5];

            Numbers.SetValue(7628.937, 0);
            Numbers.SetValue(6.48, 1);
            Numbers.SetValue(574.9, 2);
            Numbers.SetValue(293749.064, 3);
            Numbers.SetValue(0.70257, 4);

            Console.WriteLine("Number: {0}", Numbers.GetValue(0));

            return 0;
        }
    }

    class Program
    {
        public static void RandomlyGenerateStrings()
        {
            int s, i;
            char ch;
            s = int.Parse(Console.ReadLine());
            Random r = new Random();
            StringBuilder builder = new StringBuilder();
            for (i = 0; i < s; i++)
            {
                ch = Convert.ToChar((r.Next(65, 92)));
                builder.Append(ch);
            }

            Console.WriteLine(builder);
        }
    }

    class twodmatrix
    {
        int m, n;
        int[,] a;
        int[] b;
        twodmatrix(int x, int y)
        {
            m = x;
            n = y;
            a = new int[m, n];
            b = new int[m * n];
        }
        public void readmatrix()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("a[{0},{1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void printd()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);

                }
                Console.Write("\n");
            }
        }
        public void convert()
        {
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[k++] = a[i, j];
                }
            }
        }
        public void printoned()
        {
            for (int i = 0; i < m * n; i++)
            {
                Console.WriteLine("{0}\t", b[i]);
            }
        }


        public static void Matrix()
        {
            twodmatrix obj = new twodmatrix(2, 3);
            Console.WriteLine("Enter the Elements : ");
            obj.readmatrix();
            Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
            obj.printd();
            obj.convert();
            Console.WriteLine("\t\t Converted 1-D Array is : ");
            obj.printoned();
            Console.ReadLine();
        }

        public static void LengthOfArray()
        {
            int[] arrayA = new int[5];
            int lengthA = arrayA.Length;
            Console.WriteLine("Length of ArrayA : {0}", +lengthA);
            long longLength = arrayA.LongLength;
            Console.WriteLine("Length of the LongLength Array  : {0}", longLength);
            int[,] twoD = new int[5, 10];
            Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);
            Console.ReadLine();
        }

        public static void JaggedArray()
        {
            //Jagged Arrays can store efficiently many rows of varying lengths. Any type of data, reference or value, can be used
            int[][] jag = new int[3][];
            jag[0] = new int[2];
            jag[0][0] = 11;
            jag[0][1] = 12;
            jag[1] = new int[1] { 11 };
            jag[2] = new int[3] { 14, 15, 16 };
            for (int i = 0; i < jag.Length; i++)
            {
                int[] innerArray = jag[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.WriteLine(innerArray[a] + " ");
                }
            }
            Console.Read();
        }
    }


}















