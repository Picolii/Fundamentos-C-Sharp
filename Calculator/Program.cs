using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
            Console.Clear();

            Console.WriteLine("+------------------------------+");

            Console.WriteLine(" What do you want to do?");
            Console.WriteLine("");

            Console.WriteLine(" 1 - Sum");
            Console.WriteLine(" 2 - Subtraction");
            Console.WriteLine(" 3 - Division");
            Console.WriteLine(" 4 - Multiplication");
            Console.WriteLine("");
            Console.WriteLine(" 5 - Sair");

            Console.WriteLine("+------------------------------+");

            Console.WriteLine("Select an option: ");
            short option = short.Parse(Console.ReadLine());

            if (option == 5)
            {
                System.Environment.Exit(0);
            }

            Console.Clear();

            Console.WriteLine("+------------------------------+");
            Console.Write("First Value: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.Write("Second Value: ");
            float value2 = float.Parse(Console.ReadLine());
            float result = 0;

            switch (option)
            {

                case 1: result = value1 + value2; break;
                case 2: result = value1 - value2; break;
                case 3: result = value1 / value2; break;
                case 4: result = value1 * value2; break;
                default: Calculator(); break;
            }

            Console.WriteLine("");
            Console.WriteLine($"The operation result is: {result}");

            Console.ReadKey();
            Calculator();
        }
    }
}