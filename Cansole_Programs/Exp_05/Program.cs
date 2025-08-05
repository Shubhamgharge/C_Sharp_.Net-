using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp_05
{
    class Program
    {
        static double CalculateArea(double radius)
        {
            return 4 * Math.PI * radius * radius;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the sphare:"); 
            double radius = Convert.ToDouble(Console.ReadLine()); 
            double area = CalculateArea(radius);
            Console.WriteLine("The Surface area of the sphare is :" + area); 
            Console.ReadKey();

        }
    }
}
