﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo1 = 0, iNo2 = 0, iAns = 0;

            Console.Write("Enter 1st number : ");
            iNo1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number : ");
            iNo2 = Convert.ToInt32(Console.ReadLine());

            iAns = iNo1 * iNo2;

            Console.Write("\n Multiplication of " + iNo1 + " & " + iNo2 + " is " + iAns + ".");

            Console.ReadKey();
        }
    }
}
