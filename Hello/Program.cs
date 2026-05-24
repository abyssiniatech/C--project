using System;

class Program
{
    static void Main(string[] args)
    {
        Sums();
    }

    static double Sums()
    {
        Console.Write("Enter the value of x: ");
        
        double x = Convert.ToDouble(Console.ReadLine());

        double sum = x * 12;

        Console.WriteLine($"The value of sum is = {sum}");

        return sum;
    }
}