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
    class program
    {

        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();

            try

            {

                delegateExercises.Method3();

                Console.ReadLine();

            }

            catch (System.Exception)

            {

                System.Console.WriteLine("Exception Occurred.");

                Console.ReadLine();
            }
        }
        public delegate void MyDelegate();



        public class DelegateExercises

        {

            void Method1()

            {

                throw new System.Exception();

            }



            public void Method3()

            {

                MyDelegate myDelegate = new MyDelegate(Method1);

                myDelegate();

            }

        }



    }
}

    