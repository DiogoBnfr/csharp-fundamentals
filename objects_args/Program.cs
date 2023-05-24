internal class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("Mustang", "Red");
        Car car2 = Copy(car1);
        
        Console.WriteLine("Your " + car2.Model + " is " + car2.Color + "!");
    }

    public static Car Copy(Car car)
    {
        return new Car(car.Model, car.Color);
    }
}

class Car
{
    public string Model;
    public string Color;
    public static int TotalCars;
    public Car(string model, string color)
    {
        this.Model = model;
        this.Color = color;
        TotalCars++;
    }
}
