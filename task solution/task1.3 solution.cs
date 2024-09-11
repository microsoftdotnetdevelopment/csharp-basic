using System;

// 1.Explain the difference between operator and operands?
// 1-Arithmetic operators
// 2-Relational operator
// 3-Logical operators
// 4-Bitwise operator
// 5-Assignment operator
// 6-Miscellaneous operator(sizeof,typeof,?:)

// 2.Explain the various operators availble in C#?

// 3.Write a program to identify whether a character eneterd by a user is a vowel or a consonant.

static void Main(string[] args)
        {
            char ch =char.Parse(Console.ReadLine());
            if(ch=='a' || ch=='e' || ch=='i'|| ch=='o' || ch=='u'){
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
// 4.Write the program to identify whether the number entered by a user is even or odd ?
static void OddEven(string[] args)
        {
            string a = Console.ReadLine();
            int num = int.Parse(a);
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
          }  }
            
// 5.Write a program to swap two numbers taken by user.
static void swapNumber(){
string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swapping" + a +b);
            }
// 6.Write program to check whether the entered year is leap year or not
static void enteredNumber(){
 Console.WriteLine("enter year");
            string yr = Console.ReadLine();
            int n = int.Parse(yr);
            if (n % 4 == 0 && (n % 400 == 0 || n % 100 != 0))
            {
                Console.WriteLine("leapyear");
            }
            else
            {
                Console.WriteLine("Not");
            }
}
// 7.Write a program of tax calculation. Accept money as input from the user and calculate the tax using following pattern.

// Money	Percentage	Total Tax
// Less than 10,000	3%	?
// 10,000 to 100,000	7%	?
// More than 100,000	9.5%	?
static void taxCalculation(){
 string n = Console.ReadLine();
            double num = double.Parse(n);
            if (num < 10000)
            {
                num = (num * 3) / 100;
                Console.WriteLine(num);
            }
            else if(num>10000 && num < 100000)
            {
                num = (num * 7) / 100;
                Console.WriteLine(num);
            }
            else if (num > 100000)
            {
                num = (num * 9.5) / 100;
                Console.WriteLine(num);
            }
}       
// 8.Write a program for library management system in which display the user option and based on option shows them available book.
// Option:
// c: for computer books
// m: for mathematical books
// h: for history books
// e: for English books
// If user input wrong value then shows them message try again and serve the input prompt again using goto label statement.
static void libraryManagement(){
char ch = char.Parse(Console.ReadLine());
switch (ch)
            {
                case 'c':
                    Console.WriteLine("for computer books");
                    break;
                case 'm':
                    Console.WriteLine("for math books");
                    break;
                case 'h':
                    Console.WriteLine("for history books");
                    break;
                case 'e':
                    Console.WriteLine("for english books");
                    break;

                default :
                    Console.WriteLine("try again");
                     break;
}
}
// 9.Write a program that finds the biggest of three integers, using nested if statements.
static void largestNumber(){
 string c = Console.ReadLine();
            string d = Console.ReadLine();
            string e = Console.ReadLine();
            int n = int.Parse(c);
            int a = int.Parse(d);
            int b= int.Parse(e);
            if (n>=a && n>= b)
            {
                Console.WriteLine(n);
            }
          if(a>=n && a>= b)
            {
                Console.WriteLine(a);
            }
 if(b>=n && b>=a)
            {
                Console.WriteLine(b);
            }  
}      
// 10.Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
// -     If the score is between 1 and 3, the program multiplies it by 10.
// -     If the score is between 4 and 6, the program multiplies it by 100.
// -     If the score is between 7 and 9, the program multiplies it by 1000.
// -     If the score is 0 or more than 9, the program prints an error message.

static void bonusPoints(){
 string n = Console.ReadLine();
            int num = int.Parse(n);
            if (num >0 && num<=3)
            {
                num = num * 10;
                Console.WriteLine(num);
            }
           else if (num > 3 && num <= 6)
            {

                num = num * 100;
                Console.WriteLine(num);

            }
           else if(num>6 && num <= 10)
            {
                num = num * 1000;
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("try again");
            }
}        
// 11.Write a C# program to detect key presses.
// If the user pressed number keys( from 0 to 9), the program will display the number that is pressed, otherwise the program will show "Not allowed".

static void detectkeyPresses(){
 string n = Console.ReadLine();
            int num = int.Parse(n);
           if(num>=0 && num <= 9)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Not allowed");
            }
}       
// 12.Accept any number and check whether a number is odd,multiple of 5 and greater than 30 and less than 100.
static void checkMultile(){
string a = Console.ReadLine();
            int n = int.Parse(a);
            if ((n % 2 == 1) && (n%5==0) &&(n>=30 && n<=100))
            {
                Console.WriteLine("in range" + n);
            }
            else
            {
                Console.WriteLine("not in range");
            }
}       
// 13.Display the menu to user like below :
// --------------------------------------------Food Menu List----------------------------------------------------
// |
// |					Welcome you in Food Cloud 
// |	Choose the fast food given below		
// |		
// |	Press	P:Pizza	150RS
// |	Press	B:Burger 50RS
// |	Press	S:Sandwich 30RS
// |	Press	V:VegRoll 30Rs
// |
// --------------------------------------------------------------------------------------------------------------
//  As per user's selection of food by providing the given character for food names like "P" for Pizza , you need to calculate the total prize by the following formula :

// 	Total cost = Food Cost(as given in list) + Service Tax(14%) + Maintenance Cost (5%) 

// After calculating the total food price , display the food item and it's total cost like below :

// Your Selected Food Item : Pizza
// Total Amoun to Pay : 178.5 RS
 
 
Console.WriteLine("--------------------------------------------Food Menu List----------------------------------------------------");
            Console.WriteLine("|");
            Console.Write("|");
            Console.Write("                           ");
            Console.WriteLine("        Welcome you in Food Cloud ");
            Console.Write("|");
            Console.Write("           ");
            Console.WriteLine("Choose the fast food given below	 ");
            Console.Write("");
            Console.WriteLine("|         Press	P:Pizza   	150RS");
            Console.WriteLine("|         Press	P:Burger	50RS");
            Console.WriteLine("|         Press	P:Sandwich	30RS");
            Console.WriteLine("|         Press	P:Vegroll	30RS");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            char ch = char.Parse(Console.ReadLine());

            float tc; 
            switch (ch)
            {
                case 'P':

                    tc = 150 + ((14 * 150) / 100) + ((5 * 150) / 100);
                    Console.WriteLine("Your Selected Food Item : pizza");
                    Console.WriteLine("Total Amount to Pay : " + tc);
                    break;
                case 'B':
                    tc = 50 + ((14 * 50) / 100) + ((5 * 50) / 100);
                    Console.WriteLine("Your Selected Food Item : Burger");
                    Console.WriteLine("Total Amount to Pay : " + tc);
                    break;
                case 'S':
                    tc = 30 + ((14 * 30) / 100) + ((5 * 30) / 100);
                    Console.WriteLine("Your Selected Food Item : Sandwich");
                    Console.WriteLine("Total Amount to Pay : " + tc);
                    break;
                case 'V':
                    tc = 30 + ((14 * 30) / 100) + ((5 * 30) / 100);
                    Console.WriteLine("Your Selected Food Item : Vegroll");
                    Console.WriteLine("Total Amount to Pay : " + tc);
                    break;
            }