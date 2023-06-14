double x = 3.14;
double y = 5;

double a = Math.Pow(x, 3);
double b = Math.Sqrt(x);
double c = Math.Abs(x);
double d = Math.Round(x); 
double e = Math.Ceiling(x); // always round up
double f = Math.Floor(x); // always round down
double g = Math.Max(x, y);
double h = Math.Min(x, y);

Console.WriteLine("x = " + x + Environment.NewLine +
                  "y = " + y + Environment.NewLine +
                  "x ^ 3 = " + a + Environment.NewLine +
                  "√x = " + b + Environment.NewLine +
                  "|x| = " + c + Environment.NewLine +
                  "x ≈ " + d + Environment.NewLine +
                  "|_x_| = " + e + Environment.NewLine +
                  "|-x-| = " + f + Environment.NewLine +
                  "max{x, y} = " + g + Environment.NewLine +
                  "min{x, y} = " + h + Environment.NewLine); 
                  