// class ListingAcivity : Activity
// {

//    public ListingAcivity(int duration) : base(duration)
//     {
        
//     }
//     public override void Play()
//     {
      
       
//         CountdownTimer();

//         Console.Clear();
//         Console.WriteLine("Listing Activity completed! Press [Enter] to continue.");
//         Console.ReadLine();
//     }
//     private void CountdownTimer()
//     {
//         Console.Clear();
//         Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
       
//         Thread.Sleep(3000);
//         int _timeRemaining = _activityDuration;
//         while (_timeRemaining > 0)
//         {
//             Console.Clear();
//             Console.WriteLine($"Time remaining: {_timeRemaining} seconds");
//             LoadingAnimation("Get ready");
//             Thread.Sleep(_activityDuration);
//             LoadingAnimation("Who are some of your personal heroes?");
//             Thread.Sleep(_activityDuration);
//             LoadingAnimation("When have you felt the Holy Ghost this month?");
//             Thread.Sleep(_activityDuration);
//             LoadingAnimation("Who are people that you have helped this week?");
//             Thread.Sleep(_activityDuration);
//             LoadingAnimation("What are personal strengths of yours?");
//             Thread.Sleep(_activityDuration);
//             LoadingAnimation("Who are people that you appreciate?");
//             Console.Clear();
//             _timeRemaining--;
//         }
//     }
// }

class ListingActivity : Activity
{
    private string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int _duration, string _logFileName) : base(_duration, _logFileName) { }

    public override void Play()
    {
        LoadingAnimation("Get ready");
        Log("Listing Activity Started");

        int _itemsListed = 0;
        DateTime _startTime = DateTime.Now;

        while ((DateTime.Now - _startTime).TotalSeconds < _activityDuration)
        {
            Random _random = new Random();
            string _prompt = Prompts[_random.Next(Prompts.Length)];
            Console.WriteLine(_prompt);
            Console.WriteLine("Press Enter when ready to start...");
            Console.ReadLine();
            Console.Write("Enter an item: ");
            Console.ReadLine(); // You can store the entered item if needed
            _itemsListed++;
            LoadingAnimation();
        }

        Log($"You listed {_itemsListed} items.");
        Log($"Great job! You have completed the Listing Activity for {_activityDuration} seconds.");
        Console.WriteLine($"You listed {_itemsListed} items.");
        Console.WriteLine($"Great job! You have completed the Listing Activity for {_activityDuration} seconds.");
        LoadingAnimation("Finishing");
    }
}
