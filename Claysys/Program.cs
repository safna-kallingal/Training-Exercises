using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claysys
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //int a = 10, b = 2;
    //Console.WriteLine(a);
    //Console.WriteLine(b);
    //Console.WriteLine("sum is : {0}", a + b);
    //Console.ReadKey();


    // sum of 2 numbers

    //int i, j;
    //Console.WriteLine("enter number 1: ");
    //i = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("enter number 2: ");
    //j = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Sum : {0} ", i + j);
    //Console.ReadKey();




    ///  IF-Else condition ---------------------------------


    //wap to display largest of two numbers using if else

    //int i, j;
    //Console.WriteLine("enter number 1: ");
    //i = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("enter number 2: ");
    //j = Convert.ToInt32(Console.ReadLine());
    //if (i > j) 
    //{
    //    Console.WriteLine("Largest is : {0}", i);
    //}
    //else
    //{
    //    Console.WriteLine("Largest is : {0}", j);
    //}
    //Console.ReadKey();


    // if-else if--else -------------------


    //wap to check a number is +ve,-ve or 0

    //int i;
    //Console.WriteLine("enter a number: ");
    //i = Convert.ToInt32(Console.ReadLine());
    //if (i>0)
    //{
    //    Console.WriteLine("Number {0} is Positive", i);
    //}
    //else if (i < 0)
    //{
    //    Console.WriteLine("Number {0} is Negative", i);
    //}
    //else
    //{
    //    Console.WriteLine("Number is Zero");
    //}
    //Console.ReadKey();


    //NESTED IF-----------------------------------------------


    //wap to find largest of 3 nos using nested if.

    //int a, b, c;
    //Console.WriteLine("Enter a: ");
    //a = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Enter b: ");
    //b = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Enter c: ");
    //c = Convert.ToInt32(Console.ReadLine());
    //if(a>b)
    //{
    //    if (a>c)
    //    {
    //        Console.WriteLine("The largest number is a={0} ", a);
    //    }
    //    else
    //    {
    //        Console.WriteLine("The largest number is c={0} ", c);
    //    }
    //}
    //else if(b>c)
    //{
    //    Console.WriteLine("The largest number is b={0} ", b);
    //}
    //else
    //{
    //    Console.WriteLine("The largest number is c={0} ", c);
    //}
    //Console.ReadKey();


    // WHILE & DO-WHILE--------------------------------------------


    // wap to print 1st n natural numbers using while

    //int n, a = 1;
    //Console.WriteLine("Enter no : ");
    //n = Convert.ToInt32(Console.ReadLine());
    //while (n >= a)
    //{
    //    Console.WriteLine(a);
    //    a = a + 1;
    //}
    //Console.ReadKey();



    // using do-while---------------------------------------


    //int n, a = 0;
    //Console.WriteLine("Enter no : ");
    //n = Convert.ToInt32(Console.ReadLine());
    //do
    //{
    //    Console.WriteLine(a);
    //    a = a + 2;
    //}
    //while (a <= n);
    //Console.ReadKey();



    // Amstrong number

    //int a, rem, sve = 0, b;
    //Console.WriteLine("Enter number : ");
    //a = Convert.ToInt32(Console.ReadLine());
    //b = a;
    //while (a > 0)
    //{
    //    rem = a % 10;
    //    sve = sve + rem * rem * rem;
    //    a = a / 10;
    //}
    //if (b == sve)
    //{
    //    Console.WriteLine("amstrong");
    //}
    //else
    //{
    //    Console.WriteLine("not amstrong");
    //}
    //Console.ReadKey();



    // for loop

    // Factorial of a number

    //int a, b = 1;
    //Console.WriteLine("Number limit :");
    //a = Convert.ToInt32(Console.ReadLine());
    //for (int i = 1; i <= a; i++)
    //{
    //    b = b * i;
    //}
    //Console.WriteLine("Factorial is {0}", b);
    //Console.ReadKey();


    //int a, b = 0, c = 1, d;
    //Console.WriteLine("Number limit :");
    //a = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Fibonacci series");
    //Console.WriteLine(b);
    //Console.WriteLine(c);
    //for (int i = 3; i <= a; i++)
    //{
    //    d = b + c;
    //    Console.WriteLine(d);
    //    b = c;
    //    c = d;
    //}

    //Console.ReadKey();




    // nested for loop for pattern printing.

    //*
    //* *
    //* * *
    //* * * * 
    //* * * * *

    //int n;
    //Console.WriteLine("Limit :");
    //n = Convert.ToInt32(Console.ReadLine());
    //for (int i = 1; i <= n; i++) //handling row
    //{
    //    for (int j = 1; j <= i; j++) //handling & printing column
    //    {
    //        Console.Write("*" + " ");
    //    }
    //    Console.WriteLine();//to start in next line

    //}
    //Console.ReadKey();




    // jumping statements
    //break, continue,switch,go to,return

    //Break : used to exit the loop if the condition is true.


    //int a = 1;
    //while (a <= 5)
    //{
    //    if (a==4)
    //    {
    //        break;
    //    }
    //    Console.WriteLine(a);
    //    a = a + 1;
    //}
    //Console.ReadKey();



    //Continue : used to stop the current iteration and move to next 
    //           iteration



    //int a = 0;
    //while (a < 5)
    //{
    //    a = a + 1;
    //    if (a%2==0)
    //    {
    //        continue;
    //    }
    //    Console.WriteLine(a);
    //}
    //Console.ReadKey();



    //Switch : gives an expression 
    //Goto :labelling 

    //int s;
    //Console.Write("case : ");
    //s = Convert.ToInt32(Console.ReadLine());
    //switch (s)
    //{
    //    case 1:
    //        Console.WriteLine("hi");
    //        break;
    //    case 2:
    //        Console.WriteLine("sad");
    //        goto case 3;
    //    case 3:
    //        Console.WriteLine("Be happy");
    //        break;
    //    default:
    //        Console.WriteLine("Whaaaaaaaaaaatttt!!!");
    //        break;

    //}
    //Console.ReadKey();
    //    }
    //}


    // exception handling

    //class X
    //{
    //    public static void Main()
    //    {
    //        try
    //        {
    //            int x, y;
    //            Console.WriteLine("Enter 2 numbers: ");
    //            x = Convert.ToInt32(Console.ReadLine());
    //            y = Convert.ToInt32(Console.ReadLine());
    //            Console.WriteLine("Division : {0} ", x / y);
    //        }
    //        catch (DivideByZeroException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //        catch (FormatException e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //        catch (OverflowException e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Final Block");
    //        }
    //        Console.ReadKey();
    //    }

