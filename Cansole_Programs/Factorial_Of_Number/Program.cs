using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Of_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 0, iFact = 1, iTemp = 0, i=0;

            Console.Write("Enter a number to calculate factorial : ");
            iNum = Convert.ToInt32(Console.ReadLine());

            iTemp = iNum;
            
            while(iTemp > 0)
            {
                iFact = iFact * iTemp;
                iTemp--;
            }

            Console.Write("Factorial of " + iNum + " is " + iFact + ".");

            Console.ReadKey();
        }
    }
}
