
using EmployeesV10;

public class ITSuppoter : Employee
{
    public string Subject { get; set; }


    public ITSuppoter(string name, int age, decimal salary, string subject)
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