class ListingActivity : BaseActivity
{
    public ListingActivity(): base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are some personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void RunActivity()
    {
        StartActivity();

        Random random = new Random();
        int promptNumber = random.Next(_prompts.Length);

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        
        Console.WriteLine($"--- {_prompts[promptNumber]} ---");

        RunCountDownMessage("You may begin in", 5);
        
        int count = 0;

        while (!HasTimerExpired())
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (response != "")
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items!");

        EndActivity();
    }
}