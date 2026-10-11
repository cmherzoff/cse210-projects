using System.IO;

class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }

    public void WriteToFile()
    {
        Console.Write("Enter a file name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputfile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void ReadFromFile()
    {
        Console.Write("Enter a file name: ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _entries.Clear();
        
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            JournalEntry entry = new JournalEntry();

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
    }
}