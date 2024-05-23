
namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            // StartChronometer(6);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------+");
            Console.WriteLine("Input format:");
            Console.WriteLine("S = Seconds => 10s = 10 seconds");
            Console.WriteLine("M = Minutes => 1m = 10 minutes");

            Console.WriteLine("");

            Console.WriteLine("0 = Exit");
            Console.WriteLine("+-----------------------------------+");
            Console.WriteLine("How long do you want to count?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm') multiplier = 60;
            if (time == 0) System.Environment.Exit(0);

            StartChronometer(time * multiplier);
        }

        static void StartChronometer(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine();
            Thread.Sleep(1500);
        }
    }

}