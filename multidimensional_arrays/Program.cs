string[,] parkingLot = {{"Supra", "Golf", "Lancer"}, 
                        {"Fusion", "Eclipse", "Corolla"}, 
                        {"Mustang", "Silverado", "GTO"}};

for (int i = 0; i < parkingLot.GetLength(0); i++)
{
    Console.Write($"{"", 30}");
    for (int j = 0; j < parkingLot.GetLength(1); j++)
    {
        Console.Write($"{parkingLot[i, j], -30}");
    }
    Console.WriteLine();
}