using System;
using System.Data;
using System.Text.RegularExpressions;


namespace BetterSimpleCalculator
{
    class BetterCalculator
    {
        static void Main(string[] args)
        {
            Calculadora();
        }

        static void Calculadora()
        {
            while (true)
            {
                Console.Clear();

                DesenhoCalculadora();

                Console.SetCursorPosition(2, 4);
                string entrada = Console.ReadLine();

                if (EhExpressaoValida(entrada))
                {
                    try
                    {
                        var resultado = AvaliaExpressao(entrada);

                        Console.SetCursorPosition(2, 7);
                        Console.WriteLine(resultado);
                    }
                    catch (Exception ex)
                    {
                        Console.SetCursorPosition(2, 7);
                        Console.WriteLine("Erro");
                    }
                }
                else
                {
                    Console.SetCursorPosition(2, 7);
                    Console.WriteLine("Expressão inválida");
                }

                Console.SetCursorPosition(0, 10);
                Console.WriteLine("Pressione qualquer tecla para calcular outra expressão...");
                Console.ReadKey();
            }
        }

        static void DesenhoCalculadora()
        {
            Console.WriteLine("╔═══════════════════════╗╔═══╦═══╦═══╦═══╗");
            Console.WriteLine("║        HP-12C         ║║ 7 ║ 8 ║ 9 ║ / ║");
            Console.WriteLine("╠═══════════════════════╣╠═══╬═══╬═══╬═══╣");
            Console.WriteLine("║ Entrada:              ║║ 4 ║ 5 ║ 6 ║ * ║");
            Console.WriteLine("║                       ║╠═══╬═══╬═══╬═══╣");
            Console.WriteLine("╠═══════════════════════╣║ 1 ║ 2 ║ 3 ║ - ║");
            Console.WriteLine("║ Resultado:            ║╠═══╬═══╬═══╬═══╣");
            Console.WriteLine("║                       ║║ 0 ║ . ║ = ║ + ║");
            Console.WriteLine("╚═══════════════════════╝╚═══╩═══╩═══╩═══╝");
        }

        static bool EhExpressaoValida(string expressao)
        {
            string padrao = @"^[0-9+\-*/().\s]+$";
            return Regex.IsMatch(expressao, padrao);
        }

        static double AvaliaExpressao(string expressao)
        {
            DataTable table = new DataTable();
            var resultado = table.Compute(expressao, "");
            return Convert.ToDouble(resultado);
        }
    }
}