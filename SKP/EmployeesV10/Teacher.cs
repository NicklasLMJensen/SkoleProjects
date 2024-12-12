
using EmployeesV10;

public class Teacher : Employee
{
    public string Subject { get; set; } 

    
    public Teacher(string name, int age, decimal salary, string subject)
        : base(name, age, salary) 
    {
        Subject = subject; 
    }


    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Subject: {Subject}");
    }
}
