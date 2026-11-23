using System;
class Program
{
    static void Main(string[] args)
    {
        Goals myGoals = new Goals();

        int choice = 0;

        while (choice != 7)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {myGoals.GetScore()} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");

            if (choice == 1)
            {
                myGoals.AddGoal();
            }           
            else if (choice == 2)
            {
                myGoals.RecordGoal();
            }
            else if (choice == 3)
            {
                myGoals.DisplayGoals();
            }
            else if (choice == 4)
            {
                myGoals.SaveGoals();
            }
            else if (choice == 5)
            {
                myGoals.LoadGoals();
            }
            else if (choice == 6)
            {
                myGoals.DisplayScore();
            }
            else if (choice == 7)
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again");
            }
        }
    }
}