using System.ComponentModel;
using System.Runtime.CompilerServices;

class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private string verses;

    public void setBook(string book)
    {
        this.book = book;
    }

    public void setChapter(int chapter)
    {
        this.chapter = chapter;
    }

    public void setVerse(int verse)
    {
        this.verse = verse;
    }

    public void setVerses(string verses)
    {
        this.verses = verses;
    }

    public string parseToString()
    {
        string parsedRef = "";
        parsedRef = parsedRef + book + " "; 
        parsedRef = parsedRef + chapter + ":";
        if (verses == "")
        {
            parsedRef = parsedRef + verse;
        }
        else
        {
            parsedRef = parsedRef + verses;
        }
        return parsedRef;
    }
}