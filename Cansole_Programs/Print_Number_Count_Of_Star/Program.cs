using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Number_Count_Of_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 0,i=0;

            Console.Write("\n Enter a number to print count of Star on the screen : ");
            iNum = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i<=iNum ; i++)
            {
                Console.Write(" * ");
            }

            Console.ReadKey();
        }
    }
}
