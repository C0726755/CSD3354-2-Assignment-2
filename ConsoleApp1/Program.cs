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
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();

            delegateExercises.Method3();


        }


    }
    public class DelegateExercises
    {
        public delegate int MyDelegate();
        void Method1()

        {
            System.Console.WriteLine("MyDelegate");

        }



        public void Method3()

        {

            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();

        }
}



}



