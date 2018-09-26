using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using HW3_CS_OOP.Properties;

namespace HW3_CS_OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            OOP();
            ListFunction();
            ArrayListFunction();
            SortedListTask();
            HierarchyDepartment();
            Div();
            Phone();
        }

        public static void OOP()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("bmw", "black", 18000));
            cars.Add(new Car("camaro", "yellow", 22000));
            cars.Add(new Car("audi", "white", 17000));
            foreach (Car el in cars)
            {
                el.ChangePrice(110);
                el.Print();
            }

            Console.WriteLine("Change white color of car on red : ");
            string newColor = "red";
            foreach (Car el in cars)
            {
                if (el.Color == "white")
                {
                    el.Color = newColor;
                    el.Print();
                }
            }

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Cat("Kuzmin"));
            animals.Add(new Dog("Zhuk"));
            foreach (IAnimal el in animals)
            {
                el.Voice();
                el.Feed();
            }
        }
        
        public static void ListFunction()
        {
            Console.WriteLine("Input 10 numbers for List");
            List<int> myCollList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myCollList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            List<int> newMyCollList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                if (myCollList[i] == -10)
                {
                    newMyCollList.Add(i);
                }
            }

            List<int> newMyCollList2 = new List<int>();
            foreach (int el in myCollList)
            {
                if (el < 20)
                {
                    newMyCollList2.Add(el);
                }
            }

            Console.Write("Indexs that have value -10 are : ");
            foreach (int el in newMyCollList)
            {
                Console.Write($"{el} ");
            }

            Console.WriteLine();
            Console.Write("This update list collection : ");
            foreach (int el in newMyCollList2)
            {
                Console.Write($"{el} ");
            }

            Console.WriteLine();

            if (newMyCollList2.Count >= 8)
            {
                newMyCollList2[2] = 1;
                newMyCollList2[8] = -3;
                newMyCollList2[5] = -4;
            }
            else
                throw new IndexOutOfRangeException("Index out!");

            newMyCollList2.Sort();
            Console.Write("This sort list collection : ");
            foreach (int el in newMyCollList2)
            {
                Console.Write($"{el} ");
            }

            Console.WriteLine();
        }

        public static void ArrayListFunction()
        {
            Console.WriteLine("Input 10 numbers for ArrayList");
            ArrayList myCollArrayList = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                myCollArrayList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            ArrayList newMyCollArrayList1 = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                if (Convert.ToInt32(myCollArrayList[i]) == -10)
                {
                    newMyCollArrayList1.Add(i);
                }
            }

            ArrayList newMyCollArrayList2 = new ArrayList();
            foreach (int el in myCollArrayList)
            {
                if (el < 20)
                {
                    newMyCollArrayList2.Add(el);
                }
            }

            Console.Write("Indexs that have value -10 are : ");
            foreach (int el in newMyCollArrayList1)
            {
                Console.Write($"{el} ");
            }

            Console.WriteLine();
            Console.Write("This update Arraylist collection : ");
            foreach (int el in newMyCollArrayList2)
            {
                Console.Write($"{el} ");
            }

            Console.WriteLine();

            if (newMyCollArrayList2.Count >= 8)
            {
                newMyCollArrayList2[2] = 1;
                newMyCollArrayList2[8] = -3;
                newMyCollArrayList2[5] = -4;
            }
            else
                throw new IndexOutOfRangeException("Index out!");

            newMyCollArrayList2.Sort();
            Console.Write("This sort Arraylist collection : ");
            foreach (int el in newMyCollArrayList2)
            {
                Console.Write($"{el} ");
            }

            Console.WriteLine();
        }

        private static void SortedListTask()
        {
            SortedList<int, int> someSortedList = new SortedList<int, int>();
            Console.WriteLine("Input array:");
            int iterator = 0;
            while (iterator < 10)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                someSortedList.Add(number, number);
                iterator++;
            }

            Console.Write("Indexs that have value -10 are : ");
            if (someSortedList.ContainsKey(-10))
            {
                Console.WriteLine(someSortedList[-10]);
            }

            Console.WriteLine();
            SortedList<int, int> updateSortedList = new SortedList<int, int>();
            foreach (KeyValuePair<int, int> kvp in someSortedList)
            {
                if (kvp.Value < 20)
                {
                    updateSortedList.Add(kvp.Key, kvp.Value);
                }
            }

            updateSortedList[2] = 1;
            updateSortedList[8] = -3;
            updateSortedList[5] = -4;

            Console.WriteLine("Updated SortedList: ");
            foreach (KeyValuePair<int, int> kvp in updateSortedList)
            {
                Console.Write(Convert.ToInt16(kvp.Value) + " ");
            }

            Console.WriteLine();
        }


        private static void HierarchyDepartment()
        {
            Developer developer1 = new Developer(3500, "Roman", "Mark", 3, null);
            Developer developer2 = new Developer(2700, "Vova", "Tsar", 2, null);
            Developer developer3 = new Developer(2900, "Yuriy", "Sen", 4, null);
            Designer designer1 = new Designer(3500, "Yuriy", "Sav", 3, null, 0.8);
            Designer designer2 = new Designer(2700, "Sasha", "Smir", 2, null, 0.9);
            Designer designer3 = new Designer(2900, "Mike", "Taison", 1, null, 0.5);
            List<Employee> team1 = new List<Employee>();
            List<Employee> team2 = new List<Employee>();
            List<Employee> team3 = new List<Employee>();
            team1.Add(developer1);
            team1.Add(designer1);
            team2.Add(developer2);
            team2.Add(designer2);
            team3.Add(developer3);
            team3.Add(designer3);
            List<Manager> managers = new List<Manager>();
            Manager manager1 = new Manager(5000, "Vasyl", "Pet", 4, null, team1);
            Manager manager2 = new Manager(6000, "Ivan", "Por", 4, null, team2);
            Manager manager3 = new Manager(7000, "Dima", "Mon", 4, null, team3);
            managers.Add(manager1);
            managers.Add(manager2);
            managers.Add(manager3);
            Departament department = new Departament(managers);
            department.GiveSalary(designer1);
            department.GiveSalary(manager2);
            
            //This is for SalaryGivingException
            //Designer designer4 = new Designer(4000, "M", "Ta", 1, null, 0.5);
            //department.GiveSalary(designer4);
        }
        
        public static void Div()
        {
            decimal result = 0;
            decimal a = 0;
            decimal b = 0;
            try
            {
                using (StreamReader reader = new StreamReader(@"D:\kpi\Rider\project\HW3_CS_OOP\HW3_CS_OOP\Files\data.txt"))
                {
                    a = Convert.ToDecimal(reader.ReadLine());
                    b = Convert.ToDecimal(reader.ReadLine());
                    result = a / b;
                }

                using (StreamWriter writer = new StreamWriter(@"D:\kpi\Rider\project\HW3_CS_OOP\HW3_CS_OOP\Files\rez.txt"))                  
                {
                    writer.WriteLine(result);
                }
                
                string path = @"D:\kpi\Rider\project\HW3_CS_OOP\HW3_CS_OOP\allText.txt";
                if (File.Exists(path))
                {
                    string text = $"{a} / {b} = {result}";
                    File.WriteAllText(path, text);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        
        public static void Phone()
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>(9);
            string PersonName, PhoneNumber;
            using (StreamReader reader = new StreamReader(@"D:\kpi\Rider\project\HW3_CS_OOP\HW3_CS_OOP\Files\phones.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    PersonName = reader.ReadLine();
                    PhoneNumber = reader.ReadLine();
                    PhoneBook.Add(PersonName, PhoneNumber);
                }
            }
            using (StreamWriter writer = new StreamWriter(@"D:\kpi\Rider\project\HW3_CS_OOP\HW3_CS_OOP\Files\onlyPhone.txt"))
            {
                foreach (KeyValuePair<string, string> keyValue in PhoneBook)
                {
                    writer.WriteLine(keyValue.Value);
                }
            }

            Console.WriteLine("Enter Name for finding name : ");
            string str = Console.ReadLine();
            
            foreach (KeyValuePair<string, string> keyValue in PhoneBook)
            {
                if(keyValue.Key ==str)
                    Console.WriteLine($"The phone number of {str} is {keyValue.Value}");
            }
            
            using (StreamWriter writer = new StreamWriter(@"D:\kpi\Rider\project\HW3_CS_OOP\HW3_CS_OOP\Files\new.txt"))
            {
                foreach (KeyValuePair<string, string> keyValue in PhoneBook)
                {
                    writer.WriteLine("+3"+keyValue.Value);
                }
            }
            
        }
    }
}