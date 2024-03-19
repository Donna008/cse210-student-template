// using System;

// public abstract class Gola
// {
//     protected int _points;
//     string _description;
//     private string _nameOfGoal;
//     bool _complete;

//     public Gola(string name)
//     {
//         _points = 0;
//         // _description = description;
//         _nameOfGoal = name;
//     }

//     public string SetGoal()
//     {
        
//     }
// }

// using System;

// public abstract class Goal
// {
//     private string name;
//     private int completedTimes;

//     public string GetName()
//     {
//         return name;
//     }

//     public int GetCompletedTimes()
//     {
//         return completedTimes;
//     }

//     public void SetCompletedTimes(int value)
//     {
//         completedTimes = value;
//     }

//     public Goal(string name)
//     {
//         this.name = name;
//         completedTimes = 0;
//     }

//     public abstract void RecordEvent();

//     public abstract bool IsComplete();

//     public abstract int GetPoints();

//     public abstract int GetBonusPoints();

//     public virtual void DisplayProgress()
//     {
//         Console.WriteLine($"{name}: {IsCompleteDisplay()}");
//     }

//     protected string IsCompleteDisplay()
//     {
//         return IsComplete() ? "[X]" : "[ ]";
//     }
// }

using System;
using System.Collections.Generic;
using System.IO;
// Abstract class representing a generic goal.
public abstract class Goal { 
    protected string _name; // Name of the goal.
    protected string _description; // Description of the goal.
    protected int _pointsPer; // Points earned per completion of the goal.

    // Constructor to set basic properties of the goal.
    public Goal(string name, string description, int pointsPer) {
        _name = name;
        _description = description;
        _pointsPer = pointsPer; // Assign initial values.
    }
    
    // Method to calculate the score for the goal. Implementation must be provided in derived classes.
    public abstract int CalculateScore();

    // Method to mark the goal as completed. Implementation varies in derived classes.
    public abstract void Complete();

    // Method to get information about the goal. Derived classes define the specific format.
    public abstract string GetInfo();

    // Method to serialize the goal's data into a string. Specific format is defined in derived classes.
    public abstract string Serialize();
    // Method to load goal data from a text file
// Method to load goal data from a text file
public static Goal LoadFromTextFile(string filename)
{
    try
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Split the line into parts using the pipe character as the separator
                string[] parts = line.Split('|');

                // Ensure the line has the correct number of parts
                if (parts.Length != 5)
                {
                    Console.WriteLine("Error: Invalid format in the file.");
                    return null;
                }

                // Extract information from parts
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                if (!int.TryParse(parts[3], out int pointsPer))
                {
                    Console.WriteLine("Error: Invalid points per completion information in the file.");
                    return null;
                }
                if (!int.TryParse(parts[4], out int completionStatus))
                {
                    Console.WriteLine("Error: Invalid completion status information in the file.");
                    return null;
                }

                // Determine the type of goal based on the goalType
                switch (goalType)
                {
                    case "SimpleGoal":
                        return new SimpleGoal(name, description, pointsPer);
                    // Add cases for other goal types if needed
                    default:
                        Console.WriteLine("Error: Unsupported goal type specified in the file.");
                        return null;
                }
            }

            Console.WriteLine("Error: No goals found in the file.");
            return null;
        }
    }
    catch (IOException)
    {
        Console.WriteLine("Error: Unable to read goal data from the file. Please check the filename and try again.");
        return null;
    }
}

    public virtual bool IsCompleted()
    {
        throw new NotImplementedException();
    }
}