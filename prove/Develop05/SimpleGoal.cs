class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, string description, int points, bool completed = false) : base(name,description,points)
    {
        this.completed = completed;
        Type = "Simple";
    }

    public override void displayGoal()
    {
        if (completed)
        {
            Console.WriteLine($"[X] {Name} ({Description})");
        }
        else
        {
            Console.WriteLine($"[ ] {Name} ({Description})");
        }
    }

    public override string formatGoal()
    {
        return $"{Type},{Name},{Description},{Points},{completed}";
    }

    public override int completeGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
        completed = true;
        return Points;
    }
}