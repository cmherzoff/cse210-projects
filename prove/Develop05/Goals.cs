using System.IO;
class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private int _score = 0;

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void AddGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            SimpleGoal goal = new SimpleGoal();
            _goals.Add(goal);
        }
        else if (choice == "2")
        {
            EternalGoal goal = new EternalGoal();
            _goals.Add(goal);
        }
        else if (choice == "3")
        {
            ChecklistGoal goal = new ChecklistGoal();
            _goals.Add(goal);
        }
        else if (choice == "4")
        {
            NegativeGoal goal = new NegativeGoal();
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetConsoleString()}");
        }
    }

    public void RecordGoal()
    {
        DisplayGoals();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        
        int points = _goals[choice - 1].RecordEvent();

        _score += points;

        Console.WriteLine($"You earned {points} points!");
    }

    public void DisplayProgress()
    {
        DisplayScore();
        DisplayGoals();
    }

    public void SaveGoals()
    {
        List<string> lines = new List<string>();

        lines.Add(_score.ToString());

        foreach (BaseGoal goal in _goals)
        {
            lines.Add(goal.GetSaveString());
        }

        File.WriteAllLines("goals.txt", lines);

        Console.WriteLine("Goals saved successfully.");
    }

    public int GetScore()
    {
        return _score;
    }
    
    public void LoadGoals()
    {
        string[] lines = File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool complete = bool.Parse(parts[4]);

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(name, description, points, complete, goalType);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(name, description, points, complete, goalType);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int amountCompleted = int.Parse(parts[5]);
                int targetAmount = int.Parse(parts[6]);
                int bonusPoints = int.Parse(parts[7]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, 
                complete, goalType, amountCompleted, targetAmount, bonusPoints);

                _goals.Add(goal);
            }
            else if (goalType == "NegativeGoal")
            {
                NegativeGoal goal = new NegativeGoal(name, description, points, complete, goalType);
            }

            Console.WriteLine("Goals loaded successfully.");
        }
    }
}