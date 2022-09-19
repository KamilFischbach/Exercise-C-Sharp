using System.Text.Json;

namespace Ex1_JsonString;

public class PersonPersistence
{
    public static void StoreObjects(List<Person> people)
    {
        string json = JsonSerializer.Serialize(people, new JsonSerializerOptions() { WriteIndented = true });
        string filename = "People.json";
        File.WriteAllText(filename, json);
        Console.WriteLine(File.ReadAllText(filename));
        
    }


    public static List<Person> readObjects()
    {
        string filename = "People.json";
        string json = File.ReadAllText(filename);
        List<Person> list = JsonSerializer.Deserialize<List<Person>>(json);
        return list;
    }
}