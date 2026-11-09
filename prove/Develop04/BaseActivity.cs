class BaseActivity
{
    private int _duration;
    private DateTime _endTime;
    private string _activityName;
    private string _description;
    public BaseActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);

        Console.WriteLine();
        Console.Write("How long, in seconds, will this session be? ");
        _duration = int.Parse(Console.ReadLine());

        RunCountDownMessage("Get ready", 5);

        StartTimer();
    }

    public void EndActivity()
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        RunSpinnerMessage("", 5);

        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName}.");
        RunSpinnerMessage("", 5);
    }
    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i > 0; i--)
        {
            // Console.Clear();
            Console.Write($"\r{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Write($"{message} ");
        // DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        // for(int i = 0; i < seconds; i++)
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }

        // Console.Write($"{message} ");
        // string spinnerAnimation = "-\\|/";
        // int index = 0;
        // for (int i=0; i<20; i++)
        // {
        //     Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
        //     Console.Write("\b");
        //     Thread.Sleep(300);
        // }
        // Console.Clear();

        // Console.Write($"{message} ");
        // string fishAnimation = "><))))o>";
        // for (int i=0; i<20; i++)
        // {
        //     Console.Write($" {fishAnimation}");
        //     Console.Write("\b\b\b\b\b\b\b\b");
        //     Thread.Sleep(300);
        // }
        // Console.Clear();

        // Console.Write($"{message} ");
        // string faceAnimation = "(^_^)(-_-)";
        // for (int i=0; i<20; i++)
        // {
        //     Console.Write($"{faceAnimation[0..5]}");
        //     Thread.Sleep(300);
        //     Console.Write("\b\b\b\b\b");
        //     Console.Write($"{faceAnimation[5..]}");
        //     Thread.Sleep(300);
        //     Console.Write("\b\b\b\b\b");
        // }

        Console.CursorVisible = true;
        Console.WriteLine();
    }
}