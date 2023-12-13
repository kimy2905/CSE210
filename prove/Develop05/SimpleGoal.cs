class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, string description, int points, bool completed = false) : base(name,description,points)
    {
        this.completed = completed;
        type = "Simple";
    }

    public override void displayGoal()
    {
        if (completed)
        {
            Console.WriteLine($"[X] {name} ({description})");
        }
        else
        {
            Console.WriteLine($"[ ] {name} ({description})");
        }
    }

    public override string formatGoal()
    {
        return $"{type},{name},{description},{points},{completed}";
    }

    public override int completeGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        completed = true;
        return points;
    }
}