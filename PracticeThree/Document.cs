namespace PracticeThree;

public class Document(string title, string content) : IPrintable, ISavable
{
    public string Title { get; set; } = title;
    public string Content { get; set; } = content;

    public void Print()
    {
        Console.WriteLine($"Printing Document: {Title}");
        Console.WriteLine(Content);
    }

    public void Save()
    {
        Console.WriteLine($"Saving Document: {Title}");
        // Simulate saving the document
    }
}