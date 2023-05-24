using constructors;

internal class Program
{
    public static void Main(string[] args)
    {
        string maker, model, color;
        int year;

        Console.Write("Maker: ");
        maker = Console.ReadLine();
            
        Console.Write("Model: ");
        model = Console.ReadLine();
            
        Console.Write("Year: ");
        year = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Color: ");
        color = Console.ReadLine();

        Car car = new Car(make: maker, model, year, color);

        Console.WriteLine("\n" + $"{"Car Information", 30}" + "\n");
        
        Console.WriteLine($"{"Maker: " + car.make, -30}" + "\n" +
                          $"{"Model: " + car.model, -30}" + "\n" +
                          $"{"Year: " + car.year, -30}" + "\n" +
                          $"{"Color: " + car.color, -30}" + "\n");
        
        Car.TurnOn();
        Thread.Sleep(1000);
        
        for (int i = 0; i < 3; i++)
        {
            Car.Accelerate();
            Thread.Sleep(1000);
        }
        
        Car.TurnOff();
        Thread.Sleep(1000);
    }
}
