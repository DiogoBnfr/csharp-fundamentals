namespace inheritance;

public class Vehicle
{
    public int speed = 0;

    public void go()
    {
        Console.WriteLine("This vehicle is moving!");
    }
}

class Car : Vehicle
{
    public int wheels = 4;
}
class Bicycle : Vehicle
{
    public int wheels = 2;
}
class Boat : Vehicle
{
    public int wheels = 0;
}