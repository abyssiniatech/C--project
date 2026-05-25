

// dotnet new console -n TmsCore --framework net10.0

using System;
class Program {
    static void Main(string[] args){
        try{

        string name = null;
         Console.WriteLine(name.ToUpper());
        }
        catch (NullReferenceException ex)
        {
           Console.WriteLine("A null reference exception occurred: " + ex.Message); 
        }

    }
}