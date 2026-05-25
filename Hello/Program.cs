

// dotnet new console -n TmsCore --framework net10.0

using System;
class Program {
    static void Main(string[] args){
    //    conditional operator
    int age=34;
     string info=(age>=18) ? "You are an adult" : "You are a minor";
     Console.WriteLine(info);
    

    }
}