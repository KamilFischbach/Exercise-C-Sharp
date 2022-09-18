namespace Ex4_WaitingRoom;

public class WaitingRoom
{
    //public Func<int, string[]> NumberChange;
    //This would be used for the function solution ^.
    public Action<int> NumberChange;
    private int _currentNumber;
    private int _ticketCount;

    public WaitingRoom()
    {
        _currentNumber = 0;
        _ticketCount = 0;
    }

    public void RunWaitingRoom()
    {
        while (_currentNumber < _ticketCount)
        {
            Console.WriteLine($"Patient with number {_currentNumber} can now enter.");
            NumberChange.Invoke(_currentNumber++);
            Thread.Sleep(1500);
            /*
            string[] reaction = NumberChange.Invoke(currentNumber);
            Console.WriteLine(reaction[0]);
            Console.WriteLine(reaction[1]);
            
             The last returned valued is stored in the "reaction" variable, but all the methods are invoked.
             Therefore, those are the print outs:
             
                Patient with number 0 can now enter.
                Patient 4 looks up
                Patient 4 gets back to scrolling vikop.ru
                Patient with number 1 can now enter.
                Patient 4 looks up
                Patient 4 gets back to scrolling vikop.ru
                Patient with number 2 can now enter.
                Patient 4 looks up
                Patient 4 gets back to scrolling vikop.ru

             */
        }
    }

    public int DrawNumber()
    {
        return _ticketCount++;
    }
}