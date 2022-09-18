namespace Ex4_WaitingRoom;

public class Patient
{
    public WaitingRoom Wr;
    private int numberInQueue;

    public Patient(WaitingRoom wr)
    {
        Wr = wr;
        Wr.NumberChange += ReactToNumber;
        numberInQueue = Wr.DrawNumber();
    }

    public string[] ReactToNumber(int num)
    {
        string[] reaction = { "", "" };
        reaction[0] = $"Patient {numberInQueue} looks up";
        if (num == numberInQueue)
        {
            reaction[1] = $"Patient {numberInQueue} enters the doctor's room.";
            //How do I stop listening if I have already entered???
            Wr.NumberChange -= ReactToNumber;
            //Noice
        }
        else
        {
            reaction[1] = $"Patient {numberInQueue} gets back to scrolling vikop.ru";
        }

        return reaction;
    }
}