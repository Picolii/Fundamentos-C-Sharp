namespace WorkingWithArrays
{
    public class Menu()
    {
        public static void Option()
        {
            Console.Clear();

            Console.WriteLine(" What do you want to do? \n");
            Console.WriteLine(" 1 - Arrays");
            Console.WriteLine(" 2 - TraversingAnArray");
            Console.WriteLine(" 3 - ForEach");
            Console.WriteLine(" 4 - ChangingValues");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Sair");

            Console.WriteLine("+------------------------------+");

            Console.WriteLine("Select an option: ");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: Examples.Arrays(); break;
                case 2: Examples.TraversingAnArray(); break;
                case 3: Examples.ForEach(); break;
                case 4: Examples.ChangingValues(); break;
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