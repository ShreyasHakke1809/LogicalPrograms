using LogicalPrograms;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Choose the program");
            Console.WriteLine("\n1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n5.Coupon Numbers\n6.Simulate Stop Watch" +
                "\n7.Notes Vending Machine\n8.Day of Week\n9.Temperature Conversion\n10.Monthly Payment\n11.Sqrt\n12.To Binary\n13.Swap Nibbles");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                    case 1:
                    Fibonaccie fib = new Fibonaccie();
                    fib.FindFibonacciNumber();
                    break;
                    case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                    case 3:
                    PrimeNumber.CheckPrimeNumber();
                    break;
                    case 4:
                    ReverseNumber.GetReverseNumber();
                    break;
                    case 5:
                    CouponNumbers.CheckCouponNumbers();
                    break;
                    case 6:
                    break;
                    case 7:
                    VendingMachine.GetNotes();
                    break;
                    case 8:
                    DayOfWeek.FindDayOfWeek();
                    break;
                    case 9:
                    TemperatureConversion.ConvertTemperature();
                    break;
                    case 10:
                    MonthlyPayment.GetMonthlyPayment();
                    break;
                    case 11:

                    break;
                    case 12:
                    ToBinary.ConvertToBinary();
                    break;
                    case 13:
                    SwapNibblesAndResult.SwapGetResultantNumber();
                    break;
                    default:
                    Console.WriteLine("Please choose option in given range");
                    break;
            }
        }
    }
}