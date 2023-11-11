using System.ComponentModel;

class Reference
{
    private string Book;
    private int Chapter;
    private int Verse;
    private string Verses;

    public void setBook(string book)
    {
        Book = book;
    }

    public void setChapter(int chapter)
    {
        Chapter = chapter;
    }

    public void setVerse(int verse)
    {
        Verse = verse;
    }

    public void setVerses(string verses)
    {
        Verses = verses;
    }

    public string parseToString()
    {
        string parsedRef = "";
        parsedRef = parsedRef + Book + " "; 
        parsedRef = parsedRef + Chapter + ":";
        if (Verses == "")
        {
            parsedRef = parsedRef + Verse;
        }
        else
        {
            parsedRef = parsedRef + Verses;
        }
        return parsedRef;
    }
}