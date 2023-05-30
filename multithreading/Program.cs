internal class Program
{
    public static void Main(string[] args)
    {
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main Thread";

        Thread extraThread1 = new Thread(CountUp);
        Thread extraThread2 = new Thread(CountDown);
        extraThread1.Start();
        extraThread2.Start();
        
        // Console.WriteLine(mainThread.Name + " is complete!");
    }

    public static void CountDown()
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.Write("Timer #1 : " + i + " seconds ");
            Thread.Sleep(1000);
        }
        Console.Write("Timer #1 is complete! ");
    }
    public static void CountUp()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.Write("Timer #2 : " + i + " seconds");
            Console.WriteLine();
            Thread.Sleep(1001);
        }
        Console.Write("Timer #2 is complete!");
    }
}
