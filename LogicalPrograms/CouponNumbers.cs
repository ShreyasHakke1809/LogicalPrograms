using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumbers
    {
        public static int[] couponNum = new int[4] { 13, 24, 09, 36 };
        public static Random random = new Random();
        public static int[] randomCount = new int[4];
        public static int totalCount = 0;
        public static int i = 0;

        public static void CheckCouponNumbers()
        {
            foreach (var coupon in couponNum)
            {
                while (coupon != random.Next(0, 40))
                {
                    randomCount[i]++;
                    totalCount++;
                }
                Console.WriteLine("Random numbers generated to get " + coupon + " are: " + randomCount[i]);
                i++;
            }
            Console.WriteLine("Total random numbers generated to get all distinct numbers :" + totalCount);
        }
    }
        
}
