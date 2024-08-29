namespace PracticeTwo;

public class Car(string make, string model, int year, int numberOfDoors, bool hasSunroof) : Vehicle(make, model, year)
{
    public int NumberOfDoors { get; set; } = numberOfDoors;
    public bool HasSunroof { get; set; } = hasSunroof;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}, Has Sunroof: {HasSunroof}");
    }
}
