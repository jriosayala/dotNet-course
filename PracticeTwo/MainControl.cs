namespace PracticeTwo;

internal static class MainControl
{
    public static void Main(string[] args)
    {
        bool ProgramIsRunning = true;
        do
        {
            Console.WriteLine("\nSelect an option:");
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
                    break;
                case 3:
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