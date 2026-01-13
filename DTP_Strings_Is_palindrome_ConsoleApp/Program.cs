namespace DTP_Strings_Is_palindrome_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "racecar";
            Console.WriteLine(Method(str));
        }
        static bool Method(string str)
        {
            string forwards = str;
            string backwards = "";
            for (int i = forwards.Length; i <= 0; i--)
                backwards += forwards[i];
            if (String.Compare(forwards, backwards) == 1)
                return true;
            else
                return false;
        }
    }
}
