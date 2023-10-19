using System.ComponentModel;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _verses;

    public void setBook(string book)
    {
        _book = book;
    }

    public void setChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void setVerse(int verse)
    {
        _verse = verse;
    }

    public void setVerses(string verses)
    {
        _verses = verses;
    }

    public string parseToString()
    {
        string parsedRef = "";
        parsedRef = parsedRef + _book + " "; 
        parsedRef = parsedRef + _chapter + ":";
        if (_verses == "")
        {
            parsedRef = parsedRef + _verse;
        }
        else
        {
            parsedRef = parsedRef + _verses;
        }
        return parsedRef;
    }
}