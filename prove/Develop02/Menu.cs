class Menu
{
    public int ProcessMenu()
    {
        int input = 0;

        while (input < 1 || input > 5)
        {
            if (input < 1 || input > 5)
            {
                Console.WriteLine("Please enter a number between 1 and 5. ");
            }
            Console.WriteLine("Create, Display, Save, or Read Journal Entries.");
            Console.WriteLine("1. Create new journal entry.");
            Console.WriteLine("2. Display all jounral entries.");
            Console.WriteLine("3. Save journal to a file.");
            Console.WriteLine("4. Read journal from a file.");
            Console.WriteLine("5. Quit.");
            Console.WriteLine("> ");
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number.");
                input = 0;
            }

            
        }
        return input;
    }
}