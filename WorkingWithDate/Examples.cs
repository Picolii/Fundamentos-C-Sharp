namespace WorkingWithDate
{
    public class Examples()
    {
        public static void InitializingWithDates()
        {
            Console.Clear();

            //Just get the date format without value
            var date = new DateTime();
            Console.WriteLine("No value date: " + date);

            Console.WriteLine(" ");

            //Actual date with sys default format
            var dateNow = DateTime.Now;
            Console.WriteLine("Actual date: " + dateNow);

            ReadKey();
        }
        public static void GettingDateValues()
        {
            Console.Clear();

            //Setting a value to the date
            var date = new DateTime(2020, 10, 12, 8, 23, 14);
            Console.WriteLine("Date with predefined value: \n" + date);
            Console.WriteLine(" ");

            //Getting a specific value of the date
            Console.WriteLine("Getting a specific value of the date");
            Console.WriteLine("Year: " + date.Year);
            Console.WriteLine("Month: " + date.Month);
            Console.WriteLine("Day: " + date.Day);
            Console.WriteLine("Hour: " + date.Hour);
            Console.WriteLine("Minute: " + date.Minute);
            Console.WriteLine("Second: " + date.Second);
            Console.WriteLine(" ");

            //Getting the day of week and year
            Console.WriteLine("Day of week: " + date.DayOfWeek);
            Console.WriteLine("Typed day of week: " + (int)date.DayOfWeek);

            Console.WriteLine("Day of year: " + date.DayOfYear);
            ReadKey();
        }
        public static void DateFormatting()
        {
            Console.Clear();
            // Year = Y | yy | yyyy    // Hour = H
            // Month = M | MM         // Minutes = mm 
            // Day = d | dd          // Seconds = s

            var date = DateTime.Now;

            var dateFormat = string.Format("{0}", date);
            Console.WriteLine(dateFormat + "\n");

            //Year formatting --> 'y' 'yy' 'yyyy'
            var yearFormat1 = string.Format("{0:y}", date);
            Console.WriteLine($"Year format 'y': {yearFormat1}");
            var yearFormat2 = string.Format("{0:yy}", date);
            Console.WriteLine($"Year format 'yy': {yearFormat2}");
            var yearFormat3 = string.Format("{0:yyyy}", date);
            Console.WriteLine($"Year format 'yyyy': {yearFormat3}\n");

            //Month formatting
            var monthFormat = string.Format("{0:M}", date);
            Console.WriteLine($"Month format 'M': {monthFormat}");
            var monthFormat2 = string.Format("{0:MM}", date);
            Console.WriteLine($"Month format 'MM': {monthFormat2}\n");

            //Minute formatting
            var minutesFormat = string.Format("{0:mm}", date);
            Console.WriteLine($"Minute format 'mm': {minutesFormat}\n");

            //Full date formatting
            var dated = string.Format("{0:yyyy/MM/dd}", date);
            Console.WriteLine($"'yyyy/MM/dd'\n Date: {dated}\n");
            //Second Fraction = f
            var clocked = string.Format("{0:dd.MM.yyyy hh:mm:ss f}", date);
            Console.WriteLine($"'dd.MM.yyyy hh:mm:ss f' \nSecond fraction: {clocked}\n");
            //Timezone = z
            var moreInfo = string.Format("{0:dd/MM/yyyy hh:mm:ss z}", date);
            Console.WriteLine($"'dd/MM/yyyy hh:mm:ss z' \nTime zone: {moreInfo}\n");

            ReadKey();
        }
        public static void DefaultFormat()
        {

            ReadKey();
        }
        public static void AddingValues()
        {

            ReadKey();
        }
        public static void ComparingDates()
        {

            ReadKey();
        }
        public static void CultureInfo()
        {

            ReadKey();
        }
        public static void TimeZone()
        {

            ReadKey();
        }
        public static void TimeSpan()
        {
            Console.Clear();

            // TimeSpan
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);
            // TimeSpan Nano Seconds -> NanoS
            var timeSpanNanoS = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoS);
            // TimeSpan Hour, Minutes and Seconds -> H_M_S
            var timeSpanH_M_S = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanH_M_S);
            // TimeSpan Day, Hour, Minutes and Seconds -> D_H_M_S
            var timeSpanD_H_M_S = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanD_H_M_S);
            // TimeSpan Day, Hour, Minutes, Seconds and MilliSeconds -> D_H_M_S_Ms
            var timeSpanD_H_M_S_Ms = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanD_H_M_S_Ms);

            Console.WriteLine(" ");

            Console.WriteLine(timeSpanD_H_M_S - timeSpanD_H_M_S);
            Console.WriteLine(timeSpanD_H_M_S.Days);
            Console.WriteLine(timeSpanD_H_M_S.Add(new TimeSpan(12, 0, 0)));

            ReadKey();
        }
        public static void DaysInMonth()
        {
            Console.Clear();
            // Get how many days has in the month -> (year, monthSelected)
            Console.WriteLine(DateTime.DaysInMonth(2024, 2));
            ReadKey();
        }
        public static bool IsWeekDay(DayOfWeek today)
        {
            Console.Clear();
            // Get the day and see if this is a weekend day
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
        public static void IsDaylightSavingTime()
        {
            Console.Clear();
            //Is Daylight Saving Time -> Horário de verão
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
            ReadKey();
        }
        public static void ReadKey()
        {
            Console.ReadKey();
            Menu.Option();
        }
    }
}