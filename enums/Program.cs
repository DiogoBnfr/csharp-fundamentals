internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
        Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);
        Console.WriteLine(Planets.Saturn + " is planet #" + (int)Planets.Saturn);

        string name = PlanetRadius.Earth.ToString();
        int radius = (int)PlanetRadius.Earth;
        double volume = Volume(PlanetRadius.Earth);
        
        Console.WriteLine("Planet: " + name);
        Console.WriteLine("Radius: " + radius + "km");
        Console.WriteLine("Volume: " + volume + "km^3");
    }

    public static double Volume(PlanetRadius radius)
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        return volume;
    }

    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }

    internal enum PlanetRadius
    {
        Mercury = 12351,
        Venus = 86234,
        Earth = 8972,
        Mars = 98712,
        Jupiter = 09823,
        Saturn = 87634,
        Uranus = 912742,
        Neptune = 81782,
        Pluto = 12952
    }
}
