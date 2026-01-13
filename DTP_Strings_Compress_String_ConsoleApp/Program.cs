namespace DTP_Strings_Compress_String_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "kkkktttrrrrrrrrrr";
            if (String.IsNullOrEmpty(str))
            {
                Console.WriteLine("String Empty");
            }
            Console.WriteLine(CompressString(str));
        }
        static string CompressString(string str)
        {
            string result = "";
            var strList = str.ToArray();
            int j = 0;
            int i = 0;
            for (i = 0; i <= strList.Length - 2; i++)
            {

                if (strList[i] == strList[i + 1])
                {
                    j++;
                }
                else
                {
                    j++;
                    result += strList[i] + $"{j}";
                    j = 0; // reset counter
                }
            }
            j++;
            result += strList[i] + $"{j}";
            return result;
        }
    }
}
