using System;
using System.Collections.Generic;
using System.Linq;

namespace HW1_CS14
{
    internal class Program
    {
        public static void PrintHello(string somestr1)
        {
            Console.WriteLine("1). Hello {0}", somestr1);
        }

        public static int Sum(int[] arraySum)
        {
            int sum = 0;
            foreach (int el in arraySum)
            {
                sum += el;
            }

            return sum;
        }

        public static int Multi(int[] arrayMul)
        {
            int mul = 1;
            foreach (int el in arrayMul)
            {
                mul *= el;
            }

            return mul;
        }

        public static string Reverse(string someStr)
        {
            char[] array = someStr.ToCharArray();
            char[] array2 = new char[someStr.Length];
            int i = 1;
            foreach (char el in array)
            {
                array2[someStr.Length - i] = el;
                i++;
            }

            return new string(array2);
        }

        public static bool Palindrom(string pal)
        {
            return pal.ToLower() == Reverse(pal.ToLower());
        }

        public static void Histogram(int[] array)
        {
            foreach (int el in array)
            {
                for (int i = 0; i < el; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }

        public static string CaesarCipher(string somestring, int key)
        {
            string ABC = "abcdefghijklmnopqrstuvwxyz";
            string ABC2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string resultString = "";
            string signs = " ,.-!?:;";


            for (int i = 0; i < somestring.Length; i++)
            {
                foreach (char el in signs)
                {
                    if (somestring[i] == el)
                        resultString = resultString + el;
                }


                for (int j = 0; j < ABC.Length; j++)
                {
                    if (somestring[i] == ABC[j])
                    {
                        int temp = j + key;
                        while (temp >= ABC.Length)
                            temp -= ABC.Length;
                        resultString = resultString + ABC[temp];
                    }

                    if (somestring[i] == ABC2[j])
                    {
                        int temp = j + key;
                        while (temp >= ABC2.Length)
                            temp -= ABC2.Length;
                        resultString = resultString + ABC2[temp];
                    }
                }
            }

            return resultString;
        }

        public static int[,] Diagonal_reverse(int[,] matrix, int number)
        {
            int[,] result = new int[number, number];
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                    result[i, j] = matrix[j, i];
            }

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                    Console.Write(result[i, j] + " ");
                Console.WriteLine();
            }

            return result;
        }

        public static void Game(int range1, int range2)
        {
            Console.WriteLine("8). Input number for game");
            string ans = Console.ReadLine();
            int answer = Convert.ToInt32(ans);
            if (answer >= range1 && answer <= range2)
            {
                Console.WriteLine("You win! :)  range is [{0} : {1}]", range1, range2);
            }
            else
            {
                Console.WriteLine("Try again");
                Game(range1, range2);
            }
        }

        static bool IsBalanced(string str, char bracketOpen = '[', char bracketClose = ']')
        {
            int balance = 0;
            foreach (var character in str)
            {
                if (character == bracketClose)
                {
                    if (balance == 0)
                    {
                        return false;
                    }

                    balance--;
                }

                if (character == bracketOpen)
                {
                    balance++;
                }
            }

            return balance == 0;
        }

        public static void CharFreq(string str)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>(26);
            str = str.ToLower();

            foreach (char el in str)
            {
                if (Char.IsLetter(el))
                {
                    if (symbols.ContainsKey(el))
                        symbols[el]++;
                    else
                        symbols.Add(el, 1);
                }
            }

            foreach (KeyValuePair<char, int> keyValue in symbols)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }

        public static void DecToBin(int dec)
        {
            int decinfo = dec;
            string reverseBin = "";
            while (dec > 2)
            {
                reverseBin = reverseBin + Convert.ToString(dec % 2);
                dec = dec / 2;
            }

            reverseBin = reverseBin + Convert.ToString(dec);
            Console.WriteLine("11). Binary of dec {0} is {1}", decinfo, Reverse(reverseBin));
        }

        public static void Main(string[] args)

        {
            //1
            PrintHello("Somebody :)");
            //2
            Console.WriteLine("2). Sum is {0}", Sum(new int[] {1, 2, 3, 4}));
            Console.WriteLine("Multiply is {0}", Multi(new int[] {1, 2, 3, 4}));
            //3
            Console.WriteLine("3). Reverse : ");
            Console.WriteLine("3). " + Reverse("Some string for reverse"));
            //4
            string str = "Radar";
            Console.WriteLine("4). {0} is polindrom? It`s {1}", str, Palindrom(str));
            //5
            Console.WriteLine("5). Histogram : ");
            Histogram(new int[] {3, 7, 5, 2});
            //6
            Console.WriteLine("6). CaesarCipher - {0}", CaesarCipher("a.Bb, dAAf!", 2));
            //7
            Console.WriteLine("7). Matrix_reverse");
            int number = 3;
            int[,] myArr =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            myArr = Diagonal_reverse(myArr, number);
            //8
            int range1, range2;
            Random rnd = new Random();
            range1 = rnd.Next(0, 10);
            range2 = rnd.Next(20, 30);
            Game(range1, range2);
            //9
            Console.WriteLine("9). Balance? " + IsBalanced("[]][[]"));
            //10
            Console.WriteLine("10). Dictionary");
            CharFreq("bdabdcadbcddba");
            //11
            DecToBin(24);
        }
    }
}