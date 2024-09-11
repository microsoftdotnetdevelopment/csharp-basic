




public class Program1
    {
        public static void Main1()
        {
            int ch;
            do
            {
                Console.WriteLine("enter a no.");
                int num = int.Parse(Console.ReadLine());
                int aq = num * num;
                Console.WriteLine("Square is "+ aq);
                Console.WriteLine("\n enter 1 to continue ");
                ch = int.Parse(Console.ReadLine());
            }
            while (ch == 1);
            Console.ReadKey();
        }
    }
