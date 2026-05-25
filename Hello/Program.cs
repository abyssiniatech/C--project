

// dotnet new console -n TmsCore --framework net10.0

using System;
class Program {
    static void Main(string[] args){
      string region="Addis Ababa";
    
        if ( region!= null)
        {
            Console.WriteLine(region.ToUpper());
        }
        else
        {
            Console.WriteLine("Null Value");
        }

    }
}