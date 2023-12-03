class Goal
{
    protected int points;
    protected string name;
    protected string description;
    protected string type;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    public virtual void displayGoal()
    {
        Console.WriteLine($"[ ] {name} ({description})");
    }

    public virtual string formatGoal()
    {
        return $"{type},{name},{description},{points}";
    }

    public string getName()
    {
        return name;
    }

    public virtual int completeGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        return points;
    }
}