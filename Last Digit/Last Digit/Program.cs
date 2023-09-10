namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Last Digit is : "+lastDigit(userInput()));
        }
        static char userInput() {
            Console.Write("Enter a number Please : ");
            string str = Console.ReadLine();
            return str.Last();
        }
        static string lastDigit(char c)
        {
            string str = "";
            switch(c)
            {
                case '0': str = "Zero"; break;
                case '1': str = "One"; break;
                case '2': str = "Two"; break;
                case '3': str = "Three"; break;
                case '4': str = "four"; break;
                case '5': str = "five"; break;
                case '6': str = "six"; break;
                case '7': str = "seven"; break;
                case '8': str = "eight"; break;
                case '9': str = "nine"; break;
            }
            return str;
        }
    }
}