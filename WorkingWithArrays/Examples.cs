namespace WorkingWithArrays
{
    public class Examples()
    {
        public static void Arrays()
        {
            Console.Clear();

            // int[] myArray = new int[]
            var myArray = new int[5] { 10, 11, 12, 13, 14 };
            myArray[0] = 21;
            // two ways to set a value in a array
            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[1]);
            Console.WriteLine(myArray[2]);
            Console.WriteLine(myArray[3]);
            Console.WriteLine(myArray[4]);

            // other way to initialize the array using struct
            var otherArray = new Test[1] { new Test() };
            Console.WriteLine(otherArray[0].Id);

            ReadKey();
        }
        struct Test
        {
            public int Id { get; set; }
        }
        public static void TraversingAnArray()
        {
            Console.Clear();

            var myArray = new int[5] { 1, 2, 3, 4, 5 };
            myArray[0] = 21;

            // Console.WriteLine(myArray.Length);

            for (int index = 0; index < myArray.Length; index++)
            {
                Console.WriteLine(myArray[index]);
            }

            ReadKey();
        }
        public static void ForEach()
        {
            Console.Clear();

            var myArray = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            // with struct
            var otherArray = new Functionary[5];
            otherArray[0] = new Functionary() { Id = 2579, Name = "Bernardo" };

            foreach (var functionary in otherArray)
            {
                Console.WriteLine(functionary.Id);
                Console.WriteLine(functionary.Name);
            }

            ReadKey();
        }
        public struct Functionary
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public static void ChangingValues()
        {
            Console.Clear();

            var arr = new int[4];
            arr[0] = 23;

            //copy the arr value
            var arrb = arr;
            // == arrb[0] = arr[0];
            // == arr.CopyTo(arrb, 0);
            Console.WriteLine(arrb[0]);

            //create new array
            var arrb2 = new int[3];

            ReadKey();
        }
        public static void ReadKey()
        {
            Console.ReadKey();
            Menu.Option();
        }
    }
}
