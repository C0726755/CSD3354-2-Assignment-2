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
            DelegateExercises delegateExercises = new DelegateExercises();

            delegateExercises.Method3();

            Console.ReadLine();


        }
        public delegate int MyDelegate(out int i);



        public class DelegateExercises

        {

            int Method1(out int i)

            {
                i = 100;
                System.Console.WriteLine("Method1 " + i);
                return 0;

            }



            public void Method3()

            {

                MyDelegate myDelegate = new MyDelegate(Method1);

                MyDelegate myDelegate1 = null;
                MyDelegate myDelegate2 = myDelegate + myDelegate1;
                int intValue;

                myDelegate2(out intValue);



            }
        }
    }
}