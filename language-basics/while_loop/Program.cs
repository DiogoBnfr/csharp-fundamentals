/* string name = "";

while (name == "")
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
} */

string name;
do
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
} while (name == "");

Console.WriteLine("Hello " + name);