using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_From_1_to_10_Using_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 0;

            for(iNum = 1 ; iNum <= 10; iNum++)
            {
                Console.Write(+iNum + "\n");
            }

            Console.ReadKey();
        }
    }
}
