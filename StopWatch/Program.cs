using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }

        static void StartChronometer()
        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                currentTime++;
            }
        }
    }

}