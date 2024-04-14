using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your first name: ");
        // string firstName = Console.ReadLine();
        // Console.Write("What is your last name: ");
        // string lastName = Console.ReadLine();
        // Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

        Console.Write("Enter your last name and first name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your first name: ");
        string fname = Console.ReadLine();

        Console.WriteLine($"\nYour name is {name}, {fname}.");
        
    }
    
}