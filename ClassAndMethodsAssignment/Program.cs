﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAssignment 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //Class1 obj1 = new Class1();

            //Console.WriteLine("Please type a number from 25-100");
            //int userInp = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your number plus 25 equals:  " + obj1.intadd(userInp));


            //Console.WriteLine("Enter a decimal number to convert to an integer.");
            //decimal userDecimal = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Your decimal number as an integer is " + obj1.decToInt(userDecimal));

            //Console.WriteLine("Please enter a string value that will convert to an integer.");
            //string userString = Console.ReadLine();
            //Console.WriteLine("Your string as an integer is " + obj1.stringToInt(userString));

            //Console.ReadLine();



            //Part 2

            Class1 sumObj = new Class1();

            Console.WriteLine("Please enter a number from 1 - 100.");
            int intOne = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine("Please enter two integers.  One of them is optional.");
            int userInp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("")


        }
    }
}
