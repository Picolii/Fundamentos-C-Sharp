using System;
using System.Data;
using System.Text.RegularExpressions;


namespace BetterSimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
            while (true)
            {
                Console.Clear();

                CalculatorModel();

                Console.SetCursorPosition(2, 4);
                string input = Console.ReadLine();

                if (IsValidExpression(input))
                {
                    try
                    {
                        var result = EvaluateExpression(input);

                        Console.SetCursorPosition(2, 7);
                        Console.WriteLine(result);
                    }
                    catch (Exception ex)
                    {
                        Console.SetCursorPosition(2, 7);
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    Console.SetCursorPosition(2, 7);
                    Console.WriteLine("Invalid Expression");
                }

                Console.SetCursorPosition(0, 10);
                Console.WriteLine("Press any key to calculate another expression...");
                Console.ReadKey();
            }
        }

        static void CalculatorModel()
        {
            Console.WriteLine("╔═══════════════════════╗╔═══╦═══╦═══╦═══╗");
            Console.WriteLine("║        HP-12C         ║║ 7 ║ 8 ║ 9 ║ / ║");
            Console.WriteLine("╠═══════════════════════╣╠═══╬═══╬═══╬═══╣");
            Console.WriteLine("║ Input:                ║║ 4 ║ 5 ║ 6 ║ * ║");
            Console.WriteLine("║                       ║╠═══╬═══╬═══╬═══╣");
            Console.WriteLine("╠═══════════════════════╣║ 1 ║ 2 ║ 3 ║ - ║");
            Console.WriteLine("║ Result:               ║╠═══╬═══╬═══╬═══╣");
            Console.WriteLine("║                       ║║ 0 ║ . ║ = ║ + ║");
            Console.WriteLine("╚═══════════════════════╝╚═══╩═══╩═══╩═══╝");
        }

        static bool IsValidExpression(string expression)
        {
            string pattern = @"^[0-9+\-*/().\s]+$";
            return Regex.IsMatch(expression, pattern);
        }

        static double EvaluateExpression(string expression)
        {
            DataTable table = new DataTable();
            var result = table.Compute(expression, "");
            return Convert.ToDouble(result);
        }
    }
}