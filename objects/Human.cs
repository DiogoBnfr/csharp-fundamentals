namespace objects;

public class Human
{
    public string name; // that is not recommended
    public int age;

    public void Stats()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age + " years");
    }
    public void Eat()
    {
        Console.WriteLine(name + " is eating!");
    }

    public void Sleep()
    {
        Console.WriteLine(name + " is sleeping...");
    }
}
