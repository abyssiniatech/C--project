
using System;
using System.Globalization;
class Program {
    static void Main(){
        Console.Write("Enter your age:");
        int age=Convert.ToInt32(Console.ReadLine());
        if(age<10){
            Console.WriteLine("You are child");
        }
        else if(age>10 && age < 20)
        {
            Console.WriteLine("you are young");
        }
        else
        {
            Console.WriteLine("You are Old");
        }
       Surafel();
       Console.ReadLine();
    }



//    the second methods
static void Surafel()
    {
    Console.Write("Enter the random number");
       String name="Surafel"; 
       int num = Convert.ToInt32(Console.ReadLine());
        if(num % 2 == 0)
        {
          Console.WriteLine("The number is even") ; 
        }
        else
        {
            Console.WriteLine("Your number is Odd");
        }
       Console.WriteLine(name);
    }

}

