class Scripture
{
    private List<Word> _words;

    // TODO - Add scripture reference

    public Scripture (string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);

        _words[7].Hide();
        // TODO
    }

    public Scripture (string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
        // TODO
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    // TODO - Add constuctor for ScriptureReference

    /****************************************************************
    * ConverToWordList() - this method will receive a string parameter,
    * which is a paragrpah of text. It will slpit that text into words
    * and add those words to a List<word> and return the list
    ***************************************************************/

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
}