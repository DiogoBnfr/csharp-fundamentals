internal class Program
{
    public static void Main(string[] args)
    {
        double total = Multiply(2, 3, 5);
        Console.WriteLine("a . b . c = " + total);
        
    }
    
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static double Multiply(double a, double b, double c) // method signature == name + parameters
    {
        return a * b * c;
    }
}
