using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Decrement_10_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 10;

            while(iNum > 0)
            {
                Console.WriteLine(+iNum );
                iNum--;
            }

            Console.ReadKey();
        }
    }
}
