using NonPrimitiveTypes;
using PrimitiveTypesAndExpressions;

namespace Program
{
    class Practice1
    {
        private static void Main(string[] args)
        {
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
            // <-------------------------------------------------------->
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
        }
    }
}