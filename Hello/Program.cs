using System;

class Program
{
    static void Main()
    {
        try
        {
            int num1 = 10;
            int num2 = 0;

            int result = num1 / num2;

            Console.WriteLine(result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Program continues...");
    }
}