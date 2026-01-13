namespace DTP_Strings_How_Many_Occurances_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "do it now";
            string substr = "do"; //not a ""substring"" but serves same purpose

            Console.WriteLine(NumberOfOccurances(str,substr));
        }
        static int NumberOfOccurances(string str, string substr)
        {
            int i = 0;
            string[] stringArray = str.Split();
            if (stringArray.Contains(substr))
            {
                foreach (var item in stringArray)
                {
                    if (item.Contains(substr))
                    {
                        i++;
                    }
                }
            }
            return i;

        }
    }
}
