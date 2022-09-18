using System.Diagnostics;

namespace Ex2_Birds;

public class BirdWatcher
{
    public void ReactToBird(string response)
    {
        string saySth = "BIRD WATCHER: ";
        switch (response)
        {
            case "Bird's flapping wings.":
            {
                saySth += "Wow his wings are awesome.";
            }
                break;
            case "Bird's singing.":
            {
                saySth += "This sound is a blessing!!!";
            }
                break;
            case "Bird's mating.":
            {
                saySth += "COME ON JERRY!";
            }
                break;
        }

        Console.WriteLine(saySth);
    }
}
