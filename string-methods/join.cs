
using System;
class Program
{
    static void Main()
    {
        string[] arr = { "dotnetfunda", "Techfuda", "Itfunda" };

        Console.WriteLine(string.Join(",", arr));


    }
}
// o/p
// dotnetfunda,Techfuda,Itfunda

class Program1
{
    static void Main1(string[] args)
    {
        int i;
        string[] eid = new string[3];
        string[] name = new string[3];
        int[] date = new int[3];
        int[] month = new int[3];
        int[] year = new int[3];
        string[] list = new string[20];
        for (i = 0; i < 3; i++)
        {
            Console.WriteLine("enter the employee id");
            eid[i] = Console.ReadLine();
            if (eid[i].Contains("e") == true)
            {
                Console.WriteLine("enter employee name");
                name[i] = Console.ReadLine();
                Console.Write("enter joining date");
                date[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("enter month");
                month[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("enter year");
                year[i] = int.Parse(Console.ReadLine());
                string s = string.Format("{0}-{1}-{2}", date[i], month[i], year[i]);
                Console.WriteLine(s);
                list[i] = string.Join(eid[i], name[i], s);
                Console.WriteLine(list[i]);
            }
        }
    }
}
// o/p-
// enter the employee id
// seta
// enter employee name
// tara
// enter joining date23
// enter month
// 12
// enter year
// 2016
// 23-12-2016
// taraseta23-12-2016