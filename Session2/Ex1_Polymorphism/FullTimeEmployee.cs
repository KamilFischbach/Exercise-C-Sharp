namespace ConsoleApp1;

public class FullTimeEmployee: Employee
{
    public double MonthlySalary;

    public FullTimeEmployee(string name, double monthlySalary) : base(name)
    {
        this.MonthlySalary = monthlySalary;
    }
    public override double GetMonthlySalary()
    {
        return MonthlySalary;
    }
}