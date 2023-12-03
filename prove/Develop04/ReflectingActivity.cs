class ReflectingActivity : Activity
{
    private string[] prompts = {
        "Recall a situation when you supported someone else.",
        "Recall a moment when you faced a significant challenge.",
        "Reflect on an instance when you provided assistance to someone in a time of need."
    };
    
    private string[] questions = {
        "What made this experience hold significance for you?",
        "Were there previous instances in which you engaged in similar activities?",
        "What initiated your involvement in this endeavor?",
        "How did you emotionally respond when you finished it?",
        "What distinguished this occasion from others in which your success may have been less pronounced?",
    };
    public void start()
    {
        Console.Clear();
        name = "Reflection Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        displayStartMessage();

        Console.Clear();
        Console.WriteLine("Get Ready!\n");
        displayAnimation();
        Console.WriteLine("Consider the following prompt:");

        Random gen = new Random();
        int index = gen.Next(0,prompts.Length);
        
        Console.WriteLine($"--- {prompts[index]} ---");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        
        Console.Clear();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        while (start < end)
        {
            index = gen.Next(0,questions.Length);
            Console.WriteLine($"{questions[index]}");
            displayAnimation();
            start = DateTime.Now;        
        }

        Console.WriteLine("Well done!\n");
        displayAnimation();
        Console.WriteLine($"You have completed {duration} seconds of the {name}");
        timesCompleted++;
        Console.WriteLine($"You have completed this activity {timesCompleted} times.");
        displayAnimation();
        Console.Clear();
    }
}
