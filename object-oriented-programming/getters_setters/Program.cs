 internal class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car(400);
        car.Speed = 100000;
        Console.WriteLine(car.Speed);
    }

    class Car
    {
        public int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get => speed; // read
            set => speed = value > 500 ? 500 : value; // write
        }
    }
}
