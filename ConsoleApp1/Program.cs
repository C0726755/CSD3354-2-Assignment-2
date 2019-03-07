using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Student ID:Baldeep Singh Sidhu Student ID:C0726755
//Student ID:Simerpreet Singh Student ID:C0726010
// Assignment 2
//March 7, 2019

namespace Consoleapp1
{

    delegate void ExampleDelegate(string xyz);
    class Program
    {
        static void Main(string[] args)
        {
            ExampleDelegate ex1Delegate, ex2Delegate, ex3Delegate, myDelegate;
            ex1Delegate = new ExampleDelegate(Method1);
            ex2Delegate = new ExampleDelegate(Method2);
            ex3Delegate = ex1Delegate + ex2Delegate;
            myDelegate = ex1Delegate + ex2Delegate;
            myDelegate = ex1Delegate - ex2Delegate;
            ex1Delegate("AAA");
            ex2Delegate("BBB");
            ex3Delegate("CCC");
            myDelegate("DDD");
            myDelegate = ex3Delegate - ex1Delegate;
            myDelegate("EEE");
            myDelegate = ex3Delegate - ex2Delegate;
            myDelegate("FFF");
            Console.ReadLine();


        }
        public static void Method1(string xyz)
        {
            Console.WriteLine(xyz + "Method 1");
        }
        public static void Method2(string xyz)
        {
            Console.WriteLine(xyz + "Method 2");
        }

    }
}

