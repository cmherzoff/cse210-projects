class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;

    public Scripture (string bookName, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(bookName, chapter, verse);
        _words = ConvertToWordList(text);
    }

    public Scripture (string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(bookName, chapter, startVerse, endVerse);
        _words = ConvertToWordList(text);
    }

    public void ShowScripture()
    {
        Console.WriteLine(_reference.GetDisplayText());

        foreach(Word word in _words)
        {
            word.Display();
        }
        
        Console.WriteLine();
    }

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach (string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int hiddenThisRound = 0;
        int visibleWords = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords++;
            }
        }

        while (hiddenThisRound < 2 && hiddenThisRound < visibleWords)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenThisRound++;
            }
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}