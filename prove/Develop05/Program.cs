// using System;
// using System.Collections.Generic;
// using System.IO;

// class Program
// {
//     private static object goals;

//     static void Main(string[] args)
// {
//     List<Goal> goals = new List<Goal>();

// Console.WriteLine("Enter your own goals (press enter to stop):");
// while (true)
// {
//     Console.WriteLine("Enter goal name:");
//     string name = Console.ReadLine();
//     if (string.IsNullOrEmpty(name))
//         break;

//     Console.WriteLine("Enter goal type (Simple, Eternal, or Checklist):");
//     string type = Console.ReadLine();

//     Goal goal = null;
//     switch (type.ToLower())
//     {
//         case "simple":
//             Console.WriteLine("Enter points for this goal:");
//             int points = int.Parse(Console.ReadLine());
//             goal = new SimpleGoal(name, points);
//             break;
//         case "eternal":
//             Console.WriteLine("Enter points for this goal:");
//             points = int.Parse(Console.ReadLine());
//             goal = new EternalGoal(name, points);
//             break;
//         case "checklist":
//             Console.WriteLine("Enter required times for this goal:");
//             int requiredTimes = int.Parse(Console.ReadLine());
//             Console.WriteLine("Enter points for this goal:");
//             points = int.Parse(Console.ReadLine());
//             goal = new ChecklistGoal(name, requiredTimes, points);
//             break;
//         default:
//             Console.WriteLine("Invalid goal type. Please try again.");
//             break;
//     }

//     if (goal != null)
//     {
//         goals.Add(goal);
//         Console.WriteLine($"Goal '{name}' added successfully!");
//     }
// }

// // Example events recorded
// foreach (var goal in goals)
// {
//     goal.RecordEvent();
// }

// // Displaying progress
// foreach (var goal in goals)
// {
//     goal.DisplayProgress();
// }

// // Saving progress
// SaveProgress("progress.txt", goals);

// // Loading progress
// List<Goal> loadedGoals = LoadProgress("progress.txt");

// Console.WriteLine("\nLoaded Goals:");
// foreach (var goal in loadedGoals)
// {
//     goal.DisplayProgress();
// }



//     static void SaveProgress(string filePath, List<Goal> goals)
//     {
//         using (StreamWriter writer = new StreamWriter(filePath))
//         {
//             foreach (var goal in goals)
//             {
//                 writer.WriteLine($"{goal.GetType().Name},{goal.GetName()},{goal.GetCompletedTimes()}");
//             }
//         }
//     }

//     static List<Goal> LoadProgress(string filePath)
//     {
//         List<Goal> loadedGoals = new List<Goal>();
//         using (StreamReader reader = new StreamReader(filePath))
//         {
//             string line;
//             while ((line = reader.ReadLine()) != null)
//             {
//                 string[] parts = line.Split(',');
//                 string type = parts[0];
//                 string name = parts[1];
//                 int completedTimes = int.Parse(parts[2]);
                
//                 Goal goal = null;
//                 switch (type)
//                 {
//                     case nameof(SimpleGoal):
//                         goal = new SimpleGoal(name, 0); // Points will be loaded from file
//                         break;
//                     case nameof(EternalGoal):
//                         goal = new EternalGoal(name, 0); // Points will be loaded from file
//                         break;
//                     case nameof(ChecklistGoal):
//                         // For checklist goals, points will be loaded from file
//                         int points = loadedGoals.Find(g => g.GetName() == name)?.GetPoints() ?? 0;
//                         goal = new ChecklistGoal(name, 0, points); 
//                         break;
//                 }
//                 if (goal != null)
//                 {
//                     goal.SetCompletedTimes(completedTimes);
//                     loadedGoals.Add(goal);
//                 }
//             }
//         }
//         return loadedGoals;
//     }
// }
// }

using System;
using System.Collections.Generic;

class Program { 
    static void Main(string[] args) {
        // Exceding(code in User class): Add your own ideas for gamification. This could include leveling up, earning certain bonuses, or other "fun" aspects to the quest.
        User user = new User("goals.txt");
        
        string input = ""; // Variable to store user input.

        do {
            // Display the user's total score and menu options.
            Console.WriteLine($"You have {user.GetTotalScore()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Goal");
            Console.WriteLine("  4. Load Goal");
            Console.WriteLine("  5. Exit");

            // Ask for the user's choice.
            Console.Write("Your Choice: ");
            input = Console.ReadLine();
            Console.WriteLine();

            // Process the user's choice.
            switch (input) {
                case "1": // Create a new goal.
                    user.CreateGoal();
                    break;
                case "2": // List existing goals.
                    user.DisplayGoals();
                    break;
                case "3": // Mark a goal as complete.
                    user.CompleteGoal();
                    break;
               case "4":
    Console.Write("Enter the filename to load goals from: ");
    string filename = Console.ReadLine();
    Goal goal = Goal.LoadFromTextFile(filename);
    // Check if the loaded goal is not null (i.e., loading was successful)
    if (goal != null)
    {
        // Optionally, you can add the loaded goal to a list or perform other operations
        Console.WriteLine("Goals loaded successfully.");
    }
    break;

            }

        // Repeat until the user chooses to exit.
        } while (new List<String>(){"1", "2", "3"}.Contains(input));

        user.WriteToFile(); // Save the user's goals to file before exiting.
        
    }
}