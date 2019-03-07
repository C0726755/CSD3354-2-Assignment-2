using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();

            delegateExercises.Method2();
        }
    }

    public class DelegateExercises
    {
        // Student ID:Baldeep Singh Sidhu Student ID:C0726755
        //Student ID:Simerpreet Singh Student ID:C0726010
        // Assignment 2
        //March 7, 2019
        public delegate void MyDelegate();
        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method2);
            myDelegate();
        }
    }
}
