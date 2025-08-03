using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment_No_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int i;

            Console.WriteLine("Enter a Character : ");
            a = Convert.ToChar(Console.ReadLine());
            i = (int)a;
            if(a >= 'A' && a<='Z')
            {
                Console.WriteLine("The character is : {0}", char.ToLower(a));
            }
            else if(a >= 'a' && a <= 'z')
            {
                Console.WriteLine("The character is : {0} ", char.ToUpper(a));
            }
            else
            {
                Console.WriteLine("Invalid character ");
            }
            Console.ReadKey();
        }
    }
}
