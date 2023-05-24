using objects;

class Program
{
    public static void Main(string[] args)
    {
        Human human = new Human();
        
        Console.Write("Choose a name: ");
        human.name = Console.ReadLine();
        Console.Write("Choose an age: ");
        human.age = Convert.ToInt32(Console.ReadLine());
        
        human.Stats();
        human.Eat();
        human.Sleep();
    }
}
