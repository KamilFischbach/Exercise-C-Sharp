// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Ex1_JsonString;

Person p1 = new Person()
{
    f_name = "Kamil",
    l_name = "Fischbach",
    age = 20,
    height = 1.81,
    isMarried = false,
    sex = 'M',
    hobbies = new string[] { "fishing", "football", " cooking" }
};
Person p2 = new Person()
{
    f_name = "Karol",
    l_name = "Fischbach",
    age = 20,
    height = 1.81,
    isMarried = false,
    sex = 'M',
    hobbies = new string[] { "fishing", "football", " cooking" }
};
Person p3 = new Person()
{
    f_name = "Tomasz",
    l_name = "Fischbach",
    age = 20,
    height = 1.81,
    isMarried = false,
    sex = 'M',
    hobbies = new string[] { "fishing", "football", " cooking" }
};

List<Person> list = new List<Person>();
list.Add(p1);
list.Add(p2);
list.Add(p3);
string jsonFormatted = JsonSerializer.Serialize(list, new JsonSerializerOptions() { WriteIndented = true });

Console.WriteLine(jsonFormatted);

