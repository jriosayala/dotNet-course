class TextAnalyzer
{
    public string ReadBlockOfText()
    {
        string inputText = "";
        string line;
        while ((line = Console.ReadLine()) != null && line != "")
        {
            inputText += line + "\n";
        }
        return inputText.Trim();
    }

    internal static readonly char[] separator = [' ', '\n', '\t'];
    internal static readonly char[] separatorArray = ['.', '\n', '\t'];
    internal static readonly string[] separatorArray0 = ["\n\n"];

    public int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    public int CountSentences(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        string[] sentences = text.Split(separatorArray, StringSplitOptions.RemoveEmptyEntries);
        return sentences.Length;

    }
    public int CountParagraphs(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        string[] paragraphs = text.Split(separatorArray0, StringSplitOptions.RemoveEmptyEntries);
        return paragraphs.Length;

    }
}