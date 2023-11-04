class Activity
{
    protected string description;
    protected string name;
    protected int duration;

    protected string[] animation = {"X","x"};

    public int menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit Program");
        Console.Write("Select a choice from the menu: ");
        int input = int.Parse(Console.ReadLine());

        while (input < 1 || input > 4)
        {
            Console.WriteLine("Invalid choice, try again.");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());
        }

        return input;
    }
    public void displayAnimation()
    {
        for (int i = 0; i < 4; i++)
        {
            foreach (string icon in animation)
            {
                Console.Write(icon);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    public void displayStartMessage()
    {
        Console.WriteLine($"Welcome to the {name}.\n");
        Console.WriteLine(description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
    }
}