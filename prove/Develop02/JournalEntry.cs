class JournalEntry
{
    public string _date;

    public string _prompt;

    public string _response;

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "What was the best part of your day?",
            "Who was the most interesting person you interacted with today?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?"
        };

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(0, 5);
        
        _date = DateTime.Now.ToString();
        _prompt = prompts[magicNum];
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
    }

}