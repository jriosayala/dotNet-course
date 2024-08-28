namespace PracticeTwo;
using System;
using System.Collections.Generic;

internal class Book(string title, string author, string isbn)
{
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
    public string ISBN { get; set; } = isbn;
}

internal class Library
{
    private readonly List<Book> books =
        [
            new Book("To Kill a Mockingbird", "Harper Lee", "978-0-06-112008-4"),
            new Book("1984", "George Orwell", "978-0-452-28423-4"),
            new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-0-7432-7356-5"),
        ];

    public void AddBook(Book book)
    {
        if (!books.Contains(book))
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} by {book.Author} was added successfully to the library.");
        }
        else
        {
            Console.WriteLine("Book already added to the library.");
        }
    }

    public void RemoveBook(Book book)
    {
        // Validate that book is contained within the list of books
        string result = books.Remove(book) ?
            $"{book.Title} by {book.Author} was removed successfully from the library." :
            "Book not listed in library.";
        Console.WriteLine(result);
    }

    public void PrintBookList()
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
        }
    }
}
