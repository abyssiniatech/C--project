using System;

class Swichcase
{
    public static void Main()
    {
      Console.Write("Enter day:");
      string day = Console.ReadLine() ?? string.Empty;
      switch (day)
      {
        case "Monday":
           Console.WriteLine($" The day was:Monday");
           break;
        case "Tuesday":
           Console.WriteLine($"Tuesday");
           break;
        case "Wednesday":
           Console.WriteLine($"Wednesday");
           break;
        case "Thursday":
           Console.WriteLine($"Thursday");
           break;
        case "Friday":
           Console.WriteLine("Friday");
           break;
        case "Saturday":
           Console.WriteLine($"Saturday");
           break;
        case "Sunday":
           Console.WriteLine($"Sunday");
           break;
        default:
          Console.WriteLine($"invalid input");
          break;
      }
    }
}