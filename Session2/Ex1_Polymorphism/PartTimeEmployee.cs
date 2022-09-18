namespace ConsoleApp1;

public class PartTimeEmployee:Employee//This is how you implement or extend a class.
{
    public double HourlyWage;
    public int HoursPerMonth;
    
    public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)//
    {
        this.HourlyWage = hourlyWage;
        this.HoursPerMonth = hoursPerMonth;
    }
    public override double GetMonthlySalary()
    {
        return HourlyWage * HoursPerMonth;
    }
    
    
}