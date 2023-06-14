string[] cars = {"nissan 180sx", "toyota supra mkiv", "ferrari sf90"};
// array with fixed size -> string[] cars = new string[3]

cars[0] = "mitsubishi lancer evolution ii"; // changing the value

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}