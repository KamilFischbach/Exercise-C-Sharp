namespace MathLab;

public class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Add(int[] numbers)
    {
        int sum = 0;
        foreach (var i in numbers)
        {
            sum = sum + i;
        }

        return sum;
    }

    public static void Maximum(int x, int y)
    {
        string result = "This number is bigger ";
        if (x > y)
        {
            result += x;
        }
        else if (y>x)
        {
            result += y;
        }
        else
        {
            result = "The numbers are equal.";
        }
        
        Console.WriteLine(result);
    }
}