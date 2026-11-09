using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Drawing Activity");
        Console.WriteLine("5. Quit");
        Console.Write("Select a choice from the menu: ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.RunActivity();
        }
        else if (choice == "2")
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.RunActivity();
        }
        else if (choice == "3")
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.RunActivity();
        }
        else if (choice == "4")
        {
            DrawingActivity drawingActivity = new DrawingActivity();
            drawingActivity.RunActivity();
        }
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye");
        }
        else
        {
            Console.WriteLine("Invalid number, try again.");
        }
    }
}