class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Price: " + CheckOut(15.99, 2.27, 122.98, 13.80));
    }

    public static double CheckOut(params double[] prices)
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }
}