class Program
{
    static void Main(string[] args)
    {
        double x, y;
        
        Console.Write("Enter number 1: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number 2: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("x . y = " + Multiply(x, y));
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }
}