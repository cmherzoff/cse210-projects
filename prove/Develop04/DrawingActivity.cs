class DrawingActivity : BaseActivity
{
    public DrawingActivity(): base("Drawing Activity", "This activity will help you to create and express yourself through drawing.")
    {
    }

    private string[] _prompts =
    {
        "Draw something that makes you happy.",
        "Draw your favorite place.",
        "Draw your dream house.",
        "Draw your favorite animal.",
        "Draw something strange."
    };
    public void RunActivity()
    {
        StartActivity();

        Random random = new Random();
        int promptNumber = random.Next(_prompts.Length);

        Console.WriteLine();
        Console.WriteLine("Use your paper and pencil to complete the following drawing prompt.");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[promptNumber]} ---");
        Console.WriteLine();
        Console.WriteLine("Press enter when you are ready to start.");
        Console.ReadLine();

        StartTimer();

        while (!HasTimerExpired())
        {
            RunSpinnerMessage("Enjoy drawing", 5);
        }

        EndActivity();
    }
}