class NegativeGoal : BaseGoal
{
    public NegativeGoal(string name, string description, int points, bool complete, string goalType)
    : base (name, description, points, complete, goalType)
    {
    }
    public NegativeGoal() : base("NegativeGoal")
    {
    }

    public override int RecordEvent()
    {
        return -Math.Abs(GetPoints());
    }
}