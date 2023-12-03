class Word 
{
    private string letters;
    private bool status;

    public Word(string word)
    {
        letters = word;
        status = true;
    }
    public void setWord(string word)
    {
        letters = word;
    }

    public string getWord()
    {
        return letters;
    }

    public bool getStatus()
    {
        return status;
    }

    public void hideWord()
    {   
        string hiddenWord = "";
        int counter = letters.Length;
        for (int i = 0; i < counter ; i++)
        {
            hiddenWord = hiddenWord + "_ ";
        }
        status = false;
        letters = hiddenWord;
    }


}