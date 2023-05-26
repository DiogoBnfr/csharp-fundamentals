internal class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("Porsche");
        Console.WriteLine(car.Model);
    }

    class Car
    {
        public string Model { get; set; }

        public Car(string model)
        {
            this.Model = model;
        }
    }
}
