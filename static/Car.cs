namespace @static;

public class Car
{
    string model;
    public static int numberOfCars; // if not static, always will be == 1 

    public Car(string model)
    {
        this.model = model;
        numberOfCars++;
    }

    public static void StartRace()
    {
        Console.WriteLine("The race has begun!");
    }
}
