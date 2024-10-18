using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string operation;

            // User Input
            Console.WriteLine("Welcome to the Simple Calculator!");

            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operation (+, -, *, /): ");
            operation = Console.ReadLine();

            // Perform the calculation based on the user input
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;

                case "/":
                    // Check for division by zero
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                    break;
            }
            Console.ReadKey();
        }

    }
}
