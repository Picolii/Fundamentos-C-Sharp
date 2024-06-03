using Microsoft.VisualBasic;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            ScreenDrawer.DrawScreen(30, 10);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("HTML EDITOR");

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("╠══════════════════════════════╣");

            Console.SetCursorPosition(5, 4);
            Console.WriteLine("Select an option below");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - New file");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Open");

            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Exit");

            Console.SetCursorPosition(3, 10);
            Console.Write("Option: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}