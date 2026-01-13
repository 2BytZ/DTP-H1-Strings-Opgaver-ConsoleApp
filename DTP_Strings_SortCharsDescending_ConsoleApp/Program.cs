using System.Collections;
using System.ComponentModel;

namespace DTP_Strings_SortCharsDescending_ConsoleApp
{
    internal class Program
    { //char c = (char)65;
        static void Main(string[] args)
        {
            string str = "fohjwf42os";
            Console.WriteLine(SortChars_Descending(str));
        }
        static string SortChars_Descending(string str)
        {
            string result = "";
            var charList = (str.ToCharArray());
            //Sort charList to descending order
            charList = charList.OrderByDescending(c => c).ToArray(); //<--- I don't get it. What is keySelector?
            for (int i = 0; i <= charList.Length-1; i++)
            {
                char c = (char)charList[i];
                result += c;
            }
            return result;
        }
    }
}
