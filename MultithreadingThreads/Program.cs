namespace MultithreadingThreads
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Glowny watek";

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
            
            Console.WriteLine(mainThread.Name);
        }

        public static void CountDown()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Count down {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Count down ended");
        }
        public static void CountUp()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Count up {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Count up ended");
        }
    }

   
}
