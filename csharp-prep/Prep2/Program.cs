// keyword to use system
using System;


class Program
{
    static void Main(string[] args)
    {
    //     Console.Write("How many points you earned? ");
    //     string numbers = Console.ReadLine();
    //     int number = int.Parse(numbers);

        
    //     if (number >= 60)
    //         {
    //             Console.WriteLine("You got a D");
    //         }
    //     else if (number < 60)
    //         {
    //             Console.WriteLine("You got a F");
    //         }
    //     else if(number >= 70)
    //         {
                
    //             Console.WriteLine("You got a C");
    //         }
    //     else if (number >= 80)
    //         {
    //             Console.WriteLine("You got a B");
    //         }
    //     else if (number >= 90)
    //         {
    //             Console.WriteLine("You got an A");
    //         }
    //     if (number >= 70)
    //         {
    //             Console.WriteLine("You passed the class");

    //         }
    //     else
    //         {
    //             Console.WriteLine("You should be tring again");
    //         }

            string letter1 = "A";
            string letter2 = "B";
            string letter3 = "C";
            string letter4 = "D";
            string letter5 = "F";
            Console.Write("Enter your Scores: ");
            string scores = Console.ReadLine();
            int grade = int.Parse(scores);
            if (grade >= 70)
                {if (grade >= 90)
                    {
                        // Console.WriteLine($"You got an {letter1}");
                        if ((grade % 10) < 3)
                         {
                            Console.WriteLine($"You got an {letter1}-");
                         }
                        else if ((grade % 10) >= 7)
                        Console.WriteLine($"You got an {letter1}");
                        else
                        {
                            Console.WriteLine($"You got an {letter1}");
                        }
                    }
                    else if (grade >= 80)
                    {
                        if ((grade % 10) < 3)
                        {
                            Console.WriteLine($"You got a {letter2}-");
                        }
                        else if ((grade % 10) >= 7)
                        Console.WriteLine($"You got a {letter2}+");
                        else
                        {
                            Console.WriteLine($"You got a {letter2}");
                        }

                    }
                    else if(grade >= 70)
                    {   
                        if ((grade % 10) < 3)
                        {
                            Console.WriteLine($"You got a {letter3}-");
                        }
                        else if ((grade % 10) >= 7)
                        Console.WriteLine($"You got a {letter3}");
                        else
                        {
                            Console.WriteLine($"You got a {letter3}");
                        }
                    }
                   
                Console.WriteLine("Congrats");
                }
            
            else
                {if (grade >= 60)
                    {
                        if ((grade % 10) < 3)
                        {
                            Console.WriteLine($"You got a {letter4}-");
                         }
                        else if ((grade % 10) >= 7)
                        Console.WriteLine($"You got a {letter4}");
                        else
                        {
                            Console.WriteLine($"You got a {letter4}");
                        }
                    }
                else if (grade < 60)
                {
                    Console.WriteLine($"You got a {letter5}");
                }
            {
                Console.WriteLine("Try again");
            }
            
            }
    }
}