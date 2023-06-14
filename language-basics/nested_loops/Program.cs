Console.Write("How many rows? ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("How many columns? ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("What symbol? ");
string s = Console.ReadLine();

for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write(s + " ");
    }
    Console.Write(Environment.NewLine);
}
