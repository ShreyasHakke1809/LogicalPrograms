using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            int count=0;
            Console.WriteLine("Please enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i<= n; i++)
            {
                if(n%i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not Prime Number");
        }
    }
}
