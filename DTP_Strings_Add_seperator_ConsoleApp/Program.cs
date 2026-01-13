namespace DTP_Strings_Add_seperator_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "STRING";
            Console.WriteLine(Method(str));
        }
        static string Method(string str)
        {
            string newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                newString += str[i] + "_";
            }
            return newString.Remove(newString.LastIndexOf("_"));
        }
    }
}
