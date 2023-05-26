internal class Program
{
    public static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3 };
        double[] doubleArray = { 1.0, 2.0, 3.0 };
        string[] stringArray = { "1", "2", "3" };
        
        DisplayElement(intArray);
        DisplayElement(doubleArray);
        DisplayElement(stringArray);
    }

    public static void DisplayElement<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
