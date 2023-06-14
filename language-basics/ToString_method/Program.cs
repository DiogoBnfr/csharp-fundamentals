internal class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("Ford", "Mustang", 2001, "red");
        Console.WriteLine(car);
    }

    class Car
    {
        private string make;
        private string model;
        private int year;
        private string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public override string ToString()
        {
            return "This is a " + make + " " + model;
        }
    }
}
