using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabels_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1 = 0, iNum2 = 0, i = 0, j = 0;

            Console.Write("Enter 1st number :");
            iNum1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number :");
            iNum2 = Convert.ToInt32(Console.ReadLine());

            for(i=iNum1; i<=iNum2; i++)
            {
                for(j=1; j<=10; j++)
                {
                    Console.Write(+j*i+ "\n");
                }
              //  Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
