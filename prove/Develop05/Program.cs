using System;
class Program
{
    static void Main(string[] args)
    {
        // BaseGoal myGoal = new BaseGoal("BaseGoal");
        // Console.WriteLine(myGoal.GetConsoleString());

        // SimpleGoal mySimpleGoal = new SimpleGoal();

        // Console.WriteLine(mySimpleGoal.GetConsoleString());


        Goals myGoals = new Goals();

        myGoals.AddGoal();
        myGoals.AddGoal();

        myGoals.RecordGoal();
        myGoals.SaveGoals();
    }
}