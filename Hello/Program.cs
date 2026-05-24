using System;
class Program
{
    static void Main()
    {
        try
        {
           Console.Write("enter num1:");
           int num1=Convert.ToInt32(Console.ReadLine());

            Console.Write("enter num2:");
           int num2=Convert.ToInt32(Console.ReadLine());
           int result =num1/num2;
           Console.WriteLine(result);
        }
        catch (UriFormatException ex)
        {
            Console.WriteLine("Please enter number only");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Run the server as expected");
    
    }
}
}