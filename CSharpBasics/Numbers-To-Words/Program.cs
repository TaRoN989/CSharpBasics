using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_To_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 999: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 999)
            {
                Console.WriteLine("The number must be between 0 and 999.");
            }
            else
            {
                string result = NumberToWords(number);
                Console.WriteLine(result);
            }
            Console.ReadKey ();
        }

        static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            string[] miavor = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tasnavor = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tasnavor_glavni = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] haryuravor = { "", "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };

            string words = "";

            if (number / 100 > 0)
            {
                words += haryuravor[number / 100];
                number %= 100;
                if (number > 0)
                    words += " and ";
            }

            if (number / 10 > 1)
            {
                words += tasnavor_glavni[number / 10];
                number %= 10;
                if (number > 0)
                    words += "-";
            }
            else if (number / 10 == 1)
            {
                words += tasnavor[number % 10];
                number = 0;
            }

            if (number > 0)
            {
                words += miavor[number];
            }

            return words;
        }
    }
}
