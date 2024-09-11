using System;
public delegate void mydele();
class program
{
    int[] a = { 3, 9, 1, 5, 4 };
    int[] b = { 12, 45, 7, 23, 99 };
    int[] t = new int[10];
    int i, j;
    public void merge()
    {
        for (i = 0; i < 5; i++)
        {
            t[i] = a[i];
        }
        for (j = 0; j < 5; j++)
        {
            t[i] = b[j];
            i++;
        }
        Console.WriteLine("result");
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(t[i]);
        }
        

    }
    public void sor()
    {
        Console.WriteLine("sorted array is");
        Array.Sort(t);
        foreach(var i in t)
        {
            Console.WriteLine(i);
        }
    }

    class th
    {
        static void Main(string[] args)
        {
            program ob = new program();
            mydele delg = new mydele(ob.merge);
            delg += new mydele(ob.sor);
            delg();
        }
    }
}
