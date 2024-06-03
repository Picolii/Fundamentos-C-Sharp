using System.Text;

namespace HtmlEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("EDITOR MODE");
            Console.WriteLine("══════════════════════════════");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.SetCursorPosition(1, 8);
            Console.WriteLine("═════════════════════════════");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("Do you want to save the file?");
            Viewer.Show(file.ToString());
        }

    }
}