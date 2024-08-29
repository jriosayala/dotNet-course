namespace PracticeTwo;

public class Vehicle(string make, string model, int year)
{
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;
    public int Year { get; set; } = year;

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
    }
}
