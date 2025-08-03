using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment_No_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lower_Limit, Upper_Limit;
            int[] Nubers = new int[10];

            Console.WriteLine("Enter the lower limit : ");
            Lower_Limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Upper limit : ");
            Upper_Limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 10 integers between {0} and {1} : ", Lower_Limit, Upper_Limit);

            for(int i = 0; i<10; i++)
            {
                int num;
                while(true)
                {
                    Console.WriteLine("Enter {0} number : ", i + 1);
                    num = Convert.ToInt32(Console.ReadLine());
                    if(num >= Lower_Limit && num <= Upper_Limit)
                    {
                        Nubers[i] = num;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Numbers out of range. Try again..");
                    }
                }
            }

            Console.WriteLine("Numbers that are divisors of 12 : ");
            foreach(int num in Nubers)
            {
                if(12 % num == 0)
                {
                    Console.WriteLine(num);
                }

            }

            Console.ReadKey();
        }
    }
}
