// class BreathingActivity : Activity
// {
  
//     public BreathingActivity(int duration) : base(duration)
//     {
       
//     }

//     public override void Play()
//     {
     
//         Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        
//         LoadingAnimation("Get ready");
//         for (int i = 0; i < _activityDuration; i++)
//         {
//             LoadingAnimation("Breathe in...");
//             LoadingAnimation("Breathe out...");
//         }
       
//         Console.WriteLine("Breathing Game completed! Press [Enter] to continue.");
//         Console.ReadLine();
//     }
// }

class BreathingActivity : Activity
{
    public BreathingActivity(int _duration, string _logFileName) : base(_duration, _logFileName) { }

    public override void Play()
    {
        Log("Breathing Activity Started");
        LoadingAnimation("Get ready");
        DateTime _startTime = DateTime.Now;

        while ((DateTime.Now - _startTime).TotalSeconds < _activityDuration)
        {
            Console.WriteLine("Breathe in...");
            LoadingAnimation();
            Console.WriteLine("Breathe out...");
            LoadingAnimation();
        }
        Log($"Great job! You have completed the Breathing Activity for {_activityDuration} seconds.");
        Console.WriteLine($"Great job! You have completed the Breathing Activity for {_activityDuration} seconds.");
        LoadingAnimation("Finishing");
    }
}

