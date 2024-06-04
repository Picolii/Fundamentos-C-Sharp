namespace WorkingWithNumbers
{
    public class Menu()
    {
        public static void Option()
        {
            Console.Clear();

            Console.WriteLine(" What do you want to do? \n");
            Console.WriteLine(" 1 - Coin types");
            Console.WriteLine(" 2 - Coin format");
            Console.WriteLine(" 3 - Math");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Sair");

            Console.WriteLine("+------------------------------+");

            Console.WriteLine("Select an option: ");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: Examples.CoinTypes(); break;
                case 2: Examples.CoinFormat(); break;
                case 3: Examples.NumberMath(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Option(); break;
            }
        }
    }
}