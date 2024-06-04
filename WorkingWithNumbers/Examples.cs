using System.Globalization;

namespace WorkingWithNumbers
{
    public class Examples()
    {
        public static void CoinTypes()
        {
            Console.Clear();

            //assume type double
            var v1 = 10.25;
            Console.WriteLine($"Var: {v1}");

            //better, but bigger than a float -> m in the final
            decimal v2 = 10.25m;
            Console.WriteLine($"Decimal: {v2}");

            ReadKey();
        }
        public static void CoinFormat()
        {
            Console.Clear();

            //converts value to a different culture
            Console.WriteLine("Converting value to different cultures ");

            decimal v = 10.25m;
            var cultureBR = CultureInfo.CreateSpecificCulture("pt-BR");
            Console.WriteLine($"pt-BR: {v.ToString(cultureBR)}");
            var cultureUS = CultureInfo.CreateSpecificCulture("en-US");
            Console.WriteLine($"en-US: {v.ToString(cultureUS)}");

            //format value to a different types
            Console.WriteLine("\nFormatting value to different types");

            decimal v2 = 51262;
            Console.WriteLine($"Using 'G' \n-> generic: {v2.ToString("G", cultureBR)}");
            Console.WriteLine($"Using br 'C' \n-> currency: {v2.ToString("C", cultureBR)}");
            Console.WriteLine($"Using us 'C' \n-> currency: {v2.ToString("C", cultureUS)}");
            Console.WriteLine($"Using 'F' \n-> more precision: {v2.ToString("F", cultureBR)}");
            Console.WriteLine($"Using 'N' \n-> currency w/o R$: {v2.ToString("N", cultureBR)}");
            Console.WriteLine($"Using 'P' \n-> %: {v2.ToString("P", cultureBR)}");

            ReadKey();
        }
        public static void NumberMath()
        {
            Console.Clear();

            decimal v = 10536.25m;
            Console.WriteLine($"Default Value: {v}\n");

            //round the value 10536.25 -> 10536
            Console.WriteLine("Rounded Value: " + Math.Round(v));
            //round the value ceiling 10536.25 -> 10537
            Console.WriteLine("Rounded Ceiling Value: " + Math.Ceiling(v));
            //round the value floor 10536.25 -> 10536
            Console.WriteLine("Rounded Floor Value: " + Math.Floor(v));

            ReadKey();
        }
        public static void ReadKey()
        {
            Console.ReadKey();
            Menu.Option();
        }
    }
}
