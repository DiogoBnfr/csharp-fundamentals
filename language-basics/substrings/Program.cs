internal class Program
{
    public static void Main(string[] args)
    {
        string text = "hello world";
        
        int index = text.LastIndexOf(' ');
        
        string slice = text.Substring(index + 1, text.Length - index - 1);
        
        Console.WriteLine(slice);
    }
}