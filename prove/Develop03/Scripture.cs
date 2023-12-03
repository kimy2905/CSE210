using System.Runtime.InteropServices;

class Scripture
{
    private List<Word> words = new List<Word>();
    private string verse;
    private Reference reference = new Reference();


    public void setReference(string book, int chapter, int verse, string verses = "")
    {  
        
        reference.setBook(book);
        reference.setChapter(chapter);
        reference.setVerse(verse);
        reference.setVerses(verses);
    }
    
    public void setVerse(string verse)
    {
        this.verse = verse;
        string[] words = this.verse.Split(' ');

        foreach (string word in words)
        {
            this.words.Add(new Word(word));
        }
    }

    public void hideWords()
    {
        Random rnd = new Random();
        int i = rnd.Next(0,words.Count);
        while (words[i].getStatus() == false)
        {
            i = rnd.Next(0,words.Count);
        }
        words[i].hideWord();
    }
    public void displayScripture()
    {
        string scripture = "";
        scripture = scripture + reference.parseToString() + " ";
        foreach (Word word in words)
        {
            scripture = scripture + " " + word.getWord();
        }
        Console.WriteLine(scripture);
    }

    public bool notAllWordsHidden()
    {
        foreach (Word _word in words)
        {
            if (_word.getStatus() == true)
            {
                return true;
            }
             
        }
        return false;
        
    }
}