using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class DayOfWeek
    {
        public static void FindDayOfWeek()
        {
            int d, m, y, x;
            Console.WriteLine("Enter Date from 1 to 31: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month from 1 to 12: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (date > 0 && month > 0 && year > 0 && date <= 31 && month <= 12)
            {
                y = year - (14 - month) / 12;
                x = y + y / 4 - y / 100 + y / 400;
                m = month + 12 * ((14 - month) / 12) - 2;
                d = (date + x + 31 * m / 12) % 7;

                Console.WriteLine("Day of week is: " + d);
                switch (d)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednsday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Please Enter Correct Date");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please Enter Correct Date");
            }
        }
    }
}
