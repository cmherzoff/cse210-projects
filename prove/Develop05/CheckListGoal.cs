class ChecklistGoal : BaseGoal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, bool complete, 
    string goalType, int amountCompleted, int targetAmount, int bonusPoints)
    : base (name, description, points, complete, goalType)
    {
        _amountCompleted = amountCompleted;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal() : base("ChecklistGoal")
    {
        Console.Write("How many times does this goal need to be completed? ");
        _targetAmount = int.Parse(Console.ReadLine());

        Console.Write("How many bonus points will you receive? ");
        _bonusPoints = int.Parse(Console.ReadLine());

        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;

            if (_amountCompleted >= _targetAmount)
            {
                MarkComplete();
                return GetPoints() + _bonusPoints;
            }

            return GetPoints();
        }

        return 0;
    }

    public override string GetConsoleString()
    {
        string goalString = base.GetConsoleString();

        return $"{goalString} -- Completed {_amountCompleted}/{_targetAmount} times";
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTargetAmount()
    {
        return _targetAmount;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override string GetSaveString()
    {
        return $"{base.GetSaveString()}|{GetAmountCompleted()}|{GetTargetAmount()}|{GetBonusPoints()}";
    }
}