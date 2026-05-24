using System;

  
 class Program
{
     static void Main(string[] args)
    {
        int age = 23;
        string name = "Surafel Mengist";
         Greet(age,name);
    }
     static void Greet(int age, string name)
    {
        Console.WriteLine($"Hi everybody are you fine  :{name}");
        Console.WriteLine($"Hi everybody i'm : {age} years old");
        Console.WriteLine("Hi everybody are you fine");
    }
}


