internal class Program
{
    public static void Main(string[] args)
    {
        List<string> foods = new List<string>();
        
        foods.Add("Fries");
        foods.Add("Pizza");
        foods.Add("Hamburguer");
        foods.Add("Hotdog");
        foods.Add("Fries");
        
        Console.WriteLine(":::::::::: MENU ::::::::::");
        foreach (string food in foods)
        {
            Console.WriteLine(foods.IndexOf(food) + " " + food);
        }
        Console.WriteLine();

        foods.Remove("Fries");
        foods.Insert(0, "Sushi");
        foods.Sort(); // A -> Z order
        // foods.Reverse(); Z -> A order
        string[] foodArray = foods.ToArray();

        Console.WriteLine("::::::: FINAL MENU :::::::");
        foreach (string food in foods)
        {
            Console.WriteLine(foods.IndexOf(food) + " " + food);
        }
        Console.WriteLine();
        
        Console.WriteLine("Menu Items: " +  foods.Count);
        Console.WriteLine("Index of Pizza: " + foods.IndexOf("Pizza"));
        Console.WriteLine("Menu Constains Pizza? " + foods.Contains("Sushi"));
        
        foods.Clear(); // erase list
    }
}
