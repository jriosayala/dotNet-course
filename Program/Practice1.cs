using NonPrimitiveTypes;

namespace Program
{
    static internal class Practice1
    {
        private static void Main(string[] args)
        {
            bool executingProgram = true;
            while (executingProgram)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Body Mass Index (BMI) Calculator");
                Console.WriteLine("2. Book Manager");
                Console.WriteLine("3. ATM");
                Console.WriteLine("4. Student Grade Manager");
                Console.WriteLine("5. Date Calculator");
                Console.WriteLine("6. Text Analyzer");
                Console.WriteLine("7. Name Sorter");
                Console.WriteLine("8. Exit");

                Console.WriteLine("Select an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Welcome to the BMI Calculator");
                        // Getting input from user
                        Console.Write("Enter your weight in kilograms: ");
                        double weight = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter your height in meters: ");
                        double height = Convert.ToDouble(Console.ReadLine());

                        BmiCalculator bmiCalculator = new(weight, height);
                        double bmi = bmiCalculator.CalculateBMI();

                        Console.WriteLine($"Your Body Mass Index (BMI) is: {bmi:F2}");
                        Console.WriteLine($"You are considered: {bmiCalculator.DetermineBMICategory()}");
                        break;
                    case 2:
                        Console.WriteLine("\n Book list management");

                        List<Book> bookList =
                        [
                            // Append books to list
                            new Book("Thinking, Fast and Slow", "Daniel Kahneman", "978-0374533557"),
                            new Book("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "978-0062316097"),
                            new Book("The Lean Startup: How Today's Entrepreneurs Use Continuous Innovation to Create Radically Successful Businesses", "Eric Ries", "978-0307887894"),
                        ];

                        // Displaying books
                        Console.WriteLine("Library:");
                        foreach (var book in bookList)
                        {
                            book.DisplayBookDetails();
                        }

                        // Remove a book from the list
                        Console.WriteLine("\nRemoving 'Thinking, Fast and Slow' book");
                        bookList.RemoveAll(book => book.Title == "Thinking, Fast and Slow");

                        // Showing after removal
                        Console.WriteLine("After removing book, library contains the following");
                        foreach (var book in bookList)
                        {
                            book.DisplayBookDetails();
                        }
                        // Compare two books
                        Console.WriteLine("\nComparing two books");
                        Book bookOne = new("Book Example One", "Academy .Net", "1234567890");
                        Book bookTwo = new("Book Example Two", "Academy Java", "0987654321");
                        if (bookOne.HasSameISBN(bookTwo))
                        {
                            Console.WriteLine("Book one and book two have the same ISBN");
                        }
                        else
                        {
                            Console.WriteLine("Book one and book two have different ISBN");
                        }

                        break;
                    case 3:
                        // ATM Machine
                        Console.WriteLine("\n ATM Machine");
                        ATM atm = new(4000.50m);
                        bool atmRunning = true;

                        while (atmRunning)
                        {
                            Console.WriteLine("\nMenu:");
                            Console.WriteLine("1. Check Balance");
                            Console.WriteLine("2. Deposit Money");
                            Console.WriteLine("3. Withdraw Money");
                            Console.WriteLine("4. Exit");

                            Console.WriteLine("Select an option: ");
                            int atmOperation = Convert.ToInt32(Console.ReadLine());

                            switch (atmOperation)
                            {
                                case 1:
                                    atm.CheckBalance();
                                    break;
                                case 2:
                                    Console.Write("Enter the amount to deposit: ");
                                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                                    atm.DepositMoney(depositAmount);
                                    break;
                                case 3:
                                    Console.Write("Enter the amount to withdraw: ");
                                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                                    atm.WithdrawMoney(withdrawAmount);
                                    break;
                                case 4:
                                    atmRunning = false;
                                    Console.WriteLine("It was nice to help you. Thank you!");
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        // Student Grades
                        Console.WriteLine("Welcome ot the Student Grades Manager!");
                        StudentGrades classroom = new();
                        classroom.InputGrades();
                        classroom.CalculateMinMaxAvg();
                        classroom.DisplayGrades();
                        break;
                    case 5:
                        // Difference between dates
                        Console.WriteLine("Welcome to the difference Date Calculator");
                        // Prompt the user to enter the first date
                        DateTime firstDate = DateCalculator.GetDateTime("Enter the first date (MM/DD/YYYY): ");

                        // Prompt the user to enter the first date
                        DateTime secondDate = DateCalculator.GetDateTime("Enter the second date (MM/DD/YYYY): ");

                        int daysDifference = DateCalculator.DifferenceInDates(firstDate, secondDate);
                        // Show result to user
                        Console.WriteLine($"\nThe number of days between {firstDate:MM/dd/yyyy} and {secondDate:MM/dd/yyyy} is {daysDifference} day(s).");
                        break;
                    case 6:
                        // Text Analyzer
                        Console.WriteLine("Welcome to the Text Analyzer");
                        // Prompt the user to input a block of text
                        Console.WriteLine("Enter a block of text (press Enter twice to finish):");

                        // Read the block of text 
                        string inputText = TextAnalyzer.ReadBlockOfText();
                        // Count the number of words, sentences and paragraphs
                        int wordCount = TextAnalyzer.CountWords(inputText);
                        int sentenceCount = TextAnalyzer.CountSentences(inputText);
                        int paragraphCount = TextAnalyzer.CountParagraphs(inputText);

                        // Display the counts to the user
                        Console.WriteLine($"\nWord Count: {wordCount}");
                        Console.WriteLine($"Sentence Count: {sentenceCount}");
                        Console.WriteLine($"Paragraph: {paragraphCount}");
                        break;
                    case 7:
                        // Sort names from input file
                        Console.WriteLine("Name Sorter");
                        // File path
                        string inputFilePath = "names.txt";
                        string outputFilePath = "sorted_names.txt";
                        NameSorter.Sorter(inputFilePath, outputFilePath);
                        break;
                    case 8:
                        executingProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again");
                        break;
                }
            }
        }
    }
}