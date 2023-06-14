internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("What's the temperature outside? ");
        double temperature = Convert.ToDouble(Console.ReadLine());
        string diagnostic = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
        Console.WriteLine(diagnostic);
    }
}