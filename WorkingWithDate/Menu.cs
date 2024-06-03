namespace WorkingWithDate
{
    public class Menu()
    {
        public static void Option()
        {
            Console.Clear();

            Console.WriteLine(" What do you want to do? \n");
            Console.WriteLine(" 1 - Initializing With Dates");
            Console.WriteLine(" 2 - Getting Date Values");
            Console.WriteLine(" 3 - Date Formatting");
            Console.WriteLine(" 4 - Default Format");
            Console.WriteLine(" 5 - Adding Values");
            Console.WriteLine(" 6 - Comparing Dates");
            Console.WriteLine(" 7 - Culture Info");
            Console.WriteLine(" 8 - Time Zone");
            Console.WriteLine(" 9 - Time Span");
            Console.WriteLine(" 10 - Days in Month");
            Console.WriteLine(" 11 - Is Week Day");
            Console.WriteLine(" 12 - Is Daylight Saving Time");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Sair");

            Console.WriteLine("+------------------------------+");

            Console.WriteLine("Select an option: ");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: Examples.InitializingWithDates(); break;
                case 2: Examples.GettingDateValues(); break;
                case 3: Examples.DateFormatting(); break;
                case 4: Examples.DefaultFormat(); break;
                case 5: Examples.AddingValues(); break;
                case 6: Examples.ComparingDates(); break;
                case 7: Examples.CultureInfo(); break;
                case 8: Examples.TimeZone(); break;
                case 9: Examples.TimeSpan(); break;
                case 10: Examples.DaysInMonth(); break;
                case 11: Console.WriteLine(Examples.IsWeekDay(DateTime.Now.DayOfWeek)); break;
                case 12: Examples.IsDaylightSavingTime(); break;
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