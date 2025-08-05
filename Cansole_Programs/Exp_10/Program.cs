using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 integer elements:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter elements {0}:", i + 1); 
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = numbers[0]; 
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)

                    min = numbers[i]; if (numbers[i] > max)
                    max = numbers[i];
            }
            Console.WriteLine("\n Minimum element :{0}", min); 
            Console.WriteLine("Maximum element:{0}", max); 
            Console.ReadKey();

        }
    }
}
