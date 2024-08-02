using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp_convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Convertor");

            Console.Write("Enter the temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the unit to convert from (C or F): ");
            char Unit1 = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Enter the unit to convert to (C or F): ");
            char Unit2 = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            double convertedTemperature = ConvertTemperature(temperature, Unit1, Unit2);

            if (!double.IsNaN(convertedTemperature))
            {
                Console.WriteLine($"The converted temperature is: {convertedTemperature} {Unit2}");
            }

            Console.WriteLine("Program finished");
            Console.ReadKey();
        }

        static double ConvertTemperature(double temperature, char Unit1, char Unit2)
        {
            double result = temperature;

            if (Unit1 == 'C')
            {
                result = temperature;
            }
            else if (Unit1 == 'F')
            {
                result = FahrenheitToCelsius(temperature);
            }
            else
            {
                Console.WriteLine("Invalid unit to convert from.");
                return double.NaN;
            }

            if (Unit2 == 'C')
            {
                return result;
            }
            else if (Unit2 == 'F')
            {
                return CelsiusToFahrenheit(result);
            }
            else
            {
                Console.WriteLine("Invalid unit to convert to.");
                return double.NaN;
            }
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
