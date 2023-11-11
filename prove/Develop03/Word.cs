class Word 
{
    private string Letters;
    private bool Status;

    public Word(string word)
    {
        Letters = word;
        Status = true;
    }
    public void setWord(string word)
    {
        Letters = word;
    }

    public string getWord()
    {
        return Letters;
    }

    public bool getStatus()
    {
        return Status;
    }

    public void hideWord()
    {   
        string hiddenWord = "";
        int counter = Letters.Length;
        for (int i = 0; i < counter ; i++)
        {
            hiddenWord = hiddenWord + "_ ";
        }
        Status = false;
        Letters = hiddenWord;
    }


}