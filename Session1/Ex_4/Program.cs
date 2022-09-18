// See https://aka.ms/new-console-template for more information

void EvenUntil(int x)
{
    string result="";
    
        for (int i = 0; i <= x; i = i + 2)
        {
            result += $"{i}, ";
        }
        
    
    System.Console.WriteLine(result);
    
}

//EvenUntil(10);


void UnevenUntil(int x)
{
    string result="";
    
    for (int i = 1; i <= x; i = i + 2)
    {
        result += $"{i}, ";
    }
        
    
    System.Console.WriteLine(result);
    
}

//UnevenUntil(10);


void DivisibleByUntil(int divisible, int until)
{
    string result="";

    if (until >= divisible)
    {
        for (int i = divisible; i <= until; i = i + divisible)
        {
            result += $"{i}, ";
        }
    }
    else
    {
        result = "The divisible number has to be smaller than the number.";
    }

    System.Console.WriteLine(result);
}

DivisibleByUntil(12,9);