namespace @abstract;

public abstract class Vehicles // abstract = incomplete class or missing components
{
    public int speed = 0;

    public void go()
    {
        Console.WriteLine("This vehicle is moving!");
    }
}

class Car : Vehicles
{
    public int wheels = 4;
    int maxSpeed = 300;
}
class Bicycle : Vehicles
{
    public int wheels = 2;
    int maxSpeed = 50;
}
class Boat : Vehicles
{
    public int wheels = 0;
    int maxSpeed = 100;
}