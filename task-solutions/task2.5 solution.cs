

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, k, sum = 0;
            int[] answer = { 2, 4, 1, 3, 5, 4, 3, 2, 1, 3, 4, 5, 4, 2, 3, 1, 5, 2, 3, 1, 4, 2, 3, 1, 5 };
            int[,] student = new int[3, 25] { { 2, 3, 4, 3, 5, 1, 3, 2, 1, 3, 4, 5, 2, 1, 3, 2, 3, 1, 4, 3, 4, 1, 3, 1, 5, },
                { 2, 4, 1, 4, 5, 2, 3, 2, 4, 3, 5, 4, 4, 2, 1, 3, 5, 2, 3, 4, 1, 2, 3, 1, 3},
               { 3, 4, 1, 3, 5, 4, 3, 2, 1, 3, 5, 4, 4, 3, 2, 1, 5, 3, 1, 4, 4, 2, 3, 1, 5} };
            int[] marks = { 1, 1, 2, 1, 2, 1, 3, 1, 2, 1, 2, 4, 1, 3, 2, 2, 4, 1, 2, 3, 2, 1, 1, 2, 3 };

            for (k = 0; k < 3; k++)
            {
                for (j = 0; j < 25; j++)
                {
                    if (student[k, j] == answer[j])
                    {

                        sum = sum + marks[j];

                    }

                }
                Console.WriteLine("sum" + sum);
                sum = 0;


            }
        }
    }
}


class Program2A
{
    static void Main2A(string[] args)
    {
        char[,] city = new char[6, 6] { { 'M', 'C', 'B', 'D', 'M', 'B' } ,
            {'C','D', 'M', 'B', 'D', 'C'  }, { 'C','C', 'C', 'M', 'M', 'C' }
        , {'D', 'D', 'M', 'M', 'B', 'B'  }, { 'D', 'C', 'B', 'M', 'C', 'B' },
            {'D', 'M', 'C', 'D', 'M', 'C' } };
        int[,] car = new int[6, 6] { {1, 2, 3, 1, 2, 4  }, { 1, 3, 4, 2, 1, 3 }, {4, 4, 1, 1, 3, 3  },
        {1, 1, 2, 2, 4, 4  }, {1, 2, 3, 1, 2, 1  }, { 3, 4, 1, 2, 3, 4 }};
        int i, j, k = 1, q = 1, w = 0, r = 0, z = 0, x = 0, c = 0, v = 0, a = 0, s = 0, d = 0, f = 0, l = 0, u = 0, o = 0, y = 0;
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if (city[i, j] == 'M')
                {

                    if (car[i, j] == 1)
                    {
                        k++;
                    }
                    else if (car[i, j] == 2)
                    {
                        q++;
                    }
                    else if (car[i, j] == 3)
                    {
                        w++;
                    }
                    else
                    {
                        r++;
                    }
                }

                else if (city[i, j] == 'D')
                {
                    if (car[i, j] == 1)
                    {
                        z++;
                    }
                    else if (car[i, j] == 2)
                    {
                        x++;
                    }
                    else if (car[i, j] == 3)
                    {
                        c++;
                    }
                    else
                    {
                        v++;
                    }
                }

                else if (city[i, j] == 'C')
                {
                    if (car[i, j] == 1)
                    {
                        a++;
                    }
                    else if (car[i, j] == 2)
                    {
                        s++;
                    }
                    else if (car[i, j] == 3)
                    {
                        d++;
                    }
                    else
                    {
                        f++;
                    }
                }

                else
                {
                    if (car[i, j] == 1)
                    {
                        l++;
                    }
                    else if (car[i, j] == 2)
                    {
                        u++;
                    }
                    else if (car[i, j] == 3)
                    {
                        o++;
                    }
                    else
                    {
                        y++;
                    }
                }


            }
        }
        Console.WriteLine("Madras-{0} Ambassdar{1}fiat {2} duster {3} maruti", k, q, w, r);
        Console.WriteLine("Delhi-{0} ambassdar{1}fiat{2}duster{3}maruti", z, x, c, v);
        Console.WriteLine("Calcutta-{0}ambassdar{1}fiat{2}dustee{3}maruti", a, s, d, f);
        Console.WriteLine("Bombay-{0}amnassdar{1}fiat{2}duster{3}maruti", l, u, o, y);

    }
}

