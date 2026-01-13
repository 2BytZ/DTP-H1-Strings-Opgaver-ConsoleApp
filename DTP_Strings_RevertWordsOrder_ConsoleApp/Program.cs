namespace DTP_Strings_RevertWordsOrder_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "A, B. C";
            Console.WriteLine(ReverseWordOrder(str));
        }
        static string ReverseWordOrder(string str)
        {
            string newString = "";
            string[] newStringArray = str.Split(" ");
            for (int i = newStringArray.Length - 1; i >= 0; i--)
            {
                newString += newStringArray[i] + " ";               
            }
            if (str.Contains(".") && str.LastIndexOf(".") == str.Length-1)
                {
                    newString = newString.Replace(".", "");
                    newString = newString.Insert(str.Length-1, ".");
                    return newString;
                }
            return newString;

        }
    }
}
