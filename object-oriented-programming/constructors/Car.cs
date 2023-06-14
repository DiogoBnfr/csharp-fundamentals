namespace constructors;

public class Car
{
    public string make;
    public string model;
    public int year;
    public string color;

    public Car(string make, string model, int year, string color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public static bool TurnOn()
    {
        Console.WriteLine("The car is on!");
        return true;
    }
    public static bool TurnOff()
    {
        Console.WriteLine("The car is off!");
        return false;
    }
    public static void Accelerate()
    {
        Console.WriteLine("VROOOM, VROOOM!");
    }
}
