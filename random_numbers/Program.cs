Random random = new Random();

int intRand = random.Next(1, 21); // left inclusive, right not inclusive
double doubleRand = random.NextDouble();

Console.WriteLine("Random Integer: " + intRand + Environment.NewLine +
                  "Random Double: " + doubleRand + Environment.NewLine);