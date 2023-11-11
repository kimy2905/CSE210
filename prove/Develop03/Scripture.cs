using System.Runtime.InteropServices;

class Scripture
{
    private List<Word> Words = new List<Word>();
    private string Verse;
    private Reference Reference = new Reference();


    public void setReference(string book, int chapter, int verse, string verses = "")
    {  
        
        Reference.setBook(book);
        Reference.setChapter(chapter);
        Reference.setVerse(verse);
        Reference.setVerses(verses);
    }
    
    public void setVerse(string verse)
    {
        Verse = verse;
        string[] words = Verse.Split(' ');

        foreach (string word in words)
        {
            Words.Add(new Word(word));
        }
    }

    public void hideWords()
    {
        Random rnd = new Random();
        int i = rnd.Next(0,Words.Count);
        while (Words[i].getStatus() == false)
        {
            i = rnd.Next(0,Words.Count);
        }
        Words[i].hideWord();
    }
    public void displayScripture()
    {
        string scripture = "";
        scripture = scripture + Reference.parseToString() + " ";
        foreach (Word word in Words)
        {
            scripture = scripture + " " + word.getWord();
        }
        Console.WriteLine(scripture);
    }

    public bool notAllWordsHidden()
    {
        foreach (Word _word in Words)
        {
            if (_word.getStatus() == true)
            {
                return true;
            }
        }

        return false;
    }
}