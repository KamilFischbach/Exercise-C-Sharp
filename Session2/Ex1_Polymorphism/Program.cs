// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Company VIA = new Company();

VIA.HireNewEmployee(new FullTimeEmployee("SVA", 4420000));
VIA.HireNewEmployee(new FullTimeEmployee("MONA", 45000));
VIA.HireNewEmployee(new FullTimeEmployee("RIB", 60000));
VIA.HireNewEmployee(new FullTimeEmployee("OKIKA", 50000));
VIA.HireNewEmployee(new PartTimeEmployee("OKIKA", 110, 42));
VIA.HireNewEmployee(new PartTimeEmployee("OKIKA", 140, 12));
VIA.HireNewEmployee(new PartTimeEmployee("OKIKA", 140, 12));
VIA.HireNewEmployee(new PartTimeEmployee("OKIKA", 140, 20));

Console.Write($"This is the money VIA has to pay for salaries: {VIA.GetMonthlyTotal()} DKK");
