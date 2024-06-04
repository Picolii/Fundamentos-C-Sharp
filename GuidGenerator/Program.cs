using System.ComponentModel.DataAnnotations;

namespace GuidGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Press 'R' to generate a NEW GUID!");
            while (Console.ReadKey(true).Key == ConsoleKey.R)
            {
                Guid newGuid = Guid.NewGuid();
                Console.WriteLine(newGuid.ToString().ToUpper().Replace('r', ' '));

            }
        }
    }
}