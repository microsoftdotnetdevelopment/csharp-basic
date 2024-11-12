using System;

class EmailId
{
    static void Main()
    {
        int i, j = 0;
        string n = Console.ReadLine();
        for (i = 0; i < n.Length; i++)
        {
            if (n[i] == '@')
            {
                break;
            }
        }
        for (j = i + 1; j < n.Length; j++)
        {
            Console.Write(n[j]);
        }

        //Binary search predefined function
        Console.WriteLine("Enter Number of Elements you Want to Hold in the Array ? ");
        string s = Console.ReadLine();
        int x = Int32.Parse(s);
        int[] a = new int[x];
        Console.WriteLine("Enter Array Elements :");
        for (int v = 0; v < x; j++)
        {
            string s1 = Console.ReadLine();
            a[v] = Int32.Parse(s1);
        }
        Array.Sort(a);
        Console.WriteLine("Sorted Array : ");
        for (int sd = 0; sd < x; sd++)
        {
            Console.WriteLine("{0}", a[sd]);
        }
        Console.WriteLine("Enter the Element to be Searched : ");
        string s3 = Console.ReadLine();
        int x2 = Int32.Parse(s3);
        int x3 = Array.BinarySearch(a, (Object)x2);
        Console.WriteLine("BinarySearch: " + x3);
        Console.WriteLine("Element {0} is {1}", x3, a[x3]);
        Console.Read();
    }

}