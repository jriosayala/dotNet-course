namespace PracticeTwo;

public class Manager(string name, int employeeID, decimal salary, int teamSize) : Employee(name, employeeID, salary), IWorkable
{
    public int TeamSize { get; set; } = teamSize;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {TeamSize}");
    }

    public void Work()
    {
        Console.WriteLine($"{Name} is complaining with a team of {TeamSize} interns.");
    }

    public void TakeBreak()
    {
        Console.WriteLine($"{Name} is taking a break from punishing it's interns.");
    }
}
