namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            happyBirthday(name, age);
        }
        static void happyBirthday(string name, int age)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("Happy birthday dear " + name);
                    Console.WriteLine("You are " + age + " years old!");
                }
                else
                {
                    Console.WriteLine("Happy birthday to you");
                }
            }
        }
    }
}

