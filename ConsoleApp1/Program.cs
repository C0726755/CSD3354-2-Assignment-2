﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class DelegateExercises
    {
        // Student ID:Baldeep Singh Sidhu Student ID:C0726755
        //Student ID:Simerpreet Singh Student ID:C0726010
        // Assignment 2
        //March 7, 2019
        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}