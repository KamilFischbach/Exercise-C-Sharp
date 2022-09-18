// See https://aka.ms/new-console-template for more information

using Ex3_Car;

List<Car> cars = new List<Car>();

cars.Add(new Car("black", 1600, 5.6, true));
cars.Add(new Car("yellow", 2000, 4.5, true));
cars.Add(new Car("black", 1600, 5.6, true));
cars.Add(new Car("green", 4500, 2.5, true));


void allBlackCars()
{
    cars.FindAll(car => car.Color.Equals("black"))
        .ForEach(car => Console.WriteLine(car.ToString()));
    /*
    string toStringBlackCars = "";
    List<Car> blackCars = cars.FindAll(car => car.Color.Equals("black"));
    //Find all with the right comparision is finding what you ask for!!!
    blackCars.ForEach(car => toStringBlackCars += car.ToString());
    
    return toStringBlackCars;
    */
}

allBlackCars();