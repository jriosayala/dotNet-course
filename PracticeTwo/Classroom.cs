namespace PracticeTwo;
internal record Student(string Name, int RollNumber, int Grade);

internal class Classroom
{
    private readonly List<Student> students =
        [
        new Student("Cristiano Ronaldo", 07, 10),
        new Student("Santiago Gimenez", 09, 06),
        new Student("Jude Bellingham", 05, 13),
        ];

    public void AddStudent(Student student)
    {
        if (!students.Contains(student))
        {
            students.Add(student);
            Console.WriteLine($"{student.Name} was added successfully to the classroom");
        }
        else
        {
            Console.WriteLine("Student already added to the classroom");
        }
    }
    public void RemoveStudent(Student student)
    {
        // Validate that student is contained within the list of students
        string result = students.Remove(student) ?
        $"{student.Name} was removed successfully from the classroom" :
        "Student not listed in classroom";
        Console.WriteLine(result);
    }
    public void PrintListStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student.Name}, Roll Number: {student.RollNumber}, Grade: {student.Grade}");
        }

    }
}