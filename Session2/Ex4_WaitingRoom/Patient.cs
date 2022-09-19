namespace Ex4_WaitingRoom;

public class Patient
{
    private WaitingRoom _wr;
    private int _numberInQueue;

    public Patient(WaitingRoom wr)
    {
        _wr = wr;
        _wr.NumberChange += ReactToNumberAction;
        _numberInQueue = _wr.DrawNumber();
        Console.WriteLine(_numberInQueue);
    }

    public string[] ReactToNumberFunction(int num)
    {
        string[] reaction = { "", "" };
        reaction[0] = $"Patient {_numberInQueue} looks up";
        if (num == _numberInQueue)
        {
            reaction[1] = $"Patient {_numberInQueue} enters the doctor's room.";
            //How do I stop listening if I have already entered???
            //Wr.NumberChange -= ReactToNumberFunction;
            //Noice
        }
        else
        {
            reaction[1] = $"Patient {_numberInQueue} gets back to scrolling vikop.ru";
        }

        return reaction;
    }
    
    public void ReactToNumberAction(int num)
    {
        
        Console.WriteLine($"Patient {_numberInQueue} looks up");
        if (num == _numberInQueue)
        {
            Console.WriteLine($"Patient {_numberInQueue} enters the doctor's room.");
            //How do I stop listening if I have already entered???
            _wr.NumberChange -= ReactToNumberAction;
            //Noice
        }
        else
        {
            Console.WriteLine($"Patient {_numberInQueue} gets back to scrolling vikop.ru");
        }
    }
}