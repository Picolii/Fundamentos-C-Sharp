namespace HtmlEditor
{
    public static class ScreenDrawer
    {
        public static void DrawScreen(int width, int height)
        {
            DrawTopBorder(width);
            DrawMiddleRows(width, height);
            DrawBottomBorder(width);
        }

        private static void DrawTopBorder(int width)
        {
            Console.Write("╔");
            for (int i = 0; i < width; i++)
                Console.Write("═");
            Console.Write("╗");
            Console.Write("\n");
        }

        private static void DrawMiddleRows(int width, int height)
        {
            for (int lines = 0; lines < height; lines++)
            {
                Console.Write("║");
                for (int i = 0; i < width; i++)
                    Console.Write(" ");
                Console.Write("║");
                Console.Write("\n");
            }
        }

        private static void DrawBottomBorder(int width)
        {
            Console.Write("╚");
            for (int i = 0; i < width; i++)
                Console.Write("═");
            Console.Write("╝");
            Console.Write("\n");
        }
    }
}