class Word 
{
    private string _word;
    private bool _status;

    public Word(string word)
    {
        _word = word;
        _status = true;
    }
    public void setWord(string word)
    {
        _word = word;
    }

    public string getWord()
    {
        return _word;
    }

    public bool getStatus()
    {
        return _status;
    }

    public void hideWord()
    {   
        string hiddenWord = "";
        int counter = _word.Length;
        for (int i = 0; i < counter ; i++)
        {
            hiddenWord = hiddenWord + "_ ";
        }
        _status = false;
        _word = hiddenWord;
    }


}