using System.Text.RegularExpressions;

namespace HtmlEditor
{
    public class Viewer()
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("VIEWER MODE");
            Console.WriteLine("══════════════════════════════");
            Replace(text);

            Console.ReadKey();
            Menu.Show();


        }

        public static void Replace(string text)
        {
            var strongRegex = new Regex(@"<\s*strong\s*>(.*?)<\s*/\s*strong\s*>", RegexOptions.IgnoreCase);

            var matches = strongRegex.Matches(text);
            int currentIndex = 0;

            foreach (Match match in matches)
            {
                // Print text before the match
                if (match.Index > currentIndex)
                {
                    Console.Write(text.Substring(currentIndex, match.Index - currentIndex));
                }

                // Print the matched text in blue
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(match.Groups[1].Value);

                currentIndex = match.Index + match.Length;
            }

            // Print any remaining text after the last match
            if (currentIndex < text.Length)
            {
                Console.Write(text.Substring(currentIndex));
            }

        }
    }
}
