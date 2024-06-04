namespace GuidGenerator
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Press 'R' to generate a NEW GUID! \nPress 'C' to console clear! \n");

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.R)
                {
                    Guid newGuid = Guid.NewGuid();
                    Console.WriteLine(newGuid.ToString().ToUpper());
                }
                else if (keyInfo.Key == ConsoleKey.C)
                {
                    Console.WriteLine("\nCleaning, please wait!");
                    Thread.Sleep(700);
                    Console.WriteLine("Done!");
                    Thread.Sleep(500);
                    Main();
                }

            } while (keyInfo.Key != ConsoleKey.Escape);

            Console.WriteLine("Trying to finish! Press key again!");
        }
    }
}