namespace PracticeTwo;

public class MusicPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing music...");
    }

    public void Pause()
    {
        Console.WriteLine("Pausing music...");
    }
}
