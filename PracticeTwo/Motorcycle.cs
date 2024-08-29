namespace PracticeTwo;

public class Motorcycle(string make, string model, int year, bool hasSidecar) : Vehicle(make, model, year)
{
    public bool HasSidecar { get; set; } = hasSidecar;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }
}
