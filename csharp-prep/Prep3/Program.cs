using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {   
        // int guessNumer = 4;
        int guess = -1;
        int guessTime = 0;
        // int result = -1;
        // we can write those two lines to one line like above
        // string guess = Console.ReadLine();
        // int newGuess = int.Parse(guess);
        Random randomNumber = new Random();
        int isRandomNumber = randomNumber.Next(1,101);
        while (guess != isRandomNumber)
        {
            Console.Write("Enter a number: ");
            guess = int.Parse(Console.ReadLine());
            // int result = int.Parse(answer);
            
        // int guess = int.Parse(Console.ReadLine()); one line to convert a string to integer
            if (guess > isRandomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if ( guess< isRandomNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guess == isRandomNumber)
            {
                Console.WriteLine("You guessed it");
               
            }
            guessTime+= 1;
        
        }Console.WriteLine($"you guess {guessTime} times.");
    }
}