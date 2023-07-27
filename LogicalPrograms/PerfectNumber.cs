using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter a number to check wheather it is perfect number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect Number");
            }
        }
    }
}
