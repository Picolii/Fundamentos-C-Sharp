using System.Security.Cryptography.X509Certificates;

namespace WorkingWithExceptions
{
    class Examples
    {
        public static void Exceptions()
        {
            Console.Clear();

            // creating fake error
            var arr = new int[3];
            for (var index = 0; index < 10; index++)
            {
                // IndexOutOfRangeException
                Console.WriteLine(arr[index]);
            }
            ReadKey();
        }
        public static void TryCatch_HandlingError()
        {
            Console.Clear();

            try
            {
                Exceptions();
            }
            // specific error treatment 
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Last index not found!\n");
                // using exception error message
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }

            // generic error treatment -> every specific treatment below wont work, set them before
            catch (Exception ex)
            {
                Console.WriteLine("Ops, something went wrong!\n");
                // using exception error message
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }

            ReadKey();
        }
        public static void ShootingExceptions()
        {
            Console.Clear();

            try
            {
                Register("");
            }
            // better argument to use
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Failure when text register!\n");
                Console.WriteLine(ex.Message);
            }

            // most generic error exception
            catch (Exception ex)
            {
                Console.WriteLine("Ops, something went wrong!\n");
                Console.WriteLine(ex.Message);
            }

            ReadKey();
        }
        private static void Register(string text)
        {
            if (string.IsNullOrEmpty(text))
                // most generic error exception  
                // throw new Exception("The text cant be null or empty!");

                // better argument to use
                throw new ArgumentNullException("The text cant be null or empty!");
        }
        public static void CustomExceptions()
        {
            Console.Clear();
            try
            {
                Register("");
            }
            // Custom exception
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.WhenHappened);
                Console.WriteLine("Custom Exception!\n");
            }
            // Generic exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, something went wrong!\n");
            }

            static void Register(string text)
            {
                if (string.IsNullOrEmpty(text))
                {
                    throw new MyException(DateTime.Now);
                }
            }

            ReadKey();
        }
        public class MyException : Exception
        {
            public MyException(DateTime date)
            {
                WhenHappened = date;
            }
            public DateTime WhenHappened { get; set; }
        }
        public static void Finally()
        {
            try
            {
                Exceptions();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, something went wrong!\n");
            }
            finally
            {
                Console.WriteLine("Reach the end!");
            }
            ReadKey();
        }
        public static void ReadKey()
        {
            Console.ReadKey();
            Menu.Option();
        }
    }
}