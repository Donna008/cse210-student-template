// using System;
// using System.Threading;

// abstract class Activity{
//     protected readonly int _activityDuration;

//     protected Activity(int duration)
//     {
//         _activityDuration = duration;
//     }

//     public abstract void Play();

//     protected virtual void LoadingAnimation(String message = "Loading")
//     {
//         // Console.Clear();
//         int _elapsed = 0;
//         while (_elapsed < _activityDuration)
//         {
//             Console.Write($"{message} \\");
//             Thread.Sleep(1000);
//             Console.Clear();
//             Console.Write($"{message} |");
//             Thread.Sleep(1000);
//             Console.Clear();
//             Console.Write($"{message} /");
//             Thread.Sleep(1000);
//             Console.Clear();
//             Console.Write($"{message} —");
//             Thread.Sleep(1000);
//             Console.Clear();
//             _elapsed += 4000;
//         }
//     }
   
// }

using System;
using System.IO;
abstract class Activity
{
    protected int _activityDuration;
    protected string _logFileName;

    public Activity(int _duration, string _log_FileName)
    {
        _activityDuration = _duration;
        _logFileName = _log_FileName;
    }

    public abstract void Play();
    protected void Log(string _message)
    {
        using (StreamWriter writer = new StreamWriter(_logFileName, true))
        {
            writer.WriteLine($"{DateTime.Now}: {_message}");
        }
    }

    protected virtual void LoadingAnimation(string _message = "Loading")
    {
        
        int _elapsed = 0;
        while (_elapsed < _activityDuration)
        {
            Console.Write($"{_message} \\");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.Write($"{_message} |");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.Write($"{_message} /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.Write($"{_message} —");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            _elapsed += 1700;
        }
    }
}
