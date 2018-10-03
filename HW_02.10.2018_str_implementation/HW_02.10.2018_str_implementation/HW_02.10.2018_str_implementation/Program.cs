using System;

namespace HW_02._10._2018_str_implementation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str = "implementation";
            str = str.ToUpper();
            char[] strChars = str.ToCharArray();
            for (int i = 0; i < strChars.Length; i++)
            {
                if (strChars[i] == 'M')
                    strChars[i] = 'm';
            }

            foreach (char letter in strChars)
            {
                Console.Write(letter);
            }
        }
    }
}

