Console.Write("What's your name? ");
string name = Console.ReadLine();

Console.Write("What's your age? ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("What's your sex (M/F)? ");
char sex = Convert.ToChar(Console.ReadLine());

Console.Write("What's your height (use \",\")? ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("What's your weight (use \",\")? ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Name: " + name + Environment.NewLine +
                  "Age: " + age + Environment.NewLine +
                  "Sex: " + sex + Environment.NewLine +
                  "Height: " + height + Environment.NewLine +
                  "Weight: " + weight + Environment.NewLine);