// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator 
{
    enum FunctionType 
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    class Program 
    {
        static FunctionType GetOperation()
        {
            Console.WriteLine("Which calculator function would you like to use");
            string input = Console.ReadLine() ?? "";

            return input.Trim() switch 
            {
                "add" => FunctionType.Add,
                "subtract" => FunctionType.Subtract,
                "multiply" => FunctionType.Multiply,
                "divide" => FunctionType.Divide,
                _ => throw new ArgumentException("Invalid operation"),
            };
        }

        static void Main(string[] args) 
        {
            FunctionType func = GetOperation();
            Console.WriteLine($"Operation {func} selected");
        }
    }
}