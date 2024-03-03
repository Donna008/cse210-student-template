using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirement: Saving and loading a log file.
        string _breathingLog = "BreathingLog.txt";
        string _reflectionLog = "ReflectionLog.txt";
        string _listingLog = "ListingLog.txt";
        bool _quit = false;
        while(!_quit)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Activities!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity ");
            Console.WriteLine("2. Reflection Activity ");
            Console.WriteLine("3. Listing Activity ");
            Console.WriteLine("4. Quit ");

            string _input = Console.ReadLine();
            switch (_input)
            {
                case "1":
                    Console.WriteLine("\nBreathing Activity");
                    Console.WriteLine("\nThis activity will help you relax by walking you through breathing in and out slowly.");
                    Console.WriteLine("\nClear your mind and focus on your breathing.");
                    Console.Write("\nEnter the duration in seconds: ");
                    int _breathingDuration = int.Parse(Console.ReadLine());
                    BreathingActivity Breathing = new BreathingActivity(_breathingDuration,_breathingLog);
                    Breathing.Play();
                    break;
                case "2":
                    // Console.Clear();
                    Console.WriteLine("\nReflection Activity");
                    Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
                    Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Console.WriteLine("Think of a time when you stood up for someone else.");
                    Console.WriteLine("Think of a time when you did something really difficult.");
                    Console.WriteLine("Think of a time when you helped someone in need.");
                    Console.WriteLine("Think of a time when you did something truly selfless.");
                    Console.Write("\nEnter the duration in seconds: ");
                    // Console.ReadLine();
                    int _refelectionDuration = int.Parse(Console.ReadLine());
                    ReflectionActivity Refelction = new ReflectionActivity(_refelectionDuration,_reflectionLog);
                    Refelction.Play();
                    break;
                case "3":
                    Console.WriteLine("\nListing Activity");
                    Console.WriteLine("This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.");
                    Console.Write("\nEnter the duration in seconds: ");
                    int _listingDuration = int.Parse(Console.ReadLine());
                    ListingActivity Listing = new ListingActivity(_listingDuration,_listingLog);
                    Listing.Play();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Thank you for playing, goodbye!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    _quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ReadLine();
                    break;
            } 
        }
    }
}