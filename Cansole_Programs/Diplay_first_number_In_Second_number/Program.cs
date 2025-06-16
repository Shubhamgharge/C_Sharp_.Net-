using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplay_first_number_In_Second_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1 = 0, iNum2 = 0, i = 0;

            Console.Write("Enter 1st number : ");
            iNum1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number : ");
            iNum2 = Convert.ToInt32(Console.ReadLine());

            for(i =1; i<=iNum2 ; i++)
            {
                Console.Write(+iNum1+" ");
            }

            Console.ReadKey();
        }
    }
}
