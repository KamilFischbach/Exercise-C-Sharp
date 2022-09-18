namespace Ex2_Birds;

public class DeafBirdWatcher
{
    public void ReactToBird(string response)
    {
        string saySth = "DEAF BIRD WATCHER: ";
        switch (response)
        {
            case "Bird's flapping wings.":
            {
                saySth += "Wow his wings are awesome.";
            }
                break;
            case "Bird's singing.":
            {
                saySth += "";
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