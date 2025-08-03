using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment_No_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; 
            int years = 0; 
            int weeks = 0; 
            int days = 0;
            Console.WriteLine("Enter numbers of days:"); 
            num = Convert.ToInt32(Console.ReadLine()); 
            years = num / 365;
            weeks = (num % 365) / 7;
            days = (num % 365) % 7;
            Console.WriteLine("Years:" + years); 
            Console.WriteLine("Weeks:" + weeks); 
            Console.WriteLine("Days:" + days); 
            Console.ReadKey();

        }
    }
}
