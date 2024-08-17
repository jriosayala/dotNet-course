class NameSorter
{
    public static void Sorter(string inputFilePath, string outputFilePath)
    {
        try
        {
            // Read names from the input file
            List<string> names = new(File.ReadAllLines(inputFilePath));

            // Sort the names alphabetically
            names.Sort();

            // Write the sorted names to the output file
            File.WriteAllLines(outputFilePath, names);
            Console.WriteLine($"All names have been sorted and exported to output file: {outputFilePath}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file {inputFilePath} was not found");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}