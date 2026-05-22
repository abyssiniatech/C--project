class Hello
{
    public static void Main()
    {
        int num1 = 40;
        int b = (int)Math.Pow(num1, 3);
        int c = (int)Math.Floor(34.345m);
        var d=Convert.ToDecimal(c);
        Console.WriteLine($"The value of :{b}");
        Console.WriteLine($"Floor is :{b}");
        Console.WriteLine($"Covertor: {d}");
        Console.ReadLine();
    }
}