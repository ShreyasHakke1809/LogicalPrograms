using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TemperatureConversion
    {
        public static void ConvertTemperature()
        {
            Console.WriteLine("Choose a conversion method:");
            Console.WriteLine("\n 1. Celsius to Fahrenheit \n 2. Fahrenheit to Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter temperature to convert: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    double celsiusToFahrenheit = (temp * 9 / 5) + 32;
                    Console.WriteLine("Temperature in Fahrenheit: " + celsiusToFahrenheit);
                    break;
                case 2:
                    double fahrenheitToCelsius = (temp - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius: " + fahrenheitToCelsius);
                    break;
                default:
                    Console.WriteLine("Enter a vlaid option");
                    break;
            }
        }
    }
}
