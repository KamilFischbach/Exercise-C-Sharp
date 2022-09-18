namespace Ex2_Birds;

public class Bird
{
    public Action<string> BirdDelegate;
    
    public void BirdAction()
    {
        for (int i = 0; i < 25; i++)
        {
            int number = i % 3;
            string response = "";
            switch (number)
            {
                case 0:
                    response = "Bird's flapping wings.";
                    break;
                case 1:
                    response = "Bird's singing.";
                    break;
                case 2:
                    response = "Bird's mating.";
                    break;
            }
            Console.WriteLine(response);
            BirdDelegate?.Invoke(response);
            Thread.Sleep(1000);
        }
    }
}