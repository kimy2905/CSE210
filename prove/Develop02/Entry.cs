public class Entry{
    private string Response;

    private string Prompt;
    private string Date;
    private List<string> Prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void setResponse(string response)
    {
        Response = response;
    }

    public void setDate(string date)
    {
        Date = date;
    }

    public void setPrompt(string prompt)
    {
        Prompt = prompt;
    }

    public string getPrompt()
    {
        return Prompt;
    }
    
    public string getDate()
    {
        return Date;
    }

    public string getRandomPrompt()
    {
        Random random = new Random();
        int randInt = random.Next(0,Prompts.Count);
        
        return Prompts[randInt];
    }
    public string getResponse()
    {
        return Response;
    }
}

