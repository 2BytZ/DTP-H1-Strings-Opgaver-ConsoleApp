namespace DTP_Strings_NumberOfWords_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a test";
            Console.WriteLine(GetWordCount(str));
        }
        static int GetWordCount(string str)
        {
            string[] words = str.Split(" ");
            return words.Length;
            
        }
    }
}
