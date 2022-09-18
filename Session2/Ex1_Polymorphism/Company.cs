namespace ConsoleApp1;

public class Company
{
    private readonly List<Employee>? _employees;// readonly lol?

    public Company()
    {
        _employees = new List<Employee>();
    }

    public double GetMonthlyTotal()
    {
        double total = 0;
        _employees?.ForEach(e => total+=e.GetMonthlySalary());
        return total;
    }

    public void HireNewEmployee(Employee emp)
    {
        _employees?.Add(emp);
    }
}