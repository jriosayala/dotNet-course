namespace PracticeTwo;

internal static class MainControl
{
    public static void Main(string[] args)
    {
        bool ProgramIsRunning = true;
        string menu = "\n1. Classroom Manager\n2. Book Manager\n3. Vehicle \n6. Exit";
        do
        {
            Console.WriteLine("\nSelect an scenario to showcase:");
            Console.WriteLine(menu);
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var dotNet = new Classroom();

                    var huiqui = new Student("Joel Huiqui", 12, 20);
                    var carlos = new Student("Carlos Vela", 10, 18);

                    dotNet.AddStudent(huiqui);
                    dotNet.AddStudent(huiqui);
                    dotNet.RemoveStudent(carlos);
                    dotNet.PrintListStudents();
                    break;
                case 2:
                    var library = new Library();
                    var newBook1 = new Book("The Catcher in the Rye", "J.D. Salinger", "978-0-316-76948-0");
                    var newBook2 = new Book("Pride and Prejudice", "Jane Austen", "978-0-19-953556-9");

                    library.AddBook(newBook1);
                    library.AddBook(newBook1); // Attempt to add the same book again
                    library.RemoveBook(newBook2); // Attempt to remove a book not in the list
                    library.PrintBookList();
                    break;
                case 3:
                    Car car = new("Toyota", "Camry", 2020, 4, true);
                    Motorcycle motorcycle = new("Harley-Davidson", "Street 750", 2019, false);

                    // Create a list of Vehicle objects
                    List<Vehicle> vehicles = [car, motorcycle];
                    // Demonstrate polymorphism by calling StartEngine on each object
                    foreach (var vehicle in vehicles)
                    {
                        vehicle.DisplayDetails();
                        vehicle.StartEngine();
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    Console.WriteLine("\nNice to be useful :)");
                    ProgramIsRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again");
                    break;
            }
        }
        while (ProgramIsRunning);
    }
}