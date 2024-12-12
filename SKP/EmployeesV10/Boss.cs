using EmployeesV10;


    public class Boss : Employee
{
    public string Subject { get; set; }



    public Boss(string name, int age, decimal salary, string subject)
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