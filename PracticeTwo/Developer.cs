namespace PracticeTwo;

public class Developer(string name, int employeeID, decimal salary, string programmingLanguage) : Employee(name, employeeID, salary), IWorkable
{
    public string ProgrammingLanguage { get; set; } = programmingLanguage;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }

    public void Work()
    {
        Console.WriteLine($"{Name} is writing code in {ProgrammingLanguage}.");
    }

    public void TakeBreak()
    {
        Console.WriteLine($"{Name} is taking a break from Deloitte courses.");
    }
}
