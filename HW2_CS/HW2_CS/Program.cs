using System;
using System.Collections;

namespace HW2_CS
{
    internal class Program
    {
        public static void PrintInfoCircle(int radius)
        {
            Console.WriteLine("1). Radius of circle is {0:0.##}. Circle circumference is {1:0.##}." +
                              " Circle area is {2:0.##} and the sphere volume of this radius is {3:0.##}",
                radius, 2 * Math.PI * radius, Math.PI * Math.Pow(radius, 2), 4.0 / 3 * Math.PI * Math.Pow(radius, 3));
        }

        public static void PrintGreeting(int h, int m)
        {
            if (h < 0 || h > 23 || m < 0 || m > 59)
            {
                throw new Exception("Incorrect time!");
            }

            if (h < 7)
                Console.WriteLine("2). Good night");
            if (h >= 7 && h < 12)
                Console.WriteLine("2). Good morning");
            if (h >= 12 && h < 19)
                Console.WriteLine("2). Good afternoon");
            if (h >= 19 && h <= 24)
                Console.WriteLine("2). Good evening");
        }

        enum Color
        {
            Green,
            Blue,
            Red,
            Black
        }

        public static void FavouriteColor()
        {
            Console.WriteLine("3). My favourite color are : {0} and {1}", Color.Black, Color.Green);
        }

        struct MyData
        {
            public int day;
            public int month;
            public int year;

            public void Info()
            {
                Console.WriteLine($"4). This data is {day}.{month}.{year}");
            }
        }

        public static void DivideOnThree()
        {
            int a, b;
            Console.WriteLine("5). Input a and b. a must be less than b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
                throw new Exception("a must be less then b");
            else
            {
                Console.Write("Numbers in range that devide on 3 : ");
                for (int i = a + 1; i < b; i++)
                {
                    if (i % 3 == 0)
                        Console.Write($"{i} ");
                }
            }
        }

        public static void NaturalAverage()
        {
            ArrayList arrayList = new ArrayList();
            int number;
            Console.WriteLine();
            Console.WriteLine("6). Input only natural numbers for find average");
            while (true)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 1)
                    break;
                arrayList.Add(number);
            }

            double average = 0;
            foreach (int el in arrayList)
            {
                average += el;
            }

            average /= arrayList.Count;
            Console.WriteLine($"Average of numbers is {average}");
        }

        public static int ArrayFunction(int[] array)
        {
            int sum = 0;
            int multi = 1;
            bool positive = true;
            for (int i = 0; i < 5; i++)
            {
                multi = multi * array[5 + i];
                sum += array[i];
                if (array[i] < 1)
                    positive = false;
            }

            return positive ? sum : multi;
        }

        public static void Main(string[] args)
        {
            //1
            PrintInfoCircle(9);
            //2
            PrintGreeting(13, 30);
            //3
            FavouriteColor();
            //4
            MyData dat = new MyData();
            dat.day = 2;
            dat.month = 9;
            dat.year = 2018;
            dat.Info();
            //5
            DivideOnThree();
            //6
            NaturalAverage();
            //7
            int result = ArrayFunction(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            Console.WriteLine($"7). Result is {result}");
        }
    }
}