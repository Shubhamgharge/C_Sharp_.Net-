using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 0;

            Console.Write("Enter a number : ");
            iNum = Convert.ToInt32(Console.ReadLine());

            if(iNum == 0)
            {
                return;
            }
            else if(iNum % 2 == 0)
            {
                Console.Write(+iNum + " is Enen number .");
            }
            else
            {
                Console.Write(+iNum + " is Odd number .");
            }

            Console.ReadKey();
        }
    }
}
