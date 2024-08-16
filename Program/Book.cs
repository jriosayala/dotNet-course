namespace NonPrimitiveTypes
{
    public class Book(string title, string author, string isbn)
    {
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