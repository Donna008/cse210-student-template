using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
// int guessNumer = 4;
// int guess = -1;
// int guessTime = 0;
// int result = -1;
// we can write those two lines to one line like above
// string guess = Console.ReadLine();
// int newGuess = int.Parse(guess);
// Random randomNumber = new Random();
// int isRandomNumber = randomNumber.Next(1,101);
// while (guess != isRandomNumber)
// {
//     Console.Write("Enter a number: ");
//     guess = int.Parse(Console.ReadLine());
// int result = int.Parse(answer);

// int guess = int.Parse(Console.ReadLine()); one line to convert a string to integer
//     if (guess > isRandomNumber)
//     {
//         Console.WriteLine("Higher");
//     }
//     else if ( guess< isRandomNumber)
//     {
//         Console.WriteLine("lower");
//     }
//     else if (guess == isRandomNumber)
//     {
//         Console.WriteLine("You guessed it");

//     }
//     guessTime+= 1;

// }Console.WriteLine($"you guess {guessTime} times.");

// Console.Write("Enter a magic number ");
// string _mahicNumber = Console.ReadLine();
// int _number = int.Parse(_mahicNumber);
// Random random = new Random();
// int _number = random.Next(1, 100);

// #1 only while loop (first check condition then execute code block)
// Console.Write("What is your guess? ");
// string _guessNum = Console.ReadLine();
// int _num = int.Parse(_guessNum);
// while (_num != _number)
// {
// if (_num > _number)
// {
//     Console.WriteLine("Higher");
// }
// // else if (_num < _number)
// // {
// //     Console.WriteLine("Lower");
// // }
// else
// {
//     Console.WriteLine("Lower");
// }
// Console.Write("What is your guess? ");
// _guessNum = Console.ReadLine();
// _num = int.Parse(_guessNum);

// }
// Console.WriteLine("You guessed it");

// #2 do-while loop(first code bolck then execute condition)
int _num;
int _count = 0;
bool playAgain;
do
{
    Random random = new Random();
    int _number = random.Next(1, 100);
        do
            {
            Console.Write("What is your guess? ");
            string _guessNum = Console.ReadLine();
            _num = int.Parse(_guessNum);
            _count++;
            if (_num > _number)
            {
                Console.WriteLine("Higher");
            }
            else if (_num < _number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
            }
            while (_num != _number);

            Console.WriteLine($"You guessed {_count} times");
        
        Console.Write("Do you want to play again? y/n ");
        string playAgainInput = Console.ReadLine();
        playAgain = playAgainInput.ToLower()== "y";
}while(playAgain);
Console.WriteLine("Have a great day");
    }
    
    }

