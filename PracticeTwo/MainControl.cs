namespace PracticeTwo;

internal class MainControl
{
    public static void Main(string[] args)
    {

        var dotNet = new Classroom();

        var huiqui = new Student("Joel Huiqui", 12, 20);
        var carlos = new Student("Carlos Vela", 10, 18);

        dotNet.AddStudent(huiqui);
        dotNet.AddStudent(huiqui);
        dotNet.RemoveStudent(carlos);
        dotNet.PrintListStudents();
    }
}