class Program2B
{
    static void Main2B(string[] args)
    {
        char[,] city = new char[6, 6] { { 'M', 'C', 'B', 'D', 'M', 'B' } ,
            {'C','D', 'M', 'B', 'D', 'C'  }, { 'C','C', 'C', 'M', 'M', 'C' }
        , {'D', 'D', 'M', 'M', 'B', 'B'  }, { 'D', 'C', 'B', 'M', 'C', 'B' },
            {'D', 'M', 'C', 'D', 'M', 'C' } };
        int[,] car = new int[6, 6] { {1, 2, 3, 1, 2, 4  }, { 1, 3, 4, 2, 1, 3 }, {4, 4, 1, 1, 3, 3  },
        {1, 1, 2, 2, 4, 4  }, {1, 2, 3, 1, 2, 1  }, { 3, 4, 1, 2, 3, 4 }};
        int i, j, q = 0, w = 0, e = 0, r = 0;
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if (car[i, j] == 1)
                {
                    q++;
                }
                else if (car[i, j] == 2)
                {
                    w++;
                }
                else if (car[i, j] == 3)
                {
                    e++;
                }
                else
                {
                    r++;
                }



            }
        }
        if (q > w && q > e && q > e && q > r)
        {
            Console.WriteLine("ambassadar");
        }
        else if (w > q && w > e && w > r)
        {
            Console.WriteLine("fiat");
        }
        else if (e > q && e > w && e > r)
        {
            Console.WriteLine("duster");
        }
        else if (r > q && r > e && r > w)
        {
            Console.WriteLine("maruti");
        }

    }
}


class Program2D
{
    static void Main2D(string[] args)
    {
        char[,] city = new char[6, 6] { { 'M', 'C', 'B', 'D', 'M', 'B' } ,
            {'C','D', 'M', 'B', 'D', 'C'  }, { 'C','C', 'C', 'M', 'M', 'C' }
        , {'D', 'D', 'M', 'M', 'B', 'B'  }, { 'D', 'C', 'B', 'M', 'C', 'B' },
            {'D', 'M', 'C', 'D', 'M', 'C' } };

        int i, j, q = 0, w = 0, e = 0, r = 0;
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if (city[i, j] == 'M')
                {
                    q++;
                }
                else if (city[i, j] == 'D')
                {
                    w++;
                }
                else if (city[i, j] == 'C')
                {
                    e++;
                }
                else
                {
                    r++;
                }



            }
        }
        if (q > w && q > e && q > e && q > r)
        {
            Console.WriteLine("madras");
        }
        else if (w > q && w > e && w > r)
        {
            Console.WriteLine("delhi");
        }
        else if (e > q && e > w && e > r)
        {
            Console.WriteLine("calcutta");
        }
        else if (r > q && r > e && r > w)
        {
            Console.WriteLine("bombay");
        }

    }
}

class Program2E
{
    static void Main2E(string[] args)
    {
        char[,] city = new char[6, 6] { { 'M', 'C', 'B', 'D', 'M', 'B' } ,
            {'C','D', 'M', 'B', 'D', 'C'  }, { 'C','C', 'C', 'M', 'M', 'C' }
        , {'D', 'D', 'M', 'M', 'B', 'B'  }, { 'D', 'C', 'B', 'M', 'C', 'B' },
            {'D', 'M', 'C', 'D', 'M', 'C' } };
        int[,] car = new int[6, 6] { {1, 2, 3, 1, 2, 4  }, { 1, 3, 4, 2, 1, 3 }, {4, 4, 1, 1, 3, 3  },
        {1, 1, 2, 2, 4, 4  }, {1, 2, 3, 1, 2, 1  }, { 3, 4, 1, 2, 3, 4 }};
        int i, j, k = 1, q = 1, w = 0, r = 0, z = 0, x = 0, c = 0, v = 0, a = 0, s = 0, d = 0, f = 0, l = 0, u = 0, o = 0, y = 0;
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if (city[i, j] == 'M')
                {

                    if (car[i, j] == 1)
                    {
                        k++;
                    }
                    else if (car[i, j] == 2)
                    {
                        q++;
                    }
                    else if (car[i, j] == 3)
                    {
                        w++;
                    }
                    else
                    {
                        r++;
                    }
                }

                else if (city[i, j] == 'D')
                {
                    if (car[i, j] == 1)
                    {
                        z++;
                    }
                    else if (car[i, j] == 2)
                    {
                        x++;
                    }
                    else if (car[i, j] == 3)
                    {
                        c++;
                    }
                    else
                    {
                        v++;
                    }
                }

                else if (city[i, j] == 'C')
                {
                    if (car[i, j] == 1)
                    {
                        a++;
                    }
                    else if (car[i, j] == 2)
                    {
                        s++;
                    }
                    else if (car[i, j] == 3)
                    {
                        d++;
                    }
                    else
                    {
                        f++;
                    }
                }

                else
                {
                    if (car[i, j] == 1)
                    {
                        l++;
                    }
                    else if (car[i, j] == 2)
                    {
                        u++;
                    }
                    else if (car[i, j] == 3)
                    {
                        o++;
                    }
                    else
                    {
                        y++;
                    }
                }


            }
        }
        Console.WriteLine("choose car");
        Console.WriteLine("1.Ambassdar 2.fiat 3.duster 4.maruti");
        int carr = int.Parse(Console.ReadLine());
        switch (carr)
        {
            case 1:
                Console.WriteLine("madras {0},delhi {1},calcutta {2},bombay{3}", k, z, a, l);
                break;
            case 2:
                Console.WriteLine("madras {0},delhi {1},calcutta {2},bombay{3}", q, x, s, u);
                break;
            case 3:
                Console.WriteLine("madras {0},delhi {1},calcutta {2},bombay{3}", w, c, d, o);
                break;
            case 4:
                Console.WriteLine("madras {0},delhi {1},calcutta {2},bombay{3}", r, v, f, y);
                break;

        }

    }
}

class Program2F
{
    static void Main2F(string[] args)
    {
        char[,] city = new char[6, 6] { { 'M', 'C', 'B', 'D', 'M', 'B' } ,
            {'C','D', 'M', 'B', 'D', 'C'  }, { 'C','C', 'C', 'M', 'M', 'C' }
        , {'D', 'D', 'M', 'M', 'B', 'B'  }, { 'D', 'C', 'B', 'M', 'C', 'B' },
            {'D', 'M', 'C', 'D', 'M', 'C' } };
        int[,] car = new int[6, 6] { {1, 2, 3, 1, 2, 4  }, { 1, 3, 4, 2, 1, 3 }, {4, 4, 1, 1, 3, 3  },
        {1, 1, 2, 2, 4, 4  }, {1, 2, 3, 1, 2, 1  }, { 3, 4, 1, 2, 3, 4 }};
        int i, j, q = 0, w = 0, e = 0, r = 0;
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if (car[i, j] == 1)
                {
                    q++;
                }
                else if (car[i, j] == 2)
                {
                    w++;
                }
                else if (car[i, j] == 3)
                {
                    e++;
                }
                else
                {
                    r++;
                }



            }
        }
        Console.WriteLine("Ambassador : {0}, Fiat : {1}, Duster: {2} and Maruti : {3}", q, w, e, r);

    }
}

namespace ConsoleApplication3A
{
    class Program3A
    {
        static void Main3A(string[] args)
        {
            int i, j, k, temp;
            int[] ne = new int[5];
            int[] n = new int[5];
            Console.WriteLine("enter 1st array");
            for (i = 0; i < 5; i++)
            {

                ne[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter second array");
            for (i = 0; i < 5; i++)
            {

                n[i] = int.Parse(Console.ReadLine());
            }
            for (j = 0; j < ne.Length; j++)
            {
                for (i = 0; i < ne.Length - 1; i++)
                {
                    if (ne[i] > ne[i + 1])
                    {
                        temp = ne[i];
                        ne[i] = ne[i + 1];
                        ne[i + 1] = temp;
                    }
                }

            }
            for (j = 0; j < ne.Length; j++)
            {
                for (i = 0; i < ne.Length - 1; i++)
                {
                    if (n[i] > n[i + 1])
                    {
                        temp = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = temp;
                    }
                }

            }


            Console.WriteLine("first array");
            for (k = 0; k < 5; k++)
            {
                Console.WriteLine(ne[k]);
            }
            Console.WriteLine("second array");
            for (k = 0; k < 5; k++)
            {
                Console.WriteLine(n[k]);
            }
        }
    }
}

namespace ConsoleApplication3B
{
    class Program3B
    {
        static void Main3B(string[] args)
        {
            int i = 0, j = 0, k = 0, m, l, r, temp, x;
            int[] ne = new int[5];
            int[] n = new int[5];
            int[] re = new int[10];
            Console.WriteLine("enter 1st array");
            for (m = 0; m < 5; m++)
            {
                ne[m] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter second array");
            for (l = 0; l < 5; l++)
            {
                n[l] = int.Parse(Console.ReadLine());
            }

            while (i < 5 && j < 5)

                re[k++] = ne[i] < n[j] ? ne[i++] : n[j++];

            while (i < 5)
                re[k++] = ne[i++];


            while (j < 5)
                re[k++] = n[j++];





            for (x = 0; x < 10; x++)
            {

                for (r = 0; r < 9; r++)
                {
                    if (re[r] > re[r + 1])
                    {
                        temp = re[r];
                        re[r] = re[r + 1];
                        re[r + 1] = temp;
                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(re[i]);
            }
        }
    }

}

namespace ConsoleApplication3C
{
    class Program3C
    {
        static void Main3C(string[] args)
        {
            int i = 0, j = 0, k = 0, m, l, r, temp, x;
            int[] ne = new int[5];
            int[] n = new int[5];
            int[] re = new int[10];
            Console.WriteLine("enter 1st array");
            for (m = 0; m < 5; m++)
            {
                ne[m] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter second array");
            for (l = 0; l < 5; l++)
            {
                n[l] = int.Parse(Console.ReadLine());
            }

            while (i < 5 && j < 5)

                re[k++] = ne[i] < n[j] ? ne[i++] : n[j++];

            while (i < 5)
                re[k++] = ne[i++];


            while (j < 5)
                re[k++] = n[j++];





            for (x = 0; x < 10; x++)
            {

                for (r = 0; r < 9; r++)
                {
                    if (re[r] < re[r + 1])
                    {
                        temp = re[r];
                        re[r] = re[r + 1];
                        re[r + 1] = temp;
                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(re[i]);
            }
        }
    }

}

class Program4
{
    static void Main4(string[] args)
    {
        string n = Console.ReadLine();
        if ((n[0] >= 'a' && n[0] <= 'z') && (n[1] >= '0' && n[1] <= '9') && (n[2] >= '0' && n[2] <= '9') &&
            (n[3] >= '0' && n[3] <= '9') && (n[1] >= '0' && n[1] <= '9') && (n[1] >= '0' && n[1] <= '9') &&
            (n[6] >= '0' && n[6] <= '9') && (n[7] >= 'a' && n[7] <= 'z') && (n[8] >= 'a' && n[8] <= 'z') &&
            (n[9] >= '0' && n[9] <= '9'))
        {
            Console.WriteLine("correct");
        }
        else
        {
            Console.WriteLine("incorrect isbn");
        }
    }
}


class Program5A
{
    static void Main5A(string[] args)
    {
        Console.WriteLine("enter dob");
        Console.WriteLine("enter date");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("enter month");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("enter year");
        int y = int.Parse(Console.ReadLine());
        if (y >= 1900 && y <= 9999)
        {
            if (m >= 1 && m <= 12)
            {
                if ((d >= 1 && d < 31) && (m == 1 || m == 3 || m == 5 || m == 7 || m == 9 || m == 11))
                {
                    Console.WriteLine("date is valid");
                }
                else if ((d >= 1 && d <= 30) && (m == 4 || m == 6 || m == 8 || m == 10 || m == 12))
                {
                    Console.WriteLine("valid");
                }
                else if ((d >= 1 && d <= 28) && m == 2)
                {
                    Console.WriteLine("vvvvvvv");
                }
                else if ((d == 29 && m == 2) && (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0)))
                {
                    Console.WriteLine("po");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            else
            {
                Console.WriteLine("invalid month");
            }
        }
        else
        {
            Console.WriteLine("invalid year");
        }
    }
    static void Main5B()
    {
        Console.WriteLine("enter dob");
        Console.WriteLine("enter date");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("enter month");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("enter year");
        int y = int.Parse(Console.ReadLine());
        DateTime oldDate = new DateTime(y, m, d);
        DateTime newDate = DateTime.Now;
        TimeSpan ts = newDate - oldDate;
        int differenceInDays = ts.Days;
        Console.WriteLine("Difference in days: {0} ", differenceInDays);
    }


}

class Program5C
{
    static void Main5C(string[] args)
    {
        Console.WriteLine("enter dob");
        Console.WriteLine("enter date");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("enter month");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("enter year");
        int y = int.Parse(Console.ReadLine());
        if (y >= 1900 && y <= 9999)
        {
            if (m >= 1 && m <= 12)
            {
                if ((d >= 1 && d < 31) && (m == 1 || m == 3 || m == 5 || m == 7 || m == 9 || m == 11))
                {
                    Console.WriteLine("date is valid");
                }
                else if ((d >= 1 && d <= 30) && (m == 4 || m == 6 || m == 8 || m == 10 || m == 12))
                {
                    Console.WriteLine("valid");
                }
                else if ((d >= 1 && d <= 28) && m == 2)
                {
                    Console.WriteLine("vvvvvvv");
                }
                else if ((d == 29 && m == 2) && (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0)))
                {
                    Console.WriteLine("po");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            else
            {
                Console.WriteLine("invalid month");
            }
        }
        else
        {
            Console.WriteLine("invalid year");
        }

        Console.WriteLine("enter current date");
        Console.WriteLine("enter date");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("enter month");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("enter year");
        int r = int.Parse(Console.ReadLine());
        int diff = r - y;
        Console.WriteLine("you are" + diff + "years old");
    }

}

