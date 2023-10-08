public class Entry{
    private string _response;
    private string _date;
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void setResponse(string response)
    {
        _response = response;
    }

    public void setDate(string date)
    {
        _date = date;
    }
    public string getRandomPrompt()
    {
        Random random = new Random();
        int randInt = random.Next(0,_prompts.Count);
        
        return _prompts[randInt];
    }
    public string getResponse()
    {
        return _response;
    }
}

