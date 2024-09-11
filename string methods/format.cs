
using System;

static void Sample()
{

    // String.Format("Today’s date is {0:D}", DateTime.Now);

    // String.Format("The current time is {0:T}", DateTime.Now);

    double dNum = 0;
    dNum = 32.123456789;
    Console.WriteLine("Formated String ” + string.Format("{ 0:N3}", dNum));
// O/p-
// 32.123

double dNum1 = 0;
dNum1 = 32.123456789;
Console.WriteLine("Formated String " + string.Format("{0:n4}", dNum1));  
}
