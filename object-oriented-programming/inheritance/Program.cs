using inheritance;

internal class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();
        
        Console.WriteLine(car.speed);
        Console.WriteLine(car.wheels);
        car.go();
        
        Console.WriteLine(bicycle.speed);
        Console.WriteLine(bicycle.wheels);
        bicycle.go();
        
        Console.WriteLine(boat.speed);
        Console.WriteLine(boat.wheels);
        boat.go();
    }
}
