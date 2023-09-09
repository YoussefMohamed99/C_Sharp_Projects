namespace Arrays_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flage;
            do
            {
                flage = false;
                Console.Write("Please enter size of your array : ");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                int[] arr_copy = new int[size];
                List<int> list = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter Element Number " + (i + 1) + " : ");
                    arr[i] = int.Parse(Console.ReadLine());
                    arr_copy[i] = arr[i];
                }
                Console.WriteLine("--------------------------------------------------");

                for (int i = 0; i < size; i++)
                {
                    for (int j = 1; j < size; j++)
                    {
                        if (arr[i] == arr_copy[j] && i != j && !list.Contains(arr[i]))
                        {
                            list.Add(arr[i]);
                        }
                    }
                }
                if (IsEmpty(list))
                {
                    Console.WriteLine("No Repeating in this Array ");
                }
                else
                {
                    Console.Write("The repeted numbers is : ");
                    for (int i = 0; i < list.Count; i++)
                    {

                        Console.Write(list[i] + " ");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Do You Want Repeate the Operation Again : \n 1 - Yes \n 2 - No");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    flage = true;
                }

            } while (flage);

        }
        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return list.Count == 0;
        }

    }
}