using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora();
        }

        static void Calculadora()
        {
            Console.Clear();

            Console.WriteLine("+------------------------------+");

            Console.WriteLine(" O que deseja fazer?");
            Console.WriteLine("");

            Console.WriteLine(" 1 - Soma");
            Console.WriteLine(" 2 - Subtração");
            Console.WriteLine(" 3 - Divisão");
            Console.WriteLine(" 4 - Multiplicação");
            Console.WriteLine("");
            Console.WriteLine(" 5 - Sair");

            Console.WriteLine("+------------------------------+");

            Console.WriteLine("Selecione uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            if (opcao == 5)
            {
                System.Environment.Exit(0);
            }

            Console.Clear();

            Console.WriteLine("+------------------------------+");
            Console.Write("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float resultado = 0;

            switch (opcao)
            {

                case 1: resultado = valor1 + valor2; break;
                case 2: resultado = valor1 - valor2; break;
                case 3: resultado = valor1 / valor2; break;
                case 4: resultado = valor1 * valor2; break;
                default: Calculadora(); break;
            }

            Console.WriteLine("");
            Console.WriteLine($"O resultado da operação é: {resultado}");

            Console.ReadKey();
            Calculadora();
        }
    }
}