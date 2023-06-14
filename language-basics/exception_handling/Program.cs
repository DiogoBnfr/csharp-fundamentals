try
{
    double x, y, result;

    Console.Write("Enter number x: ");
    x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number y: ");
    y = Convert.ToInt32(Console.ReadLine());

    result = x / y;

    Console.WriteLine("Result: " + result);
}
catch (FormatException e)
{
    Console.WriteLine("Write only number please!");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("You can't divide by zero!");
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong!");
}
finally
{
    Console.WriteLine("Thanks for visiting!");
}