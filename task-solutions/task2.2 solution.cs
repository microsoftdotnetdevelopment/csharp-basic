q1-
int a = int.Parse(Txtfn.Text);
        int b = int.Parse(Txtsn.Text);
        int bonus = a * 200;
        Label3.Text = "bonus is" + bonus;
        int to = b * a;
        Lvlresult.Text = "Total cost" + to;
       double com = to * .02;
        lvl.Text = "commision is" + com;

 <asp:Label ID="Label1" runat="server" Text="enter no. of computer sold"></asp:Label><br />
        <asp:TextBox ID="Txtfn" runat="server"></asp:TextBox><br /><br />
         <asp:Label ID="Label2" runat="server" Text="price of computer"></asp:Label><br />
        <asp:TextBox ID="Txtsn" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="calculate" OnClick="Button1_Click"   /><br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lvlresult" runat="server" ></asp:Label><br />
        <asp:Label ID="lvl" runat="server" ></asp:Label>

q2-

double a = double.Parse(Txtfn.Text);
        double b = double.Parse(Txtsn.Text);
        double c = double.Parse(TextBox1.Text);
        double d = Math.Sqrt((b * b) - (4 * a * c));
        double f = -b;
        double g = f + d;
        double h = g / (2 * a);
       
        double root2 = ((- b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
        Label3.Text = "root is" + h;
        Lvlresult.Text = "root2 is" + root2;


<asp:Label ID="Label1" runat="server" Text="enter a"></asp:Label><br />
        <asp:TextBox ID="Txtfn" runat="server"></asp:TextBox><br /><br />
         <asp:Label ID="Label2" runat="server" Text="enter b"></asp:Label><br />
        <asp:TextBox ID="Txtsn" runat="server"></asp:TextBox><br /><br />
                 <asp:Label ID="Label4" runat="server" Text="enter c"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="calculate" OnClick="Button1_Click"    /><br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lvlresult" runat="server" ></asp:Label><br />

q3-
a)invalid
b)false   correct is 10
c)true
d)true
e)not understand
f)false

q4-
int a;
float b;
a)false
b)true
c)

q7-
a)
 const double pi= 3.14;
        double a = double.Parse(Txtfn.Text);
        double b = double.Parse(Txtsn.Text);
        double area = (pi * a * a) + (2 * pi * a * b);
        Label3.Text = "area is " + area;

<asp:Label ID="Label1" runat="server" Text="enter a"></asp:Label><br />
        <asp:TextBox ID="Txtfn" runat="server"></asp:TextBox><br /><br />
         <asp:Label ID="Label2" runat="server" Text="enter b"></asp:Label><br />
        <asp:TextBox ID="Txtsn" runat="server"></asp:TextBox><br /><br />
                 
        <asp:Button ID="Button1" runat="server" Text="calculate" OnClick="Button1_Click"    /><br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />

b)
  
        double a = double.Parse(Txtfn.Text);
        double b = double.Parse(Txtsn.Text);
        double c = double.Parse(TextBox1.Text);
        double tor = ((2 * a * b / (a + b)) * c);
        Label3.Text = "torque is " + tor; 

  <asp:Label ID="Label1" runat="server" Text="enter a"></asp:Label><br />
        <asp:TextBox ID="Txtfn" runat="server"></asp:TextBox><br /><br />
         <asp:Label ID="Label2" runat="server" Text="enter b"></asp:Label><br />
        <asp:TextBox ID="Txtsn" runat="server"></asp:TextBox><br /><br />
              <asp:Label ID="Label4" runat="server" Text="enter b"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />   
        <asp:Button ID="Button1" runat="server" Text="calculate" OnClick="Button1_Click"    /><br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />

c)

const double pi = 3.14;
        double a = double.Parse(Txtfn.Text);
        double b = double.Parse(Txtsn.Text);
        double c = double.Parse(TextBox1.Text);
        double d = (c * pi) / 180;
        double h = Math.Sqrt((a* a)+(b* b) - 2 * a * b * Math.Cos(d));
       
        Label3.Text = "side is " +h;

d)

const double pi = 3.14;
        double a = double.Parse(Txtfn.Text);
        double b = double.Parse(Txtsn.Text);
        double c = double.Parse(TextBox1.Text);
        double d = double.Parse(TextBox2.Text);
        double ener = (a * (b * c + (d * d) / 2));
        Label3.Text = "area is" + ener;