//    }
//}


    //// inheritance



    //class A
    //{
    //    public int a, b;
    //    public void read()
    //    {
    //        Console.WriteLine("enter 2 numbers : ");
    //        a = Convert.ToInt32(Console.ReadLine());
    //        b = Convert.ToInt32(Console.ReadLine());

    //    }
    //}
    //class B : A
    //{
    //    public void sum()
    //    {
    //        Console.WriteLine("sum of 2 numbers : {0}", a + b);

    //    }

    //    public static void Main()
    //    {
    //        B ob = new B();
    //        ob.read();
    //        ob.sum();
    //        Console.ReadKey();
    //    }
    //}



    // 2- Multi level inheritance

    //class A
    //{
    //    public int a, b;
    //    public void read()
    //    {
    //        Console.WriteLine("enter 2 numbers : ");
    //        a = Convert.ToInt32(Console.ReadLine());
    //        b = Convert.ToInt32(Console.ReadLine());

    //    }
    //}
    //class B : A
    //{
    //    public int s;
    //    public void sum()
    //    {
    //        s = a + b;
    //        Console.WriteLine("sum of 2 numbers : {0}", s);

    //    }

    //class C : B
    //    {
    //        public void avg()
    //        {
    //            Console.WriteLine("Average of 2 values is : {0}", s / 2);
    //        }
    //    }

    //    public static void Main()
    //    {
    //        C ob = new C();
    //        ob.read();
    //        ob.sum();
    //        ob.avg();
    //        Console.ReadKey();
    //    }
    //}


    // 3- Hierarchial Inheritance


    //class A
    //{
    //    public int a, b;
    //    public void read()
    //    {
    //        Console.WriteLine("enter 2 numbers : ");
    //        a = Convert.ToInt32(Console.ReadLine());
    //        b = Convert.ToInt32(Console.ReadLine());

    //    }
    //}
    //class B : A
    //{
    //    public int s;
    //    public void sum()
    //    {
    //        s = a + b;
    //        Console.WriteLine("sum of 2 numbers : {0}", s);

    //    }
    //}

    //class C : B
    //{
    //    public void avg()
    //    {

    //        Console.WriteLine("Average of 2 values is : {0}", s / 2);
    //    }
    //}

    //class D : B
    //{
    //    public int p;
    //    public void prod()
    //    {
    //        p = a * b;
    //        Console.WriteLine("product of 2 numbers : {0}", p);
    //    }
    //    public static void Main()
    //    {
    //        B ob = new B();
    //        C ob1 = new C();
    //        D ob2 = new D();
    //        ob.read();
    //        ob.sum();
    //        ob.read();
    //        ob1.avg();
    //        ob.read();
    //        ob2.prod();
    //        Console.ReadKey();
    //    }
    //}


    // Multiple Inheritance : not directly supported. it is implemented by
    //                        using interface.


    //interface A
    //{
    //    void sum(int a, int b);
    //}
    //interface B
    //{
    //    int prod();
    //}
    //class C : A, B
    //{
    //    public void sum(int a,int b)
    //    {
    //        int s = a + b;
    //        Console.WriteLine("sum : {0}", s);
    //    }
    //    public int prod()
    //    {
    //        int p, q;
    //        Console.WriteLine("Enter 2 numbers : ");
    //        p = Convert.ToInt32(Console.ReadLine());
    //        q = Convert.ToInt32(Console.ReadLine());
    //        return (p * q);
    //    }

    //    public static void Main()
    //    {
    //        C ob = new C();
    //        int p, q;
    //        Console.WriteLine("Enter 2 numbers : ");
    //        p = Convert.ToInt32(Console.ReadLine());
    //        q = Convert.ToInt32(Console.ReadLine());
    //        ob.sum(p,q);
    //        int pr=ob.prod();
    //        Console.WriteLine("product is : {0}", pr);
    //        Console.ReadKey();
    //    }
    //}
}




