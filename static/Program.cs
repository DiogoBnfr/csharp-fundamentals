using @static;

class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("Mustang");
        Car car2 = new Car("Corvette");
        Car car3 = new Car("Lambo");
        
        Console.WriteLine($"CARS IN THE RACE: {Car.numberOfCars}");
        
        Car.StartRace();
    }
}