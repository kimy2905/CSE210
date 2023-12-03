class ChecklistGoal : Goal
{
    private int target;
    private int bonus;
    private int completed;
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed = 0) : base(name,description,points)
    {
        this.target = target;
        this.bonus = bonus;
        this.completed = completed;
        this.type = "Checklist";
    }

    public override void displayGoal()
    {
        if (completed == target)
        {
            Console.WriteLine($"[X] {name} ({description}) -- Completed {completed}/{target}");
        }
        else
        {
            Console.WriteLine($"[ ] {name} ({description}) -- Completed {completed}/{target}");
        }
    }

    public override string formatGoal()
    {
        return $"{type},{name},{description},{points},{completed},{target},{bonus}";
    }

    public override int completeGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        completed++;
        return points;
    }
}