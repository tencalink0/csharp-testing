// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld 
{
    class Program 
    {
        static double ToFarenheit(double number) 
        {
            return (number * 9/5) + 32;
        }

        static double toCelsius(double number) 
        {
            return (number - 32) * 5/9;
        }

        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a temperature in degrees");
            double userInput = double.parse(Console.ReadLine());

            Console.WriteLine("Celcius - Farenheit" + ToFarenheit(userInput));
            Console.WriteLine("Farenheit - Celsius" + ToFarenheit(userInput));
        }
    }
}