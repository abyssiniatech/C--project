 public class Condition

{
    public static void Main()
    {
        Console.Write("Enter Your age: ");
        int Age = Convert.ToInt32(Console.ReadLine());
        if (Age >= 18)
        {
            Console.WriteLine($"you can login the website: {Age}");
        }
        else
        {
            Console.WriteLine($"you can not login the website: {Age}");
        }
    }
}