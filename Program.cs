using System;

class Program
{
    static void Main(string[] args)
    {
         String name="surafel Mengist";
         int age=28;
         String Address ="Addis Ababa";
         String greet ="welcome to me";
      
        Console.WriteLine("Hello"+ greet+ "my name is :" + name + "and" + "I'm " + age + "years old" + "i live in " + address);
        // input from the keyboard and finally display it 
         Console.Write("Enter your Email");
         String email=Console.ReadLine();
         Console.WriteLine("my email is :" + email);
       Console.ReadLine();
    }
}