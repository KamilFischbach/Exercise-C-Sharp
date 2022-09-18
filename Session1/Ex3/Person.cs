namespace Ex1;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName)
    {
        this.FirstName = firstName;
        LastName = "";
    }

    public void Introduce()
    {
        System.Console.WriteLine($"Hey my name is {FirstName}!");
    }
}