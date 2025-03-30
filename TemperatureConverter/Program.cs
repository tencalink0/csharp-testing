// See https://aka.ms/new-console-template for more information
using System;

namespace TemperatureConverter 
{
    class Program 
    {
        static double ToFarenheit(double number) 
        {
            return (number * 9/5) + 32;
        }

        static double ToCelsius(double number) 
        {
            return (number - 32) * 5/9;
        }

        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a temperature in degrees");
            string input = Console.ReadLine() ?? "";

            double number;
            if (double.TryParse(input, out number)) 
            {
                Console.WriteLine("Celcius - Farenheit " + ToFarenheit(number));
                Console.WriteLine("Farenheit - Celsius " + ToCelsius(number));
            } 
            else 
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}