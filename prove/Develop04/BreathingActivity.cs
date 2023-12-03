class BreathingActivity : Activity
{
    public void start()
    {
        Console.Clear();
        name = "Breathing Activity";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        displayStartMessage();

        Console.Clear();
        Console.WriteLine("Get Ready!\n");
        displayAnimation();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);

        while (start < end)
        {
            Console.Write("Breathe in...");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("\nBreathe out...");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
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

            start = DateTime.Now;
        }
        
        Console.WriteLine("\nAwesome job!");
        displayAnimation();
        timesCompleted ++;
        Console.WriteLine($"\nYou have completed {duration} seconds of the Breathing Activity.");
        Console.WriteLine($"You have completed this activity {timesCompleted} times.");
        displayAnimation();
        Console.Clear();
    }
}