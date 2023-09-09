namespace Arrayes_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();

        }
        public static void menu()
        {
            bool again = true;
            string[] str = getting_array();
            do
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine(" 1 - Printing \n 2 - Reversing \n 3 - Searching \n 4 - Exit");
                Console.WriteLine("-----------------------------------------------------");
                int operating_number = int.Parse(Console.ReadLine());
                switch (operating_number)
                {
                    case 1:
                        print_array(str);
                        break;
                    case 2:
                        revers_array(str);
                        break;
                    case 3:
                        search_array(str);
                        break;
                    case 4:
                        again = false;
                        break;
                    default:
                        Console.WriteLine("Enter a Falid Number i [ 1 , 4 ]");
                        break;

                }

            } while (again == true);


        }
        public static void print_array(string[] array)
        {
            Console.WriteLine("           Printing array");
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(" , ");
                }


            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");



        }
        public static void revers_array(string[] arr)
        {

            Console.WriteLine("              Reversing array");
            Console.WriteLine("-----------------------------------------------------");
            int count = 0;
            string[] rev = new string[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                rev[count] = arr[i];
                count++;
            }
            Console.Write("Reversed Array : ");
            for (int i = 0; i < rev.Length; i++)
            {
                Console.Write(rev[i] + "  ");
            }
            Console.WriteLine();

        }
        public static void search_array(string[] array)
        {

            Console.WriteLine("                   Searching array");
            Console.WriteLine("-----------------------------------------------------");
            bool isFound = false, flage = false;

            Console.Write("Enter a name or letter to search : ");
            string n = Console.ReadLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains(n, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(" is found in : " + array[i]);
                    isFound = true;
                }

            }
            if (isFound == false)
            {
                Console.WriteLine("Not Found in array");
            }





        }
        public static string[] getting_array()
        {

            Console.WriteLine("              Getting array");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Enter the Size of your Array :  ");
            int size = int.Parse(Console.ReadLine());
            string[] array = new string[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter Element number " + (i + 1) + " :: ");
                array[i] = Console.ReadLine();
            }

            return array;

        }
        
    }

}