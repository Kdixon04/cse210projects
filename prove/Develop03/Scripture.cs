class Scripture
{
    private List<Word> words;

    // TODO - Add scripture Reference

    // Constructors are always public
    public Scripture(string bookName, int chapter, int verse, string text)
    {
        // TODO - 
    }
    // Cannot have two constructors that have the same input () 
    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
       _words = ConvertToWordList(text);

       _words[7].Hide();
        // TODO - 
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    //TODO - Add constructor for Scripture Reference

    /*******************************************
    * ConvertToWordList() - this method will recieve a string parameter,
    * which is a paragraph of text. It will split that text into words
    * and add those words to a List < word > and return the list
    *******************************************/

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }
}