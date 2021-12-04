q1-
int a = int.Parse(Txtfn.Text);
        int b = int.Parse(Txtsn.Text);
        int c = int.Parse(TextBox1.Text);
        Label5.Text = "BEFORE swapping " + a + b + c;
        int t;
        t = a;
        a = b;
        b = c;
        c = t;
        Label3.Text = "after swap" + a + b + c;

q2-
int i,p=0;
        float a = float.Parse(Txtfn.Text);
        string n = a.ToString();
       
        for(i=0;i< n.Length-1; i++)
        {
            p++;
        }
        Label3.Text = "hh" + n[p];
q3-

using System;
class Program
{
    static void Main(string[] args)
    {
        int i, a = 5, j, b;
        for (i = 5; i <=8; i++)
        {
            for (j = i; j <= 8; j++)
            {
                Console.Write(j);
             

            }

            Console.WriteLine();
        }
    }
  
        }



q4-
int i,p=0,sum=0;
        int a = int.Parse(Txtfn.Text);
        string x = a.ToString();
        int c = x.Length;
        for(i=0;i<c; i++)
        {
           
            p = a % 10;
            a = a / 10;
            sum = sum + p;
           
        }
        Label3.Text = "hh" + sum;

q5-
  int a = int.Parse(Txtfn.Text);
        int b = int.Parse(TextBox1.Text);
        int c = int.Parse(TextBox2.Text);
        int d = (a > b && a > c ? a : b > c ? b : c);
        Label3.Text = "ma is" + d;

q6-

int a = int.Parse(Txtfn.Text);
        int b = int.Parse(TextBox1.Text);
        if (a % b == 0)
        {
            Label3.Text = "a is multiple of b";
        }
        else
        {
            Label3.Text = "not multiple";
        }

q7-

char a = char.Parse(Txtfn.Text);
        int b = (int)a;
        if(b>=65 && b <= 92)
        {
            b = b + 32;
            Label3.Text = "in small " + (char)b;
        }
        else if (b >= 97 && b <= 122)
        {
            b = b - 32;
            Label3.Text = "in caps " + (char)b;
        }

q8-
b) Console.WriteLine("WORD\nprocessing");
c)
int j = 0,i=0,k;
        string n = "word processing ";
        char[] p = new char[n.Length];
        char[] t = new char[n.Length];
        p = n.ToCharArray();     
        t[j++] = (char)(int)(p[i] ^ 32);
        t[j++] = '.';
        for (i = 0; i < n.Length - 1; i++)
        {
            if (p[i] == ' ')
            {
                k = (int)(p[i + 1] ^ 32);
                t[j++] = (char)(k);
                t[j++] = '.';
            }

        }
        Console.WriteLine(t);

q9-
int a = int.Parse(Txtfn.Text);
        int b = int.Parse(TextBox1.Text);
        int c = int.Parse(TextBox2.Text);
        int d = int.Parse(TextBox3.Text);
        if (c - d != 0)
        {
            float f = (float)(a + b) / (float)(c - d);
            Label3.Text = "Ratio is" + f;
        }

q10-
 int i,sum=0,p=0;
        for (i = 0; i < 100; i++)
        {
            if(i%6 == 0 && i % 4 != 0)
            {
                sum = sum + i;
                p++;
                Label1.Text = "total no." + p;
                Label3.Text = "um is" + sum;