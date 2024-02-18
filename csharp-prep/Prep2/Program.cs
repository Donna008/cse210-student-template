// keyword to use system
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many points you earned? ");
        string numbers = Console.ReadLine();
        int number = int.Parse(numbers);

        
        if (number >= 60)
            {
                Console.WriteLine("You got a D");
            }
        else if (number < 60)
            {
                Console.WriteLine("You got a F");
            }
        else if(number >= 70)
            {
                
                Console.WriteLine("You got a C");
            }
        else if (number >= 80)
            {
                Console.WriteLine("You got a B");
            }
        else if (number >= 90)
            {
                Console.WriteLine("You got an A");
            }
        if (number >= 70)
            {
                Console.WriteLine("You passed the class");

            }
        else
            {
                Console.WriteLine("You should be tring again");
            }
    }
}