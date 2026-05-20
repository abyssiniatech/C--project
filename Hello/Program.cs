using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operator (+, -, *, /): ");
        string op = (Console.ReadLine() ?? string.Empty).Trim();

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (op == "+")
        {
            Console.WriteLine("Result: " + (num1 + num2));
        }
        else if (op == "-")
        {
            Console.WriteLine("Result: " + (num1 - num2));
        }
        else if (op == "*")
        {
            Console.WriteLine("Result: " + (num1 * num2));
        }
        else if (op == "/")
        {
            if (num2 != 0)
            {
                Console.WriteLine("Result: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid operator.");
        }

        Console.ReadLine();
    }
}