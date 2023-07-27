using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonaccie
    {
        public void FindFibonacciNumber()
        {
            Console.WriteLine("Please enter nth number to find fibonacci series");
            int n = Convert.ToInt32(Console.ReadLine());
            int num1 = 0, num2 = 1, sum = 0;
            Console.Write(num1 + " " + num2);
            for (int i = 3; i <= n; i++)
            {
                sum = num1 + num2;
                Console.Write(" " + sum);
                num1 = num2;
                num2 = sum;
            }
        }
    }
}
