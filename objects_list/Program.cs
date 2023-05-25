﻿internal class Program
{
    public static void Main(string[] args)
    {
        List<Player> players = new List<Player>();
        
        players.Add(new Player("Chad"));
        players.Add(new Player("Steve"));
        players.Add(new Player("Karen"));

        foreach (Player player in players)
        {
            Console.WriteLine(player);
        }
    }

    class Player
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }
        
        public override string ToString()
        {
            return username;
        }
    }
}
