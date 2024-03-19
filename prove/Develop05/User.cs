using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class User {
    private List<Bonus> _bonuses; // List to store earned bonuses

    // Method to award a bonus to the user
    public void AwardBonus(Bonus bonus)
    {
        _bonuses.Add(bonus);
        // You can also update user's total score or perform other actions here
        Console.WriteLine($"Congratulations! You earned a bonus: {bonus.Name} (+{bonus.Points} points)");
    }

    List<Goal> _goals; // List to store user's goals.
    string _filename; // File name for storing and reading goal data.
    private int _totalScore;

    // Constructor initializes the User object and reads goals from file if it exists.
    public User(string filename) { 
        _goals = new List<Goal>();
        _filename = filename;
        _bonuses = new List<Bonus>();
        // Load goals from a file if the file exists.
        if (File.Exists(_filename)) {
            ReadFromFile();
        }
    }

    // Allows a user to mark a goal as complete.
public void CompleteGoal()
{
    Console.WriteLine("Select the goal you wish to check off:");
    DisplayGoals();
    Console.Write("Goal: ");

    int input;
    do
    {
        input = int.Parse(Console.ReadLine());
    } while (!Enumerable.Range(1, _goals.Count).Contains(input));

    Goal completedGoal = _goals[input - 1]; // Get the completed goal

    completedGoal.Complete(); // Mark the goal as completed

    int pointsEarned = completedGoal.CalculateScore(); // Calculate points earned for the completed goal

    Console.WriteLine($"You earned {pointsEarned} points!");

    // Check if the user is eligible for any bonuses based on the completed goal
    if (UserIsEligibleForBonus())
    {
        // Award a bonus to the user
        AwardBonusForCompletedGoals();
    }
}

    // Method to check if the user is eligible for a bonus based on completed goals.
    private bool UserIsEligibleForBonus()
    {
        return _goals.Count(g => g.IsCompleted()) >= 5;
    }

    // Method to award a bonus to the user for completing 5 goals.
    private void AwardBonusForCompletedGoals()
    {
        _totalScore += 100; // Award 100 points as a bonus
        Console.WriteLine("Congratulations! You've completed 5 goals and earned a bonus of 100 points!");
    }



    // Creates a new goal based on user input.
    public void CreateGoal() {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        string input;

        // User chooses the type of goal to create.
        do {
            Console.Write("Which type of goal do you like to create? ");
            input = Console.ReadLine();
        } while (!new List<String>(){"1", "2", "3"}.Contains(input));

        // Collects goal details from the user.
        Console.WriteLine();
        Console.Write("What's the name of your goal? ");
        string name = Console.ReadLine().Replace("|", "").Trim();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine().Replace("|", "").Trim();
        Console.Write("What is the amount of points associated with this goal? ");
        int pointsPer = int.Parse(Console.ReadLine());

        // Adds the new goal to the list based on the chosen type.
        switch (input) {
            case "1":
                _goals.Add(new SimpleGoal(name, description, pointsPer));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, pointsPer));
                break;
            case "3":
                Console.WriteLine("How many times does this need to be accomplished for a bonus? ");
                int timesToComplete = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, pointsPer, timesToComplete));
                break;
        }
    }

    // Displays all goals to the console.
    public void DisplayGoals() {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++) {
            Console.WriteLine($"  {i+1}. {_goals[i].GetInfo()}");
        }
        Console.WriteLine();
    }

    // Calculates and returns the total score from all goals.
    public int GetTotalScore() {
        return _goals.Aggregate(0, (total, current) => total + current.CalculateScore());
    }

    // Reads goals from a file and populates the goals list.
private void ReadFromFile() {
    foreach (string line in File.ReadLines(_filename)) {
        string[] contents = line.Split("|");
        // Parses the line and adds the corresponding goal type to the list.
        switch (contents[0]) {
            case "SimpleGoal:":
                _goals.Add(new SimpleGoal(contents[1], contents[2], int.Parse(contents[3]), !(contents[4]=="0")));
                break;
            case "EternalGoal:":
                _goals.Add(new EternalGoal(contents[1], contents[2], int.Parse(contents[3]), int.Parse(contents[4])));
                break;
            case "ChecklistGoal":
                _goals.Add(new ChecklistGoal(contents[1], contents[2], int.Parse(contents[3]), int.Parse(contents[4]), int.Parse(contents[5])));
                break;
            default:
                Console.WriteLine($"Error: Unsupported goal type '{contents[0]}' specified in the file.");
                break;
        }
    }
    
    // Check if no goals were loaded from the file
    if (_goals.Count == 0) {
        Console.WriteLine("No goals found in the file.");
    }
}


    // Writes the current goals to a file.
    public void WriteToFile() {
        using (StreamWriter sw = File.CreateText(_filename)) {
            foreach (Goal goal in _goals) {
                sw.WriteLine(goal.Serialize()); // Saves each goal's data in the file.
            }
        }
    }
    
}