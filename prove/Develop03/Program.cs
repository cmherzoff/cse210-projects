using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("2 Nephi", 2, 25,
        "Adam fell that men might be; and men are, that they might have joy.");

        string response = "";

        while (response != "quit" && !myScripture.IsFullyHidden())
        {
            Console.Clear();
            myScripture.ShowScripture();

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            response = Console.ReadLine();

            if (response != "quit")
            {
                myScripture.HideRandomWords();
            }
        }
        
        if (myScripture.IsFullyHidden())
        {
            Console.Clear();
            myScripture.ShowScripture();
        }        
    }
}