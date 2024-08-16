using System;
using System.Runtime.Intrinsics.X86;

namespace Program
{
    internal class BmiCalculator
    {
        static void Main(string[] args)
        {
            double weight;
            double height;

            Console.WriteLine("Welcome to the BMI Calculator");
            // Getting input from user
            Console.Write("Enter your weight in kilograms: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);
            string category = DetermineBMICategory(bmi);
            Console.WriteLine($"You are considered: {category}");

        }


        private static string DetermineBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }
    }
    class Book(string title, string author, string isbn)
    {
        static void Main(String[] args)
        {
            Console.WriteLine("\n Book list management");

            List<Book> bookList = new List<Book>();

            // Append books to list
            bookList.Add(new Book("Thinking, Fast and Slow", "Daniel Kahneman", "978-0374533557"));
            bookList.Add(new Book("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "978-0062316097"));
            bookList.Add(new Book("The Lean Startup: How Today's Entrepreneurs Use Continuous Innovation to Create Radically Successful Businesses", "Eric Ries", "978-0307887894"));

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
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public string ISBN { get; set; } = isbn;

        public void DisplayBookDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
        public bool HasSameISBN(Book bookToCompare)
        {
            return ISBN == bookToCompare.ISBN;
        }
    }
}