q1-
 int i,r=1;
        int n = int.Parse(Txtfn.Text);
        int q = int.Parse(TextBox1.Text);
        for(i=0;i< q; i++)
        {
            r = r * n;
        }
        Label3.Text = "result is" + r;

q2-
 int i,q,p;
        for (p = 1; p < 10; p++)
        {
            for (i = 1; i <= 10; i++)
            {
                q = p * i;
                Response.Write(q);
            }

q3-

int q=0,i;
        int p = int.Parse(Txtfn.Text);
        string r = p.ToString();
        for (i = 0; i <r.Length ; i++)
        {
            q = q * 10;
            q = q + p % 10;
            p = p / 10;
            }
        Label11.Text = "vgv" + q;

q4-
 int q,i=0;
        int p = int.Parse(Txtfn.Text);
        string po = p.ToString();

        int[] a = new int[10];
while(p!=0)
        {
            a[i] = p % 2;
            p = p / 2;
            i++;
        }
        for (q=i-1;q>=0;q--)
        {
            Response.Write(a[q]);
        }

q5-
using System;
class Program
{
    int i, j;
    public void neww()
    {
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 18; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public void newww()
    {
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j <5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public void ne()
    {
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 18; j++)
            {
                if (j < 13)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }

            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        Program ob = new Program();
        ob.neww();
        ob.newww();
        ob.neww();
        ob.ne();
        ob.neww();
        }
            
        }


q6-
a)
 int i,j;
        char a = 'Q';
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 5; j++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }

b)
 int i,j;
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 5; j++)
            {
                if (i == 0 || i == 4 || j==0 || j==4)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

c)
 int i,j;
        char a = 'Q', b = 'R';
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 5; j++)
            {
                if (i==2 && j==2)
                {
                    Console.Write(b);
                }
                else
                {
                    Console.Write(a);
                }
            }
            Console.WriteLine();