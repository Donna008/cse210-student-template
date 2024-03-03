// using System.Text;

// class ReflectionActivity : Activity
// {
 
//     public ReflectionActivity(int duration) : base(duration)
//     {
        
//     }
//     public override void Play()
//     {
//         Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
        
//         LoadingAnimation("Think of a time when you did something truly selfless.");
        
//         LoadingAnimation("Think of a time when you stood up for someone else.");
       
//         LoadingAnimation("Think of a time when you helped someone in need..");
     
//         LoadingAnimation("Think of a time when you stood up for someone else.");
//         Console.WriteLine("Refelecation Activity completed! Press [Enter] to continue.");
//         Console.ReadLine();
//     }
//     protected override void LoadingAnimation(string _message)
//     {
        
//         int _elapsed = 0;
//         string[] _emojis ={ "📝",
//                             " ",
//                             "📝",
//                             " ",
//                             "📝"
//                             };
//         int _emojiIndex = 0;

//         Console.OutputEncoding = Encoding.UTF8;

//         while (_elapsed < _activityDuration)
//         {
           
//             Console.WriteLine(_message);
//             for (int i = 0; i <= _emojiIndex; i++)
//             {
//                 Console.Write(_emojis[i]);
//                 Thread.Sleep(3000);
//             }
//             if (_emojiIndex == _emojis.Length - 1)
//             {
                
//                 _emojiIndex = -1;
//             }
//             else
//             {
//                 _emojiIndex++;
//             }
//             _elapsed +=3000;
           
        
//         }
//         Console.Clear();
//     }
// }

using System.Text;
class ReflectionActivity : Activity
{
   

    public ReflectionActivity(int _duration,string _logFileName) : base(_duration,_logFileName) { }

    public override void Play()
    {
        Log("Relection Activity Started");
        LoadingAnimation("Get ready");
        Random _random = new Random();
        DateTime _startTime = DateTime.Now;

        while ((DateTime.Now - _startTime).TotalSeconds < _activityDuration)
        {
            LoadingAnimation();
            string[] _reflectionQuestions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            Console.WriteLine(_reflectionQuestions[_random.Next(_reflectionQuestions.Length)]);
        }

        Log($"Great job! You have completed the Reflection Activity for {_activityDuration} seconds.");
        Console.WriteLine($"Great job! You have completed the Reflection Activity for {_activityDuration} seconds.");
        LoadingAnimation("Finishing");
    }
    
}
