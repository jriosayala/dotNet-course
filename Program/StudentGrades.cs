class StudentGrades
{
    private readonly List<double> grades = [];

    public void InputGrades()
    {
        bool isInputtingGrades = true;
        while(isInputtingGrades){

        Console.WriteLine("Enter agrade (or type 'done' to finish): ");
        string? input = Console.ReadLine();
        if (input.ToLower().Equals("done"))
        {
            isInputtingGrades = false;
        }
        else
        {
            if (double.TryParse(input, out double grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    grades.Add(grade);
                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter valid grade bertween 0 and 100");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a numeric value");
            }
        }

        }
    }
    // Sort grades in ascending order

    public void CalculateMinMaxAvg()
    {
        double averageGrade = grades.Average();
        double highestGrade = grades.Max();
        double lowestGrade = grades.Min();
        Console.WriteLine($"\nNumber of grades entered: {grades.Count}. \nThe average grade is: {averageGrade}, the highest is: {highestGrade} and the lowest is: {lowestGrade}");
    }

    public void DisplayGrades() {
        Console.WriteLine("Here's your input listed");
        grades.Sort();
        foreach(double grade in grades) {
            Console.WriteLine(grade);
        }
    }
}

