using System.Runtime.InteropServices;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _verse;
    private Reference _reference = new Reference();

    public void setReference(string book, int chapter, int verse, string verses = "")
    {  
        
        _reference.setBook(book);
        _reference.setChapter(chapter);
        _reference.setVerse(verse);
        _reference.setVerses(verses);
    }
    
    public void setVerse(string verse)
    {
        _verse = verse;
        string[] words = _verse.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void hideWords()
    {
        Random rnd = new Random();
        int i = rnd.Next(0,_words.Count);
        while (_words[i].getStatus() == false)
        {
            i = rnd.Next(0,_words.Count);
        }
        _words[i].hideWord();
    }
    public void displayScripture()
    {
        string scripture = "";
        scripture = scripture + _reference.parseToString() + " ";
        foreach (Word word in _words)
        {
            scripture = scripture + " " + word.getWord();
        }
        Console.WriteLine(scripture);
    }
}