namespace DTP_Strings_reverse_string_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "oe93 kr";
            Console.WriteLine(BippityBoppity_ReverseThatString_Property(str));
        }
        static string BippityBoppity_ReverseThatString_Property(string str)
        {
            string forwards = str;
            string backwards = "";
            for (int i = forwards.Length-1; i >= 0; i--)
            {
                backwards += forwards[i];
            }
            return backwards;
            // couldn't get .Reverse to work :/
        }
    }
}
