class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public void start()
    {
        Console.Clear();
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        name = "Listing Activity";

        displayStartMessage();

        Console.Clear();
        Console.WriteLine("Get Ready!\n");
        displayAnimation();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Random gen = new Random();
        int index = gen.Next(0,prompts.Length);
        Console.WriteLine($" ---{prompts[index]}--- ");
        Console.WriteLine("You may begin: ");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        int counter = 0;
        while (start < end)
        {
            Console.ReadLine();
            counter++;
            start = DateTime.Now;
        }

        Console.WriteLine("Well done!");
        displayAnimation();
        Console.WriteLine($"You listed {counter} items!");
        Console.WriteLine($"You have completed {duration} seconds {name}.");
        timesCompleted++;
        Console.WriteLine($"You have completed this activity {timesCompleted} times.");
        displayAnimation();
        Console.Clear();
    }
}