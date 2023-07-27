using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void GetReverseNumber()
        {
            int r;
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());           
            while (n > 0)
            {
                r = n % 10;
                Console.Write(r);
                n = n / 10;
            }
        }
    }
}
