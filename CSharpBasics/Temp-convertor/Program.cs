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

            Console.WriteLine("Choose converting type:");
            Console.WriteLine("1 - Celsius to Fahrenheit");
            Console.WriteLine("2 - Fahrenheit to Celsius");
            Console.WriteLine("3 - Celsius to Kelvin");
            Console.WriteLine("4 - Kelvin to Celsius");
            Console.WriteLine("5 - Fahrenheit to Kelvin");
            Console.WriteLine("6 - Kelvin to Fahrenheit");
            Console.Write("Enter your choice: ");
            char unit1 = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Enter the temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            double convertedTemperature = ConvertTemperature(temperature, unit1);

            if (!double.IsNaN(convertedTemperature))
            {
                Console.WriteLine($"The converted temperature is: {convertedTemperature}");
            }
            else
            {
                Console.WriteLine("Invalid unit entered.");
            }

            Console.WriteLine("Program finished");
            Console.ReadKey();
        }
        static double ConvertTemperature(double temperature, char unit1)
        {
            switch (unit1)
            {
                case '1':
                    return CelsiusToFahrenheit(temperature);
                case '2':
                    return FahrenheitToCelsius(temperature);
                case '3':
                    return CelsiusToKelvin(temperature);
                case '4':
                    return KelvinToCelsius(temperature);
                case '5':
                    return FahrenheitToKelvin(temperature);
                case '6':
                    return KelvinToFahrenheit(temperature);
                default:
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
        static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
        static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
        static double FahrenheitToKelvin(double fahrenheit)
        {
            double celsius = FahrenheitToCelsius(fahrenheit);
            return CelsiusToKelvin(celsius);
        }
        static double KelvinToFahrenheit(double kelvin)
        {
            double celsius = KelvinToCelsius(kelvin);
            return CelsiusToFahrenheit(celsius);
        }
    }
}

