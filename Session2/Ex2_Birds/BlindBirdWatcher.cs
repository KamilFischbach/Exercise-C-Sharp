namespace Ex2_Birds;

public class BlindBirdWatcher
{

    public void ReactToBird(string response)
    {
        var saySth = "BLIND BIRD WATCHER: ";
        switch (response)
        {
            case "Bird's flapping wings.":
            {
                saySth += "";
            }
                break;
            case "Bird's singing.":
            {
                saySth += "This sound is painting pictures in my head!";
            }
                break;
            case "Bird's mating.":
            {
                saySth += "";
            }
                break;
        }

        Console.WriteLine(saySth);
    }
}
