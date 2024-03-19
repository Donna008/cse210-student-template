// public class EternalGoal : Goal
// {
//     private int points;

//     public EternalGoal(string name, int pointValue) : base(name)
//     {
//         points = pointValue;
//     }

//     public override void RecordEvent()
//     {
//         SetCompletedTimes(GetCompletedTimes() + 1);
//     }

//     public override bool IsComplete()
//     {
//         return false;
//     }

//     public override int GetPoints()
//     {
//         return points;
//     }

//     public override int GetBonusPoints()
//     {
//         return 0;
//     }
// }

// Represents a goal that can be completed an unlimited number of times.
public class EternalGoal: Goal { 
    bool _status;
    int _timesCompleted; // Tracks how many times the goal has been completed.
    public override bool IsCompleted() {
        return _status;// Implement the logic to determine if the eternal goal is completed
    }
    // Constructor to initialize the eternal goal.
    public EternalGoal(string name, string description, int points, int timesCompleted = 0)
        : base(name, description, points) {
        _timesCompleted = timesCompleted; // Set the initial completion count.
    }

    // Calculate total score based on the number of times completed.
    public override int CalculateScore() {
        return _timesCompleted * _pointsPer; // Multiply completions by points per completion.
    }

    // Increment the completion count.
    public override void Complete() {
        _timesCompleted++; // Add one to the completion count.
    }

    // Get information about the goal's completion status.
    public override string GetInfo() {
        // Returns a string indicating the goal's name, description, and completion count.
        return $"[ ] {_name}: {_description} -- Currently completed: {_timesCompleted} time{(_timesCompleted==1?"":"s")}";
    }

    // Serialize the goal to a string for storage or transmission.
    public override string Serialize() {
        // Formats the goal's details for serialization.
        return $"EternalGoal:|{_name}|{_description}|{_pointsPer}|{_timesCompleted}";
    }
}