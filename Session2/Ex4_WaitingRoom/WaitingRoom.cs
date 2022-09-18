namespace Ex4_WaitingRoom;

public class WaitingRoom
{
    public Func<int,string[]> NumberChange;
    private int currentNumber;
    private int ticketCount;

    public WaitingRoom()
    {
        currentNumber = 0;
        ticketCount = 0;
        Console.WriteLine("Just making some changes.");
    }

    public void RunWaitingRoom()
    {
        while (currentNumber < ticketCount)
        {
            Console.WriteLine($"Patient with number {currentNumber} can now enter.");
            string[] reaction = NumberChange.Invoke(currentNumber);
            Console.WriteLine(reaction[0]);
            Console.WriteLine(reaction[1]);
            currentNumber++;
            Thread.Sleep(1500);
        }   
    }

    public int DrawNumber()
    {
        return ticketCount++;
    }
}