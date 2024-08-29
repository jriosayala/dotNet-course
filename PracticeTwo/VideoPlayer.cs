namespace PracticeTwo;

public class VideoPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing video...");
    }

    public void Pause()
    {
        Console.WriteLine("Pausing video...");
    }
}
