using overloaded_constructors;

internal class Program
{
    public static void Main(string[] args)
    {
        Pizza pizza = new Pizza("stuffed crust", "red sauce", "prato"); // can have 1, 2, 3 or 4 args because of the multiple constructors
    }
}
