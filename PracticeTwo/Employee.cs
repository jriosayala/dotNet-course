namespace PracticeTwo;

public class Employee(string name, int employeeID, decimal salary)
{
    public string Name { get; set; } = name;
    public int EmployeeID { get; set; } = employeeID;
    public decimal Salary { get; set; } = salary;

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, EmployeeID: {EmployeeID}, Salary: {Salary:C}");
    }
}
