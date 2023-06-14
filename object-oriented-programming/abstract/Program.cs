using @abstract;

internal class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();
        Vehicles vehicle = new Vehicle(); // this line will give an error
    }
}
