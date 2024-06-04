namespace WorkingWithExceptions
{
    class Menu
    {
        public static void Option()
        {
            Console.Clear();

            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine("1 - Exceptions");
            Console.WriteLine("2 - TryCatch & HandlingError");
            Console.WriteLine("3 - ShootingExceptions");
            Console.WriteLine("4 - CustomExceptions");
            Console.WriteLine("5 - Finally \n");

            Console.WriteLine("0 - Exit");
            Console.WriteLine("+------------------------------+");

            Console.WriteLine("Select an option:");

            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: Examples.Exceptions(); break;
                case 2: Examples.TryCatch_HandlingError(); break;
                case 3: Examples.ShootingExceptions(); break;
                case 4: Examples.CustomExceptions(); break;
                case 5: Examples.Finally(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    };

                default: Option(); break;
            }


        }
    }
}