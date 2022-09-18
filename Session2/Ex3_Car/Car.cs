namespace Ex3_Car;

public class Car
{
    public string? Color;
    public double EngineSize;
    public double FuelEconomyPr100Km;
    public bool isManual;

    public Car(string? color, double engineSize, double fuelEconomyPr100Km, bool isManual)
    {
        Color = color;
        EngineSize = engineSize;
        FuelEconomyPr100Km = fuelEconomyPr100Km;
        this.isManual = isManual;
    }

    public string ToString()
    {
        return $"CAR: {Color} , {EngineSize}cm^3, Fuel economy: {FuelEconomyPr100Km}/100km, manual: {isManual} ";
    }
    
}