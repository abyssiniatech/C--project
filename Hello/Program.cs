// inter input from the keyword then display it 
public class Input{
    public static void Main(){
        Console.Write("Enter the age:");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"I'm : {age} years old");
        Console.ReadKey();
    }
}