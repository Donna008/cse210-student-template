using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string username=PromptUserName();
        int usernumber=PromptUserNumber();
        int square = SquareNumber(usernumber);
        DisplayResult(username,square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your number: ");
        string snumber = Console.ReadLine();
        int number = int.Parse(snumber);
        return number;
    }
    static int SquareNumber(int number )
    {
        // Console.Write("Enter a number: ");
        // string number =Console.ReadLine();
        // int Inumber = int.Parse(number);
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name,int square)
    {
        Console.WriteLine($"{name},the square of you number is {square}");
        // Console.WriteLine(name+square);
    }

}