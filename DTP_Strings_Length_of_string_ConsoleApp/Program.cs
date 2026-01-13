namespace DTP_Strings_Length_of_string_ConsoleApp
{
    internal class Program
    {
        //Do not use library methods
        static void Main(string[] args)
        {
            string str = "computer";
            Console.WriteLine(GetStringLength(str));
        }
        static int GetStringLength(string str)
        {
            int letterCount = 0;
            str.ToCharArray();
            foreach (var letterChar in str)
            {
                letterCount++;
            }
            return letterCount;
        }
    }
}
