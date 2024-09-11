q1-
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>X=(a/(b-c))</h1>
        <asp:Label ID="Label1" runat="server" Text="enter a"></asp:Label><br />
        <asp:TextBox ID="TXta" runat="server"  ></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="enter b"></asp:Label><br />
        <asp:TextBox ID="Txtb" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="enter c"></asp:Label><br />
        <asp:TextBox ID="Txtc" runat="server" ></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick ="Button1_Click"   />
        <asp:Label ID="result" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int a = int.Parse(TXta.Text);
        int b = int.Parse(Txtb.Text);
        int c = int.Parse(Txtc.Text);
        float d = (float)(a / (b - c));
        result.Text = "answer is" + d;
    }
}

q2-
  double s, p;
        double a = double.Parse(TXta.Text);
        double b = double.Parse(Txtb.Text);
        double c = double.Parse(Txtc.Text);
        s=(a+b+c)/2;
        p = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        result.Text = "area is " + p;

<h1>area of triangle by herons formula</h1>
        <asp:Label ID="Label1" runat="server" Text="enter a"></asp:Label><br />
        <asp:TextBox ID="TXta" runat="server"  ></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="enter b"></asp:Label><br />
        <asp:TextBox ID="Txtb" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="enter c"></asp:Label><br />
        <asp:TextBox ID="Txtc" runat="server" ></asp:TextBox><br />
        <asp:Button ID="resul" runat="server" Text="Button" OnClick ="Button1_Click"   /><br />
        <asp:Label ID="result" runat="server" Text="Label"></asp:Label>

q3-

double g, f,h,i,j,k;
        double a = double.Parse(TXta.Text);
        double b = double.Parse(Txtb.Text);
        double c = double.Parse(Txtc.Text);
        double d = double.Parse(Txtd.Text);
        g = (double)b - a;
        f = (double)d - c;
        h = g * g;
        i = f * f;
        k = h + i;
        j = Math.Sqrt(k);
        result.Text = "distance is" + j;

<h1>Distance between two points</h1>
        <asp:Label ID="Label1" runat="server" Text="enter x1"></asp:Label><br />
        <asp:TextBox ID="TXta" runat="server"  ></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="enter x2"></asp:Label><br />
        <asp:TextBox ID="Txtb" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="enter y1"></asp:Label><br />
        <asp:TextBox ID="Txtc" runat="server" ></asp:TextBox><br />
         <asp:Label ID="Label4" runat="server" Text="enter y2"></asp:Label><br />
        <asp:TextBox ID="Txtd" runat="server" ></asp:TextBox><br />
        <asp:Button ID="resul" runat="server" Text="Button" OnClick="resul_Click"     /><br />
        <asp:Label ID="result" runat="server" ></asp:Label>

q4-
int i;
        double sum=0.0;
        int a = int.Parse(Tex.Text);
        for(i=1; i<= a; i++)
        {
            sum = sum + 1 / (float)i;
        }
        result.Text = "sum is" + sum;

 <asp:Label ID="Label1" runat="server" Text="enter n"></asp:Label><br />
        <asp:TextBox ID="Tex" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"    /><br />
        <asp:Label ID="result" runat="server" Text="Label"></asp:Label>

q5-
 float n = float.Parse(Tex.Text);
        float p = n * 100;
        result.Text = "paisa is" + p;

 <asp:Label ID="Label1" runat="server" Text="enter money"></asp:Label><br />
        <asp:TextBox ID="Tex" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click"    /><br />
        <asp:Label ID="result" runat="server" Text=""></asp:Label>

q6-
int n = int.Parse(Tex.Text);
        int p, q,r;
        r = n / 30;
        p = n % 30;    
       month.Text = "months is" + r;
        day.Text = "days are " + p;

<asp:Label ID="Label1" runat="server" Text="enter days"></asp:Label><br />
        <asp:TextBox ID="Tex" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click"    /><br />
        <asp:Label ID="month" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="day" runat="server" Text=""></asp:Label>

q7-

double i;
        int a = int.Parse(TextBox1.Text);
        for (i = 1; i < a; i++)
        {
            double p = Math.Sqrt(i);
            double q = Math.Floor(p);
            if (p == q)
            {
                Response.Write( p*p);
            }
        }

 <h1>square numbers</h1>
        <asp:Label ID="Label1" runat="server" Text="enter no."></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="click" OnClick="Button1_Click"    /><br />
        <asp:DataList ID="DataList1" runat="server"></asp:DataList>

q8-
a) int x = 2,i,p=0;
        Console.WriteLine(x);
        for (i = 1; i <= 3; i++)
        {

            p = x * x;
            Console.WriteLine( p);
            x= p;
        }

b)
int a = 1, b = 2,i,p=0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }
            else
            {
                a = a * b;
                Console.WriteLine(a);
            }

c)
int i;
        double b;
    
        for (i = 1; i < 7; i++)
        {
            b = Math.Pow(2, i);
            Console.WriteLine(b);

        }

d)
int i,j,p=2;
        Console.Write(p);
            for (j = 1; j < 7; j++)
            {
                p = p + j;
                Console.Write(p);


e)
 int i, a = 65;
        for (i = 0; i < 10; i++)
        {
            if (a % 2 == 1)
            {
                Console.WriteLine((char)a);
                
            }
            a++;
        }

f)
int i, a = 90;
        for (i = 0; i < 10; i++)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine((char)a);
                
            }
            a--;
        }